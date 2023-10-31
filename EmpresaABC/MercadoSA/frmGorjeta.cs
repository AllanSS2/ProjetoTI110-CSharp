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

namespace MercadoSA
{
    public partial class frmGorjeta : Form
    {
        public frmGorjeta()
        {
            InitializeComponent();
            pesquisarNome();
            carregaCodigoConta();
        }

        //pesquisar por nome
        public void pesquisarNome()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();


            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            cbbFuncionarios.Items.Clear();
            while (DR.Read())
            {
                cbbFuncionarios.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtValorConta.Text.Equals("") || cbbQualidade.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor preencher os campos!!!", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Double valor = Convert.ToDouble(txtValorConta.Text);

                if (cbbQualidade.SelectedIndex == 0)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.1);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.1));
                }
                if (cbbQualidade.SelectedIndex == 1)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.08);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.08));
                }
                if (cbbQualidade.SelectedIndex == 2)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.05);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.05));
                }
                if (cbbQualidade.SelectedIndex == 3)
                {
                    txtValorGorjeta.Text = Convert.ToString(valor * 0.02);
                    txtValorTotal.Text = Convert.ToString(valor + (valor * 0.02));
                }
            }
        }

        //carrega codigo
        public void carregaCodigo(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codFunc from tbFuncionarios where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));


            Conexao.fecharConexao();

        }

        private void cbbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaCodigo(cbbFuncionarios.Text);
        }

        //Confirmar
        public int confirmar()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbConta(avaliacao, valorConta, valorGorjeta, valorTotal, codFunc) values(@qualidade, @valorConta, @valorGorjeta, @valorTotal, @Codigo);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Add("@qualidade", MySqlDbType.VarChar, 100).Value = cbbQualidade.Text;
            comm.Parameters.Add("@valorConta", MySqlDbType.Decimal, 9).Value = txtValorConta.Text;
            comm.Parameters.Add("@valorGorjeta", MySqlDbType.Decimal, 9).Value = txtValorGorjeta.Text;
            comm.Parameters.Add("@valorTotal", MySqlDbType.Decimal, 9).Value = txtValorTotal.Text;
            comm.Parameters.Add("@Codigo", MySqlDbType.VarChar, 100).Value = txtCodigo.Text;


            comm.Connection = Conexao.obterConexao();

            int res = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return res;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals("") || txtValorGorjeta.Text.Equals("") || txtValorTotal.Text.Equals("") || txtValorConta.Text.Equals("") || cbbQualidade.SelectedIndex.Equals(-1) || cbbFuncionarios.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor preencher os campos!!!", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                if (confirmar() == 1)
                {
                    MessageBox.Show("Confirmado com sucesso.", "mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Erro ao confirmar", "Menssagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        //carrega codigo da conta
        public void carregaCodigoConta()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codConta+1 from tbConta order by codConta desc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigoConta.Text = Convert.ToString(DR.GetInt32(0));


            Conexao.fecharConexao();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorConta.Clear();
            txtValorGorjeta.Clear();
            txtValorTotal.Clear();
            cbbFuncionarios.SelectedIndex = -1;
            cbbQualidade.SelectedIndex = -1;
            txtCodigo.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuGorjeta abrir = new frmMenuGorjeta();
            abrir.Show();
            this.Hide();
        }
    }
}
