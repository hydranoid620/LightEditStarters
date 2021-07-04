using System;
using System.Diagnostics;
using System.IO;
using IWshRuntimeLibrary;
using Microsoft.Extensions.Configuration;
using File = System.IO.File;

namespace Rider
{
    static class RiderStarter
    {
        static void Main(string[] args)
        {
            //Get configs from appsettings.json
            var config = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
            ProcessStartInfo processStartInfo = config.GetSection(nameof(ProcessStartInfo)).Get<ProcessStartInfo>();

            if (!File.Exists(processStartInfo.FileName))
            {
                Console.WriteLine("\"FileName\" property in appsettings.json is invalid. Set this to the location of CLion.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(1);
            }

            //If the user entered a shortcut path, resolve it first
            if (Path.GetExtension(processStartInfo.FileName) == ".lnk")
            {
                WshShell shell = new();
                processStartInfo.FileName = shell.CreateShortcut(processStartInfo.FileName).TargetPath;
            }

            processStartInfo.Arguments = $"-e \"{args[0]}\"";

            Process process = new() {StartInfo = processStartInfo};
            process.Start();
        }
    }
}