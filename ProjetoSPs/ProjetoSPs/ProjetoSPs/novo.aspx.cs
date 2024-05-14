using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoSPs
{
    public partial class novo : System.Web.UI.Page
    {
        string LinhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=projeto_produtos";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            MySqlConnection conexaoBanco = new MySqlConnection(LinhaConexao);

            try
            {
                conexaoBanco.Open();

                MySqlCommand ComandoSQL = new MySqlCommand("MaiorCodigo", conexaoBanco);
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dados = ComandoSQL.ExecuteReader();
                if(dados.Read())
                {
                    txtCodigo.Text = dados[0].ToString();
                }

                if (dados == null)
                {
                    if (!dados.IsClosed)
                    {
                        dados.Close();
                    }
                }
                conexaoBanco.Close();
            }
            catch
            {

            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoBanco = new MySqlConnection(LinhaConexao);
            try
            {
                conexaoBanco.Open();

                MySqlCommand ComandoSQL = new MySqlCommand("AdicionarProduto", conexaoBanco);
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.Parameters.Clear();
                ComandoSQL.Parameters.AddWithValue("pCodigo", int.Parse(txtCodigo.Text));
                ComandoSQL.Parameters.AddWithValue("pNome", txtNome.Text);
                ComandoSQL.Parameters.AddWithValue("pValor", decimal.Parse(txtPreco.Text));
                MySqlDataReader dados = ComandoSQL.ExecuteReader();
                if (dados.Read())
                {
                    txtCodigo.Text = dados[0].ToString();
                }

                if (dados == null)
                {
                    if (!dados.IsClosed)
                    {
                        dados.Close();
                    }
                }
                conexaoBanco.Close();
            }
            catch
            {

            }
        }
    }
}