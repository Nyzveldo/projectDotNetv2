<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="projectDotNetv2.message" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Message</h1>
        <div class="jumbotron" style="text-align:center">
        <form id="form1" runat="server">
            <h3>Send message to:</h3>
            <asp:TextBox runat="server" Width="70%" style="margin-left:15%;margin-right:15%" ID="msgText" CssClass="form-control"></asp:TextBox>
            <br />
            <asp:Button runat="server" CssClass="btn" ID="send" OnClick="sendMessagge" text="Send"/>
        </form>
        </div>
    </div>
    
</asp:Content>
