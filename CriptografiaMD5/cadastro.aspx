<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="CriptografiaMD5.cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Criptografia com MD5<br />
        ......................................<br />
        String para Encriptar:</div>
        <asp:TextBox ID="txtParaEncriptar" runat="server" Width="235px"></asp:TextBox>
        <br />
        Resultado:<br />
        <asp:TextBox ID="txtResultadoEncriptar" runat="server" BackColor="#99FF99" Width="232px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCriptografar" runat="server"  Text="Criptografar" Width="124px" OnClick="btnCriptografar_Click" />
        <br />
        <br />
        String Criptografada<br />
        <asp:TextBox ID="txtParaDesEncriptar" runat="server" Width="231px"></asp:TextBox>
        <br />
        Resultado:<br />
        <asp:TextBox ID="txtResultadoDesEncriptar" runat="server" BackColor="#99FF99" Width="230px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDescriptar" runat="server" Text="Descriptografar" Width="124px" OnClick="btnDescriptar_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnCripto" runat="server" OnClick="btnCripto_Click" Text="Criptografar web config" Width="162px" />
        <br />
        <br />
        <asp:Button ID="btnDescripto" runat="server" OnClick="btnDescripto_Click" Text="Descriptografar web config" Width="161px" />
    </form>
</body>
</html>
