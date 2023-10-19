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
    public partial class frmCadastroAnimal : Form
    {
        public frmCadastroAnimal()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //limpar
        public void limpar()
        {
            txtNome.Clear();
            txtTipo.Clear();
            txtIdade.Clear();
            txtNome.Focus();
        }

         //Desabilitar campos
         public void desabilitarCampos()
        {
            
            txtNome.Enabled = false;
            txtTipo.Enabled = false;
            txtIdade.Enabled = false;

            btnPesquisar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Focus();
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtTipo.Enabled = true;
            txtIdade.Enabled = true;

            btnPesquisar.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            txtNome.Focus();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            carregaCodigo();
        }


        //cadastrar
        public int cadastrarAnimal()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbAnimais(nome, tipo, idade)values(@nome, @tipo, @idade);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 50).Value = txtTipo.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar,100).Value = Convert.ToInt32(txtIdade.Text);
            

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtTipo.Text.Equals("") || txtIdade.Text.Equals(""))
            {
                MessageBox.Show("Favor preencher os campos!!");
                txtNome.Focus();
            }
            else
            {
                if (cadastrarAnimal() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!");
                    limpar();
                    desabilitarCampos();
                    
                    
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!");
                }


            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        //carrega codigo
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codigo+1 from tbAnimais order by codigo desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));


            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarAnimal abrir = new frmPesquisarAnimal();
            abrir.Show();
            this.Hide();
        }
    }

   
}
