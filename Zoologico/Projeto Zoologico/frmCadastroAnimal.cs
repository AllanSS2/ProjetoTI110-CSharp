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

        public frmCadastroAnimal(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            habilitarCamposAlterar();
            carregaAnimal(nome);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        //limpar
        public void limpar()
        {
            txtCodigo.Clear();
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

            btnNovo.Enabled = true;
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

        //habilitar campos alterar
        public void habilitarCamposAlterar()
        {
            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            txtTipo.Enabled = true;

            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
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
                MessageBox.Show("Favor preencher os campos!!","Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txtNome.Focus();
            }
            else
            {
                if (cadastrarAnimal() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpar();
                    desabilitarCampos();
                    
                    
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!","Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        //carrega animal
        public void carregaAnimal(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbAnimais where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            txtTipo.Text = DR.GetString(2);
            txtIdade.Text = DR.GetString(3);


            Conexao.fecharConexao();
        }


        //alterar Animal
        public int alterarAnimal(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbAnimais set nome = @nome, tipo = @tipo, idade = @idade  where codigo = @codigo;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
            comm.Parameters.Add("@tipo", MySqlDbType.VarChar, 50).Value = txtTipo.Text;
            comm.Parameters.Add("@idade", MySqlDbType.VarChar, 100).Value = txtIdade.Text;
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarAnimal(Convert.ToInt32(txtCodigo.Text))==1)
            {
                MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpar();
                desabilitarCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limpar();
            }
            
        }


        //Excluir animal
        public int excluirAnimal(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbAnimais where codigo = @codigo;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codigo", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Mensagem do sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.OK)
            {
                if (excluirAnimal(Convert.ToInt32(txtCodigo.Text)) == 1)
                {
                    MessageBox.Show("Excluído com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    limpar();
                }
                else
                {
                    MessageBox.Show("Falha ao excluír!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                
                
            }
        }
    }

   
}



