using System;
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
    public partial class frmCadastroUsuario : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCadastroUsuario()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmCadastroUsuario(string nome)
        {
            desabilitarCampos();
            txtUsuario.Text = nome;
            carregaUsuarios(nome);
        }

        //carrega o código do usuário novo
        public void carregaCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codUsu+1 from tbUsuarios order by codUsu desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));

            Conexao.fecharConexao();
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        //Cadastro de usuario
        public int cadastrarUsuario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(usuario,senha,codFunc)values(@usuario,@senha,@codFunc);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario",MySqlDbType.VarChar,30).Value = txtUsuario.Text;
            comm.Parameters.Add("@senha",MySqlDbType.VarChar,10).Value = txtSenha.Text;
            comm.Parameters.Add("@codFunc",MySqlDbType.Int32).Value = codFunc;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtRepetirSenha.Text))
            {
                if(cadastrarUsuario(Convert.ToInt32(txtCodFunc.Text)) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);


                    desabilitarCampos();
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                
            }
            else
            {
                MessageBox.Show("Senha não confere!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                txtSenha.Clear();
                txtRepetirSenha.Clear();
                txtSenha.Focus();
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }


        //Carrega funcionarios
        public void carregaFuncionarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            lstFuncSemUsu.Items.Clear();

            while (DR.Read())
            {
                lstFuncSemUsu.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }

        //Carrega funcionario sem usuario
        public void carregaCodigoFuncionarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodFunc.Text = Convert.ToString(DR.GetString(0));

            Conexao.fecharConexao();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            carregaCodigo();
            carregaFuncionarios();
        }



        //carrega usuarios
        public void carregaUsuarios(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select usu.usuario, usu.senha, func.codFunc from tbFuncionarios as func inner join tbUsuarios as usu on func.codFunc = usu.codFunc where func.nome = @nome;";
            comm.CommandType = CommandType.Text;





            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conexao.obterConexao();



            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            try
            {
                txtUsuario.Text = DR.GetString(0);
                txtSenha.Text = DR.GetString(1);



                txtCodFunc.Text = DR.GetString(2).ToString();
                txtCodigo.Text = DR.GetString(2).ToString();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Funcionário não possui", "Messagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);



                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
                txtCodFunc.Clear();
                txtRepetirSenha.Clear();

                //Carrega o codigo do funcionario sem usuario
                carregaCodigoFuncionarios(lstFuncSemUsu.SelectedItem.ToString());
                
            }
        }

        private void lstFuncSemUsu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = lstFuncSemUsu.SelectedItem.ToString();

            carregaUsuarios(nome);
        }

        //Desabilitar campos
        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;

            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //Desabilitar campos novo
        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtRepetirSenha.Enabled = false;

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
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtRepetirSenha.Enabled = true;



            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            txtUsuario.Focus();
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            txtUsuario.Focus();
        }

        //Limpar campos geral
        public void limparTudo()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
            lstFuncSemUsu.Items.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparTudo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (alterarUsuarios(Convert.ToInt32(txtCodigo.Text))==1)
            {
                MessageBox.Show("Alterado com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        //Alterar usuário
        public int alterarUsuarios(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update into tbUsuarios set usuario = @usuario, senha = @senha where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = txtUsuario.Text;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 10).Value = txtSenha.Text;
            comm.Parameters.Add("@codUsu", MySqlDbType.VarChar, 10).Value = codigo;

            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();
        }
    }
}
