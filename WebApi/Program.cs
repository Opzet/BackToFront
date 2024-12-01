using Microsoft.Owin.Hosting;
using Models;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;


namespace WebApi
{
    internal class Program
    {
        private static bool IsRunAsAdministrator()
        {
            var wi = WindowsIdentity.GetCurrent();
            var wp = new WindowsPrincipal(wi);

            return wp.IsInRole(WindowsBuiltInRole.Administrator);
        }

        static void Main(string[] args)
        {
            if (Debugger.IsAttached)
            {
                // Check Db
                CRUD.DbUtils.Init();

                if (!IsRunAsAdministrator())
                {
                    var processInfo = new ProcessStartInfo(Assembly.GetCallingAssembly().CodeBase);

                    // The following properties run the new process as administrator
                    processInfo.UseShellExecute = true;
                    processInfo.Verb = "runas";

                    // Start the new process
                    try
                    {
                        Process.Start(processInfo);
                    }
                    catch (Exception)
                    {
                        // The user did not allow the application to run as administrator
                        Console.WriteLine("Sorry, this application must be run as Administrator.");
                    }

                    // Shut down the current process
                    return;
                }
            }

            if (!ApiSetup.IsPortAvailable(ApiSetup.InternalPort))
            {
                Console.WriteLine($"Web Api Server {ApiSetup.localIPAddress} : Port {ApiSetup.InternalPort} is not available. Please close any applications that may be using this port and try again!!!.");
                Console.ReadKey();
                return;
            }

            string baseAddress = $"http://{ApiSetup.localIPAddress}:{ApiSetup.InternalPort}/"; // You can change the port number

            Version ver;
            string Deployed = "";

            try
            {
                ver = ApplicationDeployment.CurrentDeployment.UpdatedVersion;
                Deployed = "-Deployed-";
            }
            catch (Exception)
            {
                ver = Assembly.GetCallingAssembly().GetName().Version;
                Deployed = "-Local-";
            }

            string heading = $"<< WEB API - SERVER {Deployed} Version: {ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision} >>";
            string subheading = $"{Helpers.Utils.GetVersionString()}\r\nStarted : {DateTime.Now.ToString("hh:mm ddd, dd MMM").ToUpper()}";

            string border = new string('-', heading.Length > subheading.Length ? heading.Length : subheading.Length);

            // Start OWIN host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"\r\n{border}\r\n{heading}\r\n{subheading}\r\n{border}\r\n");
                Console.WriteLine($"Web API started at {baseAddress}");

                // Spin Up WebApi by doing a call
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine($"\n<OWIN WEB API HOST STARTED>\n");
                Console.WriteLine("\thttp Web test Request ... please wait ...\n");


                // Do a dummy call to the WebApi server to spin it up
                var productWebList = WebApiClient.ApiCalls.GetAllAsync<Product>().Result;

                // Display the WebApi response
                try
                {
                    if (productWebList != null && productWebList.Any())
                    {
                        Console.WriteLine("Products retrieved from Web API:");
                        foreach (var product in productWebList)
                        {
                            Console.WriteLine("\nProduct:");
                            foreach (PropertyInfo prop in product.GetType().GetProperties())
                            {
                                Console.WriteLine($"\t{prop.Name}: {prop.GetValue(product, null)}");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\t>WebApiClient.ApiCalls.GetAllAsync<Product>() returned null.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while retrieving products: {ex.Message}");
                }


                sw.Stop(); // Stop stopwatch
                Console.WriteLine($"\n\n<INITIALISED : DURATION> Startup Time: {sw.ElapsedMilliseconds} ms");

                Console.WriteLine("Press <ENTER> to stop the server and close the app...");
                Console.ReadLine();
            }
        }
    }
}
