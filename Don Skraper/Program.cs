using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
namespace Don_Skraper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static string name = ">>> root@user : ";
        static string args = "";

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           // File.WriteLine(@"C:\Users\juanv\source\repos\Don Skraper\Don Skraper\Records.txt", "Hola Mundo");
            
        }
    }
}
