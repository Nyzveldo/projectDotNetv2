<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="MessageSection.aspx.cs" Inherits="projectDotNetv2.MessageSection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
        <h1>Meeting List</h1>
        <br />
        <table class="table">
            <tr>
                <th>#</th>
                <th>From</th>
                <th>To</th>
                <th>Message</th>
                <th>Status</th>
            </tr>
            <tr>
                <td>1</td>
                <td>Dr Noor Azah</td>
                <td>Danial Wafiy</td>
                <td>Please Bring Note</td>
                <td><span class="label label-danger">Unread</span></td>
            </tr>
        </table>
    </div>
</asp:Content>
