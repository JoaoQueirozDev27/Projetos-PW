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
    public partial class index : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

            string LinhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=projeto_produtos";
            bool TemProduto = false;
            MySqlConnection conexaoBanco = new MySqlConnection(LinhaConexao);
            try
            {
                conexaoBanco.Open();
             
                MySqlCommand ComandoSQL = new MySqlCommand("ListarProdutos", conexaoBanco);
                ComandoSQL.CommandType = CommandType.StoredProcedure;
                MySqlDataReader dados = ComandoSQL.ExecuteReader();
                while (dados.Read()) {
                    LitLinhaTabela.Text += $@"
                            <tr>
                                <td>{dados[0]}</td>
                                <td>{dados[1]}</td>
                                <td>{dados[2]}</td>
                                <td class='acoes'>
                                    <a href='editar.aspx?cd={dados[0]}'><span class='material-symbols-outlined'>edit</span></a>
                                    <a href='deletar.aspx?cd={dados[0]}'><span class='material-symbols-outlined'>delete</span></a>
                                </td>
                            </tr>";
                    TemProduto = true;
                }
                
                if(dados == null)
                {
                    if (!dados.IsClosed)
                    {
                        dados.Close();
                    }
                }
                conexaoBanco.Close();
            }
            catch {
                LitLinhaTabela.Text = "Não foi possível se conectar ao servidor";
            }

            if(TemProduto){
                PnlTabela.Visible= true;
                PnlAviso.Visible = false;
            }
            else
            {
                PnlTabela.Visible = false;
                PnlAviso.Visible= true;
            }
        }
    }
}