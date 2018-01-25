using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace qq
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new Qq());

            using (var frm = new Qq())
            {
                frm.HotKeyId = 0x0312;
                frm.FormClosed += (s, e) =>
                {
                    HotKeys.Unregister(frm, frm.HotKeyId);
                };

                HotKeys.Register(frm, 0x31, Modifiers.ALT, Keys.PrintScreen);
                HotKeys.Register(frm, 0x32, Modifiers.SHIFT, Keys.PrintScreen);
                HotKeys.Register(frm, 0x33, Modifiers.CONTROL, Keys.PrintScreen);
                HotKeys.Register(frm, 0x34, Modifiers.CONTROL, Keys.PrintScreen | Keys.D1);
                HotKeys.Register(frm, 0x35, Modifiers.CONTROL | Modifiers.SHIFT, Keys.PrintScreen);
                HotKeys.Register(frm, 0x36, Modifiers.CONTROL, Keys.Scroll);

                Application.Run(frm);
            }

            return 0; // OK
        }

    }
}



