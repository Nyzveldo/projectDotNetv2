<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="projectDotNetv2.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>

    <link href ="Style.css" rel="stylesheet" />

    <style>
        @import url('https://fonts.googleapis.com/family=Bitter|Crete+Round|Pacifico');
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <section>
           <div class="container">
               <div class="inner1">
                   <span>Sign in with Social Network</span><br />
                   <br />
                   <a href="#" class="fb">Log in with Facebook</a>
                   <br />
                   <a href="#" class="gl">Log in with Google+</a>
                   <br />
               </div>
               <div class="inner2">
                   <h3>Sign Up</h3>

                   <asp:TextBox ID="txturname" placeholder="Username" runat="server"></asp:TextBox>
                   <asp:TextBox ID="txtemail" placeholder="E-mail" runat="server"></asp:TextBox>
                   <asp:TextBox ID="txtpasswd" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                   <asp:TextBox ID="txtcops" placeholder="Retype Password" TextMode="Password" runat="server"></asp:TextBox>

                   <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Sign Me Up" />
               </div>
           </div>
       </section>
    </form>
</body>
</html>
