using System.Reflection;
using System.Diagnostics;
using System.IO;


namespace Helpers
{
    public static class Utils
    {
        /// <summary>
        /// Method to get version string including the assembly name and build date
        /// </summary>
        /// <returns></returns>
        public static string GetVersionString()
        {
            // Initialize assembly name and build date
            string assemblyName = "Debugging";
            string buildDate = "--";

            // Check if the calling assembly is not null
            if (Assembly.GetCallingAssembly() != null)
            {
                // Get the name of the calling assembly
                assemblyName = Assembly.GetCallingAssembly().GetName().Name;

                // Get the build date of the executing assembly
                buildDate = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)
                                .ToString("ddd, dd MMM yy HH:mm tt");
            }

            return $"{assemblyName} | Built: {buildDate}";
        }
    }
}
