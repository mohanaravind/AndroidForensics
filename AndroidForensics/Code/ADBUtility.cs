using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace AndroidForensics.Code
{
    class ADBUtility
    {
        private static String ExeName = @"C:\Program Files (x86)\Android\android-sdk\platform-tools\adb";       

        /// <summary>
        /// Gets/Sets the Executable Path
        /// </summary>
        public static String ExecutablePath
        {
            get { return ADBUtility.ExeName; }
            set { ADBUtility.ExeName = value; }
        }

        /// <summary>
        /// Sends commands through ADB
        /// </summary>
        /// <param name="arguments"></param>
        /// <returns></returns>
        public static String SendMessage(String arguments)
        {
            Int32 exitCode;
            String output;

            try
            {
                // Prepare the process to run
                ProcessStartInfo start = new ProcessStartInfo();
                // Enter in the command line arguments, everything you would enter after the executable name itself
                start.Arguments = arguments;
                // Enter the executable to run, including the complete path
                start.FileName = ExeName;
                // Do you want to show a console window?
                start.WindowStyle = ProcessWindowStyle.Hidden;
                start.CreateNoWindow = true;
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;

                // Run the external process & wait for it to finish
                using (Process proc = Process.Start(start))
                {

                    //Get the output
                    output = proc.StandardOutput.ReadToEnd();

                    //Wait for completion
                    proc.WaitForExit();

                    // Retrieve the app's exit code
                    exitCode = proc.ExitCode;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                output = String.Empty;                
            }

            return output;
        }

        /// <summary>
        /// Pushes the shell command through ADB
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static String SendShellCommands(ADBShellCommand adbShellCommand)
        {
            return SendMessage("shell " + adbShellCommand.ToString());
        }

        /// <summary>
        /// Retrieves the file from device
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="destinationPath"></param>
        /// <returns></returns>
        public static String RetrieveFile(String sourcePath, String destinationPath)
        {
            return SendMessage("pull " + sourcePath + " " + destinationPath); 
        }

    }
}
