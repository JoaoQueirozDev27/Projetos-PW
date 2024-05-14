<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editar.aspx.cs" Inherits="ProjetoSPs.editar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Produtos</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Material+Symbols+Outlined:opsz,wght,FILL,GRAD@24,400,0,0" />
    <link rel="stylesheet" href="css/estilo.css">   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <main>
                <h1>Editar Produto</h1>

                <section class="areaFormulario">
                    <p>
                        <label for="txtCodigo">Código:</label>
                        <asp:TextBox ID="txtCodigo" runat="server" required disabled></asp:TextBox>
                    </p>
                    <p>
                        <label for="txtNome">Nome:</label>
                        <asp:TextBox ID="txtNome" runat="server" placeholder="Informe Nome do Produto" required autofocus ></asp:TextBox>                        
                    </p>
                    <p>
                        <label for="txtPreco">Preço:</label>
                        <asp:TextBox ID="txtPreco" runat="server" placeholder="Informe valor unitário" required ></asp:TextBox>                       
                    </p>
                    <asp:Button ID="btnSalvar" runat="server" CssClass="botao" Text="Salvar" OnClick="btnSalvar_Click" />

                </section>

                <div class="rodape">
                    <a href="index.aspx" class="botao">
                        <span class="material-symbols-outlined">arrow_back</span> Voltar
                    </a>
                    <h2 class="aviso erro">
                        <asp:Literal ID="litaviso" runat="server"></asp:Literal></h2>
                </div>

            </main>
        </div>
    </form>
</body>
</html>
