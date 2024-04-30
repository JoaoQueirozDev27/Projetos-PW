<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ProjetoTeste.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <label for="txtLogin">Login:</label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
        <label for="txtSenha">Senha:</label>
        <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <asp:Button ID="btnLogar" runat="server" OnClick="btnLogar_Click" Text="Logar" />
        <p><asp:Literal ID="LitResposta" runat="server"></asp:Literal></p>
    </form>
</body>
</html>
