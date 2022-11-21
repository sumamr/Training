<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="ECommerce.search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 44px;
            width: 228px;
        }
        .auto-style6 {
            margin-left: 30px;
            margin-bottom: 0px;
        }
        .auto-style7 {
            margin-left: 89px;
        }
        .auto-style8 {
            height: 44px;
            width: 132px;
        }
        .auto-style9 {
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Search Form&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:TextBox ID="searchtextbox" runat="server" Width="144px" Font-Size="Large"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" CssClass="auto-style6" Font-Size="Large" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Search By Name</asp:ListItem>
                        <asp:ListItem>Search By Manufacturer</asp:ListItem>
                        <asp:ListItem>All Products</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" Text="Search" Width="149px" CssClass="auto-style7" />
                </td>
            </tr>
            <tr>
                <td class="auto-style9" colspan="3">
                    <asp:Button ID="Button2" runat="server" Font-Size="Large" OnClick="Button2_Click" Text="Back" Width="111px" />
                </td>
            </tr>
        </table>
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" Font-Size="Large" ForeColor="Black" GridLines="None">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
