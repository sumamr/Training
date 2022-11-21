<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchserviceprovider.aspx.cs" Inherits="ServiceProviderFprm.searchserviceprovider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Searchserviceprovider</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 40px;
        }
        .auto-style3 {
            height: 37px;
        }
        .auto-style4 {
            height: 40px;
            width: 104px;
        }
        .auto-style5 {
            height: 40px;
            width: 172px;
        }
        .auto-style6 {
            height: 40px;
            width: 210px;
        }
        .auto-style7 {
            margin-left: 0px;
            margin-bottom: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="4" style="background-color: #FFFFFF; font-size: x-large;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Search Service Provider&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4" style="background-color: #FFFFFF">
                        <asp:Label ID="Label1" runat="server" BackColor="#FFFF66" Font-Size="Large" Text="Search By"></asp:Label>
                    </td>
                    <td class="auto-style5" style="background-color: #FFFFFF">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>Search By Service Type</asp:ListItem>
                            <asp:ListItem>Search By Location</asp:ListItem>
                            <asp:ListItem>All</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6" style="background-color: #FFFFFF">
                        <asp:TextBox ID="TextBox2" runat="server" BackColor="#CC3399" Font-Size="Large" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style2" style="background-color: #FFFFFF">
                        <asp:Button ID="Button1" runat="server" BackColor="#99CCFF" OnClick="Button1_Click" Text="Go -&gt;" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2" style="background-color: #FFFFFF">&nbsp;</td>
                    <td class="auto-style3" colspan="2" style="background-color: #FFFFFF">
                        <asp:Button ID="Button2" runat="server" BackColor="#FF9966" OnClick="Button2_Click" Text="Back" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2" style="background-color: #FFFFFF">&nbsp;</td>
                    <td class="auto-style3" colspan="2" style="background-color: #FFFFFF">
                        <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" CssClass="auto-style7" ForeColor="Black" GridLines="None" Height="203px" Width="280px">
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
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
