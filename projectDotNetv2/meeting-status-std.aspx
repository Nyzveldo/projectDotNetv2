<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="meeting-status-std.aspx.cs" Inherits="projectDotNetv2.MeetingStatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Meeting List</h1>
        <br />
        <table class="table">
            <tr>
                <th>#</th>
                <th>Lecture</th>
                <th>Date</th>
                <th>Time</th>
                <th>Status</th>
            </tr>
            <tr>
                <td>1</td>
                <td>Dr Noor Azah</td>
                <td>23/11/2019</td>
                <td>3.12PM</td>
                <td><span class="label label-success">Confirmed</span></td>
            </tr>
        </table>
    </div>
</asp:Content>
