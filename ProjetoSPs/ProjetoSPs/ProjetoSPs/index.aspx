<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProjetoSPs.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
                <p>
                    <a href="novo.aspx" class="botao">
                        <span class="material-symbols-outlined">add_box</span> Novo Produto
                    </a>
                </p>
        
                <h1>Produtos</h1>
                <asp:Panel ID="PnlAviso" runat="server" Visible="false">
                    <h2 class="aviso">Nenhum produto cadastrado</h2>
                </asp:Panel>
        
                <asp:Panel ID="PnlTabela" runat="server" Visible="false">

                   <table id="tabela">
                        <thead>
                            <tr>
                                <th class="colunaCodigo">Código</th>
                                <th class="colunaNome">Nome</th>
                                <th class="colunaPreco">Preço</th>
                                <th class="colunaAcoes"></th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Literal ID="LitLinhaTabela" runat="server"></asp:Literal>
                        </tbody>
                   </table>
                </asp:Panel>
            </main>
        </div>
    </form>
</body>
</html>
