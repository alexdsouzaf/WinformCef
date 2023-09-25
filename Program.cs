using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCef
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormBase());
            Application.Run(new FormNavegador());

            //FormNavegador container = new FormNavegador();
            //container.Tabs.Add(new TitleBarTab(container)
            //{
            //    Content = new Form1
            //    {
            //        Text = "nova aba"
            //    }
            //});
            //container.SelectedTabIndex = 0;
            //TitleBarTabsApplicationContext context = new TitleBarTabsApplicationContext();
            //context.Start(container);
            //Application.Run(context);
        }
    }
}
