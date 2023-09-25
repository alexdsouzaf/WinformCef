using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCef
{
    /// <summary>
    /// classe apenas para instanciar e exibir o chromium
    /// </summary>
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chrome;
        public Form1()
        {
            InitializeComponent();
        }

        public void IniciarWebBrowser()
        {
            this.chrome = new ChromiumWebBrowser("http://google.com");

            this.Controls.Add(chrome);

            this.chrome.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cef.Shutdown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarWebBrowser();
        }
    }
}
