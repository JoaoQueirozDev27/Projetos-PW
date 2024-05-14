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
    public partial class deletar : System.Web.UI.Page
    {
        string LinhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=projeto_produtos";
        private string cd = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            cd = Request["cd"];
            if (!Page.IsPostBack)
            {
                MySqlConnection conexaoBanco = new MySqlConnection(LinhaConexao);
                try
                {
                    conexaoBanco.Open();

                    MySqlCommand ComandoSQL = new MySqlCommand("ConsultarProduto", conexaoBanco);
                    ComandoSQL.CommandType = CommandType.StoredProcedure;
                    ComandoSQL.Parameters.AddWithValue("pCodigo", cd);
                    MySqlDataReader dados = ComandoSQL.ExecuteReader();
                    if (dados.Read())
                    {
                        txtCodigo.Text = dados[0].ToString();
                        txtNome.Text = dados[1].ToString();
                        txtPreco.Text = dados[2].ToString();
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

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexaoBanco = new MySqlConnection(LinhaConexao);
            try
            {
                conexaoBanco.Open();

                MySqlCommand ComandoSQL = new MySqlCommand("ExcluirProduto", conexaoBanco);
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                ComandoSQL.Parameters.Clear();
                ComandoSQL.Parameters.AddWithValue("pCodigo", cd);
                ComandoSQL.ExecuteNonQuery();
                conexaoBanco.Close();
                Response.Redirect("index.aspx");
            }
            catch
            {

            }
        }
    }
}