﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace MercadoSA
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public frmFuncionarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            txtNome.Text = nome;
            //habilitar os campos
            habilitarCamposAlterar();
            carregaFuncionario(nome);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        //Criando método de limpar campos

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mskCep.Clear();
            mskCpf.Clear();
            cbbEstado.Items.Clear();
            cbbEstado.Text = "";
            txtNome.Focus();
        }

        //Desabilitar campos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskCep.Enabled = false;
            mskCpf.Enabled = false;
            cbbEstado.Enabled = false;
            cbbEstado.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;

        }
        //Desabilitar campos novo
        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtEmail.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mskCep.Enabled = false;
            mskCpf.Enabled = false;
            cbbEstado.Enabled = false;
            cbbEstado.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();
        }

        //Habilitar campos
        public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtEmail.Enabled = true;
            mskCep.Enabled = true;
            mskCpf.Enabled = true;
            cbbEstado.Enabled = true;
            dtpDNasc.Enabled = true;



            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
        }
        public void habilitarCamposAlterar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtEmail.Enabled = true;
            mskCep.Enabled = true;
            mskCpf.Enabled = true;
            cbbEstado.Enabled = true;
            dtpDNasc.Enabled = true;



            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = false;

            txtNome.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            carregaCodigo();
        }

        //Cadastrando funcionários no banco de dados
        public int cadastrarFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome,email,cpf,dNasc,endereco,cep,numero,bairro,estado,cidade) values(@nome,@email,@cpf,@dNasc,@endereco,@cep,@numero,@bairro,@estado,@cidade);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCpf.Text;
            comm.Parameters.Add("@dNasc", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDNasc.Text);
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCep.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        //carrega codigo
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc+1 from tbFuncionarios order by codFunc desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));


            Conexao.fecharConexao();
        }

        //carregar funcionario
        public void carregaFuncionario(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mskCpf.Text = DR.GetString(3);
            dtpDNasc.Text = DR.GetString(4);
            txtEndereco.Text = DR.GetString(5);
            mskCep.Text = DR.GetString(6);
            txtNumero.Text = DR.GetString(7);
            txtBairro.Text = DR.GetString(8);
            cbbEstado.Text = DR.GetString(9);
            txtCidade.Text = DR.GetString(10);
            


            Conexao.fecharConexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtEndereco.Text.Equals("") || txtNumero.Text.Equals("") || txtCidade.Text.Equals("") || txtBairro.Text.Equals("") || mskCpf.Text.Equals("   .   .   -") || mskCep.Text.Equals("     -") || cbbEstado.Text.Equals(""))
            {
                
                MessageBox.Show("Favor preencher os campos!!");
                txtNome.Focus();
            }
            else
            {
                if (cadastrarFuncionarios() == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!!");
                    desabilitarCamposNovo();
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!!");
                }
                
                
            }

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarFuncionarios(Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                limparCampos();
            }

            
        }

        //alterar funcionarios
        public int alterarFuncionarios(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbFuncionarios set nome = @nome, email = @email, cpf = @cpf, dNasc = @dNasc, endereco = @endereco, cep = @cep, numero = @numero, bairro = @bairro, estado = @estado, cidade = @cidade where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCpf.Text;
            comm.Parameters.Add("@dNasc", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDNasc.Text);
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = txtEndereco.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCep.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = cbbEstado.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente excluir?", "Mensagem do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (resp == DialogResult.OK)
            {
                excluirFuncionarios(Convert.ToInt32(txtCodigo.Text));
                limparCampos();
            }
            else
            {

            }
        }

        //Excluir funcionario
        public void excluirFuncionarios(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionarios where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;

            comm.Connection = Conexao.obterConexao();
            comm.ExecuteNonQuery();

            Conexao.fecharConexao();
        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();

                try
                {
                    WSCorreios.enderecoERP endereco = ws.consultaCEP(mskCep.Text);

                    txtEndereco.Text = endereco.end;
                    txtBairro.Text = endereco.bairro;
                    txtCidade.Text = endereco.cidade;
                    cbbEstado.Text = endereco.uf;

                    txtNumero.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Favor inserir um CEP válido.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    mskCep.Focus();
                    mskCep.Clear();
                }
            }

        }
    }
}
