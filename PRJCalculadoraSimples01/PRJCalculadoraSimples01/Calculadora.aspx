<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="PRJCalculadoraSimples01.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/estilos.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="div1">
            <div class="container">

                <asp:Label ID="Label1" runat="server" Text="Digite o 1º valor"></asp:Label><br />
                <asp:TextBox ID="txtVal1" runat="server" Width="171px"></asp:TextBox><br /><br />

                <asp:Label ID="Label2" runat="server" Text="Digite o 2º valor"></asp:Label><br />
                <asp:TextBox ID="txtVal2" runat="server" Width="170px"></asp:TextBox><br /><br />
                

                <br/>

                <asp:Label ID="Label3" runat="server" Text="Valor Total: "></asp:Label><br />
                <asp:Label ID="lblTotal" runat="server" Text=""   ></asp:Label>
                <asp:Label ID="lblMsg" runat="server" Text=""   ></asp:Label>
                <div class="botoes">
                    <asp:Button class="btn" ID="btnSomar" runat="server" Text="+" OnClick="btnSomar_Click" />
                    <asp:Button class="btn" ID="btnSubtrair" runat="server" Text="-" OnClick="btnSubtrair_Click"/>
                    <asp:Button class="btn" ID="btnVezes" runat="server" Text="X" OnClick="btnVezes_Click" />
                    <asp:Button class="btn" ID="btnDivisao" runat="server" Text="/" OnClick="btnDivisao_Click" />
                    <asp:Button class="btn" ID="btnClear" runat="server" Text="CC" OnClick="btnClear_Click" />
                    <asp:Button class="btn" ID="btnPi" runat="server" Text="Pi" OnClick="btnPi_Click" />
                    <asp:Button class="btn" ID="btnSeno" runat="server" Text="Seno" OnClick="btnSeno_Click" />
                <asp:Image ID="Image1" runat="server" ForeColor="White" ImageUrl="~/image/ChikitaBK.jpg" Width="153px" Height="300px" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
