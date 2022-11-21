<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListOfServices.aspx.cs" Inherits="LocalBusiness.ListOfServices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List Of Services</title>
    <style>
        .header {
            float: right;
            width: 100%;
            background-color: black;
            height: 50px;
            color: white;
            font-size: 20px;
        }

        footer {
            position: fixed;
            bottom: 0;
            width: 100%;
            padding: 3px;
            text-align: center;
            background-color: dimgrey;
            font-size: 20px;
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 36px;
        }

        .auto-style3 {
            height: 37px;
        }

        .auto-style4 {
            height: 46px;
        }

        .auto-style5 {
            height: 40px;
        }

        .auto-style6 {
            height: 36px;
            width: 311px;
        }

        .auto-style7 {
            height: 37px;
            width: 311px;
        }

        .auto-style8 {
            height: 46px;
            width: 311px;
        }

        .auto-style9 {
            height: 40px;
            width: 311px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
            
                <div class="header">
                    <a href="#myprofile">My Profile</a>
                    &emsp;<a href="#myservicelist">My Service List</a>
                    &emsp;<a href="#logout">Log Out</a>
                </div>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style6">
                            <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </td>
                        <td class="auto-style2">
                            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Text="ADD" />
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Name :"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:TextBox ID="namtext" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style8">
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Description :"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:TextBox ID="destext" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            &nbsp;</td>
                        <td class="auto-style2"></td>
                    </tr>
                    <tr>
                        <td class="auto-style9"></td>
                        <td class="auto-style5"></td>
                    </tr>
                </table>
            
    </form>
    <footer>
        <p>List Of  Services for particular ServiceProvider</p>
    </footer>
</body>
</html>
