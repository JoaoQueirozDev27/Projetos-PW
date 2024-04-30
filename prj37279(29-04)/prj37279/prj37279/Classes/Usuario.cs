using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public class Usuario: Banco
{
    #region Propridades

        #region Privativas
            private string  _nome;
            private string _login;
            private string _senha;
            public string endereco { get; set; }
    #endregion

        #region Nome
    public string Nome
        {
            get { return _nome; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("O nome não pode estar vazio");
                else
                    _nome = value; 
            }
        }
        #endregion

        #region Login
        public string Login
        {
            get { return _login; }
            set {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("O login não pode estar vazio");
                else
                    _login = value; 
            }
        }
        #endregion

        #region Senha
            public string Senha
            {
                get { return _senha; }
                set {
                    if (String.IsNullOrEmpty(value))
                        throw new Exception("A senha não pode estar vazia");
                    else
                        _senha = value; 
                }
            }
    #endregion

    #endregion

    #region Métodos

        #region Logar
            public string Logar(){
                MySqlDataReader dados =  Consultar($"select * from usuario where nm_login= '{Login}'");
                if (dados.Read())
                {
                    if (this.Senha == dados.GetString("nm_senha"))
                            throw new Exception("Login realizado com sucesso");
                    else
                        throw new Exception("Senha incorreta");
                }
                else
                    throw new Exception("Login incorreto");
            }

            //public void Logar(string login, string senha){
            //    MySqlDataReader dados = Consultar($"select * from usuario where nm_login= '{login}'");
            //    if (dados.Read())
            //    {
            //        if (senha == dados.GetString("nm_senha"))
            //            throw new Exception("Login realizado com sucesso");
            //        else
            //            throw new Exception("Senha incorreta");
            //    }
            //    else
            //        throw new Exception("Login incorreto");
            //}

            //public void Logar(string nome, string login, string senha)
            //{
            //    MySqlDataReader dados = Consultar($"select * from usuario where nm_login= '{login}'");
            //    if (dados.Read())
            //    {
            //        if (senha == dados.GetString("nm_senha"))
            //            if(nome == dados.GetString("nm_usuario"))
            //                throw new Exception("Login realizado com sucesso");
            //            else
            //                throw new Exception("Nome incorreto");
            //        else
            //            throw new Exception("Senha incorreta");
            //    }
            //    else
            //        throw new Exception("Login incorreto");
            //}
    #endregion

    #region Deslogar
    public void Deslogar(){}
        #endregion

        #region AlterarSenha
            public void AlterarSenha(){}
        #endregion

        #region RecuperarSenha
            public string RecuperarSenha(){return "Senha";}
        #endregion

    #endregion

    #region Contrutores
        public Usuario()
        {
        }

        public Usuario(string login, string senha)
        {
            this.Login = login;
            this.Senha = senha;
        }
        public Usuario(string nome,string login , string senha)
        {
            this.Login = login;
            this.Nome = nome;
            this.Senha= senha;
        }
    #endregion
}