using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Net.Http;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;


namespace WebApiClient
{
    /// <summary>
    /// Provides utilities for setting up and configuring the API, including network-related operations.
    /// </summary>
    public static class ApiSetup
    {
        /// <summary>
        /// The local IP address to be used by the API.
        /// </summary>
#if LOCAL_WEBAPI_TESTING //DISABLE IN PROJECT PROPERTIES
        public static IPAddress localIPAddress = new IPAddress(new byte[] { 127, 0, 0, 1 });
#else
        public static IPAddress localIPAddress = new IPAddress(new byte[] { 192, 168, 100, 171 }); 
#endif
        /// <summary>
        /// The internal port on which the API listens.
        /// </summary>
        public const int InternalPort = 54322;  //<< CLIENT TESTING

        public static string Token { get; internal set; }

        public static async Task<string> GetToken()
        {
            string token = "";

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Post, "https://127.0.0.1:54322/token");
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", "user"),
                    new KeyValuePair<string, string>("password", "pass")
                });
                request.Content = content;

                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var tokenResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Token Response: " + tokenResponse);
                    token = tokenResponse;
                }
                else
                {
                    Console.WriteLine("Error: " + response.StatusCode);
                }
            }
            return token;
        }

        /// <summary>
        /// Retrieves the local IP address of the host.
        /// </summary>
        /// <returns>The local <see cref="IPAddress"/>.</returns>
        /// <exception cref="Exception">Thrown when no network adapters with an IPv4 address are found in the system.</exception>
        public static IPAddress GetLocalIPAddress()
        {
            Debug.WriteLine("Attempting to retrieve local IP Address.");
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Debug.WriteLine($"Local IPv4 address found: {ip}");
                    return ip;
                }
            }
            Debug.WriteLine("No network adapters with an IPv4 address in the system. Throwing exception.");
            throw new System.Exception("No network adapters with an IPv4 address in the system!");
        }

        /// <summary>
        /// Checks if a given port is available on the local machine.
        /// </summary>
        /// <param name="port">The port number to check.</param>
        /// <returns><c>true</c> if the port is available; otherwise, <c>false</c>.</returns>
        public static bool IsPortAvailable(int port)
        {
            TcpListener tcpListener = null;
            try
            {
                tcpListener = new TcpListener(localIPAddress, port);
                tcpListener.Start();
                Debug.WriteLine($"local {localIPAddress} : port {port} is available.");
                return true;
            }
            catch (SocketException ex)
            {
                Debug.WriteLine($"local {localIPAddress} : port {port} is not available. Exception: {ex.Message}");
                return false;
            }
            finally
            {
                tcpListener?.Stop();
            }
        }
    }
}
