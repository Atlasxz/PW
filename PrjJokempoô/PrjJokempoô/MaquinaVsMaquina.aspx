<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaquinaVsMaquina.aspx.cs" Inherits="PrjJokempoô.MaquinaVsMaquina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/styles.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="containerEvE">
            <div class="textEVE">
                <asp:Label ID="lblTitulo" runat="server" Text="Máquina vs Máquina"></asp:Label>
            </div>
            <asp:Label class="pont" ID="Label3" runat="server" Text="Pontuação Maquina 1: "></asp:Label>
            <asp:Label class="pont" ID="placar1" runat="server" Text="0"></asp:Label><br />

            <asp:Label class="pont" ID="Label4" runat="server" Text="Pontuação Maquina 2: "></asp:Label>
            <asp:Label class="pont" ID="placar2" runat="server" Text="0"></asp:Label>
            <div class="sorteio">
                <asp:Image class="Imagens" ID="Image1" runat="server" />
                <asp:Image class="Imagens" ID="Image2" runat="server" />
                <br />
            </div>
            <div class="btn">

                <asp:Button ID="btnSorteio" runat="server" Text="Allonz-y" OnClick="Button1_Click" />
            </div>

            


        </div>
    </form>
</body>
</html>
