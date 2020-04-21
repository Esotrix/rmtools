using System.Drawing;
using System.Windows.Forms;
namespace _s_AINT
{
    class cScreen
    {
        public static void csScreen()
        {
            Bitmap btm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics.FromImage(btm).CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            string screenpath = Program.workdir + "\\image.jpeg";
            btm.Save(screenpath);
        }
    }
}
