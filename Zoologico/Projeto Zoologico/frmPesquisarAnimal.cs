using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Zoologico
{
    public partial class frmPesquisarAnimal : Form
    {
        public frmPesquisarAnimal()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        //limpa
        public void limpar()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbTipo.Checked = false;
            txtDescricao.Enabled = false;
            ltbPesquisar.Items.Clear();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }


        //desabilitar
        public void desabilitarCampos()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            txtDescricao.Enabled = false;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            rdbTipo.Checked = false;
        }

        //Habilitar campos
        public void habilitarCampos()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void rdbTipo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCadastroAnimal abrir = new frmCadastroAnimal();
            abrir.Show();
            this.Close();
        }
    }
}
