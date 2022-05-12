using IGO_font;
using IGO_font.慶陽;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期中專題;

namespace Igo_Font
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new CheckOut());
            //Application.Run(new Live());
            //Application.Run(new Register());
            //Application.Run(new HomePage());
            Application.Run(new Frm_Login());
        }
    }
}
