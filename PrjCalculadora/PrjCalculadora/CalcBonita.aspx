<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcBonita.aspx.cs" Inherits="PrjCalculadora.CalcBonita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        *{
            margin: 0 auto;
        }
        .butao{
            display: flex;
        }
        .button, .operator{
            margin: 5px;
            height: 60px;
            width: 60px
        }
        .operator{
            width: 30px;
            background-color: orange;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="geral">

            <div class="butao">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button class="button" ID="Button1" runat="server" Text="1" OnClick="Button1_Click"  />
                <asp:Button class="button" ID="Button2" runat="server" Text="2" />
                <asp:Button class="button" ID="Button3" runat="server" Text="3" OnClick="Button3_Click"  />
                <asp:Button class="operator" ID="Button11" runat="server" Text="+" />
                    <br />
                <asp:Button class="button" ID="Button4" runat="server" Text="4"  />
                <asp:Button class="button" ID="Button5" runat="server" Text="5"  />
                <asp:Button class="button" ID="Button6" runat="server" Text="6" />
                <asp:Button class="operator" ID="Button10" runat="server" Text="-" />

                    <br />

                <asp:Button class="button" ID="Button7" runat="server" Text="7"  />
                <asp:Button class="button" ID="Button8" runat="server" Text="8"  />
                <asp:Button class="button" ID="Button9" runat="server" Text="9"  />
                <asp:Button class="operator" ID="Button12" runat="server" Text="x" />


            </div>
        </div>
    </form>
</body>
</html>
