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
    public partial class frmPesquisarGorjeta : Form
    {
        public frmPesquisarGorjeta()
        {
            InitializeComponent();
            pesquisarNome();
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


        //pesquisar por funcionarios
        public void pesquisarFuncionario(int codigo)
        {
            double total = 0;
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select valorGorjeta, avaliacao, dataConta from tbconta where codFunc = @codFunc and dataConta between @DataInicio and @DataFim;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;
            comm.Parameters.Add("@DataInicio", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataInicio.Text);
            comm.Parameters.Add("@DataFim", MySqlDbType.Date).Value = Convert.ToDateTime(dtpDataFim.Text);


            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbPesquisa.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisa.Items.Add("R$" + DR.GetString(0) + " | " + DR.GetString(1)+ " | " + DR.GetString(2));
                total = total + Convert.ToDouble(DR.GetString(0));
            }
            txtTotal.Text = Convert.ToString(total);

            Conexao.fecharConexao();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarFuncionario(Convert.ToInt32(txtCodfunc.Text));
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

            txtCodfunc.Text = Convert.ToString(DR.GetInt32(0));


            Conexao.fecharConexao();

        }

        private void cbbFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaCodigo(cbbFuncionarios.Text);
        }
    }


}
