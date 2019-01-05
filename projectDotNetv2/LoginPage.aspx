<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="projectDotNetv2.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href ="Style.css" rel="stylesheet" />

    <style type="text/css">

        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style1 {
            width: 85px;
        }
        .auto-style2 {
            width: 317px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <section>
        
        <div class="inner1">
        <div>
            <strong>
            <br />
            <span class="auto-style3">Login</span></strong><br />
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Username:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="308px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Password:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="306px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="131px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
            </div>
      
            </section>
    </form>
</body>
</html>

