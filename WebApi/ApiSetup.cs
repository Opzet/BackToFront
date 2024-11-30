using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

namespace WebApi
{
    /// <summary>
    /// Provides utilities for setting up and configuring the API, including network-related operations.
    /// </summary>
    public static class ApiSetup
    {
        /// <summary>
        /// The local IP address to be used by the API.
        /// </summary>
        /// 

#if TESTING
        public static IPAddress localIPAddress = new IPAddress(new byte[] { 127, 0, 0, 1 });
         //public static IPAddress localIPAddress = new IPAddress(new byte[] { 192, 168, 100, 109 });
#else
        public static IPAddress localIPAddress = new IPAddress(new byte[] { 192, 168, 100, 171 }); //SVR14
#endif                                                                                           //public static IPAddress localIPAddress = new IPAddress(new byte[] { 192, 168, 100, 109 });
        /// <summary>
        /// The internal port on which the API listens.
        /// </summary>
        public const int InternalPort = 54322;  //<<for TESTING

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
            throw new Exception("No network adapters with an IPv4 address in the system!");
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
