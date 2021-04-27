<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JsonASP.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server" Width="376px"></asp:TextBox>
            <br />
            Edad: <asp:TextBox ID="txtEdad" runat="server" TextMode="Number" Width="100px"></asp:TextBox>
            <br />
            Email:
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Width="390px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar persona" />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="86px" Width="441px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnGenerar" runat="server" OnClick="btnGenerar_Click" Text="Generar JSON" />
        </div>
    </form>
</body>
</html>
