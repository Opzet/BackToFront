﻿using Microsoft.Owin.Hosting;
using System;
using System.Deployment.Application;
using System.Diagnostics;
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
            if (Debugger.IsAttached) {
                if (!IsRunAsAdministrator()) {
                    var processInfo = new ProcessStartInfo(Assembly.GetCallingAssembly().CodeBase);

                    // The following properties run the new process as administrator
                    processInfo.UseShellExecute = true;
                    processInfo.Verb = "runas";

                    // Start the new process
                    try {
                        Process.Start(processInfo);
                    }
                    catch (Exception) {
                        // The user did not allow the application to run as administrator
                        Console.WriteLine("Sorry, this application must be run as Administrator.");
                    }

                    // Shut down the current process
                    return;
                }
            }

            if (!ApiSetup.IsPortAvailable(ApiSetup.InternalPort)) {

                Console.WriteLine($"Web Api Server {ApiSetup.localIPAddress} : Port {ApiSetup.InternalPort} is not available. Please close any applications that may be using this port and try again!!!.");
                Console.ReadKey();
                return;

            }
            string baseAddress = $"http://{ApiSetup.localIPAddress}:{ApiSetup.InternalPort}/"; // You can change the port number

            Version ver;
            string Deployed = "";

            try {
                ver = ApplicationDeployment.CurrentDeployment.UpdatedVersion;
                Deployed = "-Deployed-";
            }
            catch (Exception) {
                ver = Assembly.GetCallingAssembly().GetName().Version;
                Deployed = "-Local-";
            }

            string heading = $"<< QAWORX WEB API - SERVER {Deployed} Version: {ver.Major}.{ver.Minor}.{ver.Build}.{ver.Revision} >>";
            string subheading = $"{Helpers.Utils.GetVersionString()}\r\nStarted : {DateTime.Now.ToString("hh:mm ddd, dd MMM").ToUpper()}";
            

            string border = new string('-', heading.Length > subheading.Length ? heading.Length : subheading.Length);

            // Start OWIN host
            using (WebApp.Start<Startup>(url: baseAddress)) {
                Console.WriteLine($"\r\n{border}\r\n{heading}\r\n{subheading}\r\n{border}\r\n");
                Console.WriteLine($"Web API started at {baseAddress}");

                //Spin Up WebApi by doing a call
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Console.WriteLine($"<SPIN SPIN UP OWIN HOST> Dummy http Web Request ");
                Console.WriteLine("...please wait...");

                CRUD.JobActionResponse response = CRUD.Get_JobBasic("46464000", "WebApi", "Startup Test", Environment.UserName);

                // Display the response
                Console.WriteLine ($"Response Success: {response.Success}");
                if (response.JobDetail!=null)
                {
                    Console.WriteLine ($"Job No: {response.JobDetail.JobNo}");
                    Console.WriteLine ($"Cust :  {response.JobDetail.Cust}");
                    Console.WriteLine ($"Item :  {response.JobDetail.ItemDescription}");
                    // Add more properties of JobDetail as needed
                }
                if (!string.IsNullOrEmpty (response.ErrorMessage))
                {
                    Console.WriteLine ($"Error Message: {response.ErrorMessage}");
                }

                
                sw.Stop(); // Stop stopwatch
                Console.WriteLine($"<INITIALISE DURATION> Startup Time: {baseAddress} - {sw.ElapsedMilliseconds} ms");

                Console.WriteLine("Press <ENTER> to stop the server and close the app...");
                Console.ReadLine();
            }
        }
    }
}