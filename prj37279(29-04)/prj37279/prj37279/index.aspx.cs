using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoTeste
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Usuario UsuarioVazio = new Usuario();
            //Usuario UsuarioLoginSenha = new Usuario("JoaozinhoDoGrau22","Frajola123");
            //Usuario UsuarioNomeLoginSenha= new Usuario("Joao","JoaozinhoDoGrau22","Frajola123");
            //UsuarioVazio.Logar("JoaozinhoDoGrau22", "Frajola123");
            //UsuarioLoginSenha.Logar();
            //UsuarioNomeLoginSenha.Logar();
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            string resposta = "";
            try
            {
                Usuario UsuarioLoginSenha = new Usuario(txtLogin.Text, txtSenha.Text);
                resposta = UsuarioLoginSenha.Logar();      
            }
            catch(Exception erro)
            {
                resposta = erro.Message;
            }
            
            LitResposta.Text = resposta;
        }
    }
}