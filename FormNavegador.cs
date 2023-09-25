using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCef
{
    /// <summary>
    /// Implementação da navegação dentro do winform
    /// </summary>
    public partial class FormNavegador : TitleBarTabs
    {
        public FormNavegador()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);

        }

        /// <summary>
        /// Evento executado dentro do componente para a criação de uma nova aba
        /// </summary>
        /// <returns></returns>
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1 { Text = "Nova tab" }
            };
        }

        private void Inicializar()
        {
            this.Tabs.Add(new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = this.Text
                }
            });
            this.SelectedTabIndex = 0;
            ///Inicia um contexto para as abas
            TitleBarTabsApplicationContext context = new TitleBarTabsApplicationContext();
            context.Start(this);

        }

        protected override void OnLoad(EventArgs e)
        {
            Inicializar();
            base.OnLoad(e);
        }

    }
}
