using Controle;
using Negocio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Visao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            ObjetoControlle obControlle = new ObjetoControlle();
            RepositorioExcel reposiExcel = new RepositorioExcel();
            RepositorioResultadoObtido reposiResultadoObtido = new RepositorioResultadoObtido();
            if (!string.IsNullOrWhiteSpace(txtLinhaInicialDados.Text))
            {
                int linhaInicial = Convert.ToInt32(txtLinhaInicialDados.Text);

                try
                {
                    obControlle.validaDadosInformados(txtCaminho.Text, cbxColunaTempo.Text, txtIntervalo.Text, cbxPREC.Text, txtNomePlanilha.Text, txtCaminhoSalvamento.Text);
                    List<Resultado> resultadoObtido = reposiExcel.CapturaValorPlanilha(txtCaminho.Text, cbxColunaTempo.Text, txtIntervalo.Text, cbxPREC.Text, txtNomePlanilha.Text, linhaInicial);
                    bloqueaCampos();
                    if (reposiResultadoObtido.GerarPlanilha(resultadoObtido, txtIntervalo.Text, txtCaminhoSalvamento.Text))
                    {
                        MessageBox.Show("Cálculo realizado com sucesso!");
                        desbloqueaCampos();
                        limparCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não foi informado a linha inicial dos dados!");
            }
        }

        private void btnLimparCampos_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFileName = openFileDialog.FileName;
                txtCaminho.Text = strFileName;
                return;
            }
        }

        private void bloqueaCampos()
        {
            txtIntervalo.Enabled = false;
            txtLinhaInicialDados.Enabled = false;
            txtNomePlanilha.Enabled = false;
            cbxPREC.Enabled = false;
            cbxColunaTempo.Enabled = false;
        }

        private void desbloqueaCampos()
        {
            txtIntervalo.Enabled = true;
            txtLinhaInicialDados.Enabled = true;
            txtNomePlanilha.Enabled = true;
            cbxPREC.Enabled = true;
            cbxColunaTempo.Enabled = true;
        }

        private void limparCampos()
        {
            cbxColunaTempo.Text = "";
            txtIntervalo.Text = "";
            cbxPREC.Text = "";
            txtLinhaInicialDados.Text = "";
            txtNomePlanilha.Text = "";
            txtCaminho.Text = "";
            txtCaminhoSalvamento.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFileName = saveFileDialog.FileName;
                txtCaminhoSalvamento.Text = strFileName;
                return;
            }
        }
    }
}
