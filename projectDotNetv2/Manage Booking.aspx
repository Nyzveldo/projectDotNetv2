<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage Booking.aspx.cs" Inherits="projectDotNetv2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Booking</title>
    <style type="text/css">
        .auto-style1 {
            width: 62px;
            height: 28px;
        }
        .auto-style2 {
            height: 28px;
        }
    </style>
</head>
<body >
    <h3 style="text-align:center">Manage Booking</h3>
    <form id="form1" runat="server" >
        <div >
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" align="center" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowCommand="GridView1_RowCommand">
               
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
            <asp:BoundField DataField="Student" HeaderText="Lecturer" />
            <asp:BoundField DataField="DateTime" HeaderText="Date and Time" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:BoundField DataField="Status" HeaderText="Status" />


                    <asp:TemplateField>
                       <ItemTemplate>
                           <asp:LinkButton ID="linkaccept" runat="server" CommandName="Accept" CommandArgument='<%# Eval("meetingID") %>' > Accept</asp:LinkButton>
                           <asp:LinkButton ID="LinkDecline" runat="server" CommandArgument="<% Decline('MeetingID' %>"> Decline</asp:LinkButton>
                       </ItemTemplate>

                    </asp:TemplateField>

                </Columns>



                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />



            </asp:GridView>
            <br />
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />



            <!--<asp:Panel ID="Panel1" runat="server" > </asp:Panel>-->
            
        </div>
    </form>
</body>
</html>
