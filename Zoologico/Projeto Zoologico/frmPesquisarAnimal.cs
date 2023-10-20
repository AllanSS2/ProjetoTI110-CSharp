using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            desabilitarCampos();
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

        //pesquisar por nome
        public void pesquisarNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbAnimais where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbPesquisar.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }

        //pesquisar por código
        public void pesquisarCodigo(int codigo)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "select * from tbAnimais where codigo = @codigo;";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;

                comm.Connection = Conexao.obterConexao();

                MySqlDataReader DR;

                DR = comm.ExecuteReader();
                DR.Read();
                ltbPesquisar.Items.Clear();
                ltbPesquisar.Items.Add(DR.GetString(1));
            }
            catch (Exception)
            {
                MessageBox.Show("Código não existe!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.fecharConexao();

        }

        //pesquisar por tipo
        public void pesquisarTipo(string tipo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbAnimais where tipo like '%" + tipo + "%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 50).Value = tipo;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbPesquisar.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }





        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Favor inserir algo!", "Mensagem do sistema",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdbCodigo.Checked)
                {
                    pesquisarCodigo(Convert.ToInt32(txtDescricao.Text));
                }
                if (rdbNome.Checked)
                {
                    pesquisarNome(txtDescricao.Text);
                }
                if (rdbTipo.Checked)
                {
                    pesquisarTipo(txtDescricao.Text);
                }
            }

        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisar.SelectedItem == null)
            {
                MessageBox.Show("Favor selecionar um item!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nome = ltbPesquisar.SelectedItem.ToString();
                frmCadastroAnimal abrir = new frmCadastroAnimal(nome);
                abrir.Show();
                this.Hide();
            }
        }
    }
}
