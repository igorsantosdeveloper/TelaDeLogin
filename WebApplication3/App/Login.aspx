<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link href="CSS/login.css" rel="stylesheet"/>
        <title>Login</title>
    </head>

    <body>
        <div id="container">
        <form id="form1" runat="server">
            <img src="ICON/DOTNET-ICON.png" runat="server"  width="250" height="150" id="logo"/><br></br>        
            <asp:Label CssClass="lblLogin" ID="lblUsuario1" runat="server" Text="USUÁRIO"></asp:Label><br/>
            <asp:TextBox CssClass="txtBoxLogin" ID="txtBoxUsuario" runat="server"></asp:TextBox><br/><br/>
            <asp:Label CssClass="lblLogin" ID="lblSenha" runat="server" Text="SENHA"></asp:Label><br/>
            <asp:TextBox CssClass="txtBoxLogin" ID="txtBoxSenha" runat="server" TextMode="Password"></asp:TextBox><br/><br/>
            <asp:Button CssClass="btnLogin" ID="Button1" runat="server" OnClick="Button1_Click" Text="ENTRAR" /><br/><br/>
            <asp:Label CssClass="lblLoginFalha" ID="lblFalhaAutenticacao" runat="server"></asp:Label><br/>
        </form>
        </div>
    </body>
</html>
