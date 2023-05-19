<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PrjJogodeDados.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="CSS/styles.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="div1">
                <asp:Image ID="Image1" runat="server" Height="150px" Width="150px" BorderColor="Black" BorderWidth="2px" />
                <asp:Image ID="Image2" runat="server" Height="150px" Width="150px" BorderColor="Black" BorderWidth="2px" />
                <br />
                <br />
                <asp:Button class="btn" ID="Button1" runat="server" Text="Sortear" OnClick="Button1_Click" /> <br />
                <asp:Label class="lbl" ID="Label1" runat="server" Text="Empates: "></asp:Label> 
                <asp:Label class="valorEmpate" ID="lblEmpate" runat="server" Text="0 "></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
