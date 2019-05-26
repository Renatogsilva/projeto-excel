using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao
{
    public partial class Home : Form
    {
        DateTime dataHora;

        public Home()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataHora = DateTime.Now;
            lblDataHora.Text = dataHora.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportacao_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.ShowDialog();
        }
    }
}
