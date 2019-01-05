<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="meeting-status-lect.aspx.cs" Inherits="projectDotNetv2.MeetingStatus_lect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
        <h1>Meeting List</h1>
        <br />
        <table class="table">
            <tr>
                <th>#</th>
                <th>Student</th>
                <th>Date</th>
                <th>Time</th>
                <th>Status</th>
                <th>Action</th>
            </tr>
            <tr>
                <td>1</td>
                <td>Danial Wafiy</td>
                <td>23/11/2019</td>
                <td>3.12PM</td>
                <td><span class="label label-success">Confirmed</span></td>
                <td><a style="text-decoration:none;cursor:pointer" href="message.aspx"><span class="label label-primary">Message</span></a></td>
            </tr>
        </table>
    </div>
</asp:Content>
