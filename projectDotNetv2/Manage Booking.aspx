<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manage Booking.aspx.cs" Inherits="projectDotNetv2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
            <asp:BoundField DataField="LecturerName" HeaderText="Lecturer" />
            <asp:BoundField DataField="DateTime" HeaderText="Date and Time" />
            <asp:BoundField DataField="Description" HeaderText="Description" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:TemplateField>
                       <ItemTemplate>
                           <asp:LinkButton ID="linkaccept" runat="server" CommandArgument="<% Accept ('MeetingID' %>"> Accept</asp:LinkButton>
                           <asp:LinkButton ID="LinkDecline" runat="server" CommandArgument="<% Decline('MeetingID' %>"> Decline</asp:LinkButton>
                       </ItemTemplate>

                    </asp:TemplateField>

                </Columns>



            </asp:GridView>
            


            <asp:Panel ID="Panel1" runat="server" > </asp:Panel>
            
        </div>
    </form>
</body>
</html>
