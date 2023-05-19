<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JogodaForca.aspx.cs" Inherits="PrjJogodaForca.JogodaForca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="CSS/StyleSheet1.css" /> 
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
           <div class="imagens">
                   <asp:Image class="img" ID="Image1" runat="server" />
                   <asp:Image class="img" ID="Image2" runat="server" />
                   <asp:Image class="img" ID="Image3" runat="server" />
               <br />
           </div>
            <div class="text">
                <asp:TextBox class="text txt" ID="txtForca" runat="server" Height="43px" Width="391px"></asp:TextBox>
                <asp:Button class="text btn" ID="btnJogar" runat="server" Height="44px" Text="Jogar" Width="200px" OnClick="btnJogar_Click" />
                               <asp:Button class="text btn" ID="btnReset" runat="server" Height="44px" Text="Reset" Width="200px" OnClick="btnReset_Click"  />
                
                <br />
            </div>
            <br />
            <div class="contErros">

                <asp:Label class="erro" ID="lbl1" runat="server" Text=""></asp:Label>
                <asp:Label class="erro" ID="lbl2" runat="server" Text=""></asp:Label>
                <asp:Label class="erro" ID="lbl3" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
