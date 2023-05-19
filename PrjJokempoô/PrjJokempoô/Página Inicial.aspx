<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Página Inicial.aspx.cs" Inherits="PrjJokempoô.Página_Inicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="CSS/styles.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Selecione o tipo de Jogo: "></asp:Label>
        </div>
        <asp:Image class="imginicial" ID="Image1" runat="server" ImageUrl="~/images/PVE.png" /> <br />
        <asp:Button ID="btnPVE" runat="server" Text="PvE" OnClick="btnPVE_Click"/> <br />
        <br />
        <asp:Image class="imginicial" ID="Image2" runat="server" ImageUrl="~/images/robo.png" /><br />
        <asp:Button ID="btnEvE" runat="server" Text="EvE" OnClick="btnEvE_Click" />

    </form>
</body>
</html>
