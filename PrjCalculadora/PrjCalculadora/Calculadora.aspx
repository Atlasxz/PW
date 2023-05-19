<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="PrjCalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            <asp:Label ID="Label1" runat="server" Text="Digite o primeiro valor: "></asp:Label> <br />
            <asp:TextBox ID="txtVal1" runat="server"></asp:TextBox><br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Digite o segundo valor: "></asp:Label> <br />
            <asp:TextBox ID="txtVal2" runat="server"></asp:TextBox> <br />
            <br />
            <asp:Button ID="btnSomar" runat="server" Text="+ " OnClick="btnSomar_Click" />
            <asp:Button ID="btnSub"  runat="server" Text="- " OnClick="btnSub_Click" style="height: 26px" />
            <asp:Button ID="btnVezes"  runat="server" Text="x " OnClick="btnVezes_Click" style="width: 25px" />

            <asp:Button ID="btnDiv"  runat="server" Text="/ " OnClick="btnDiv_Click" />
            <br />
            <asp:Button ID="btnSeno"  runat="server" Text="Seno " OnClick="btnSeno_Click" />


            <br />
            <br />
            <asp:Label Text="Total: " runat="server" /><br />
            <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox> <br />


        </div>
    </form>
</body>
</html>
