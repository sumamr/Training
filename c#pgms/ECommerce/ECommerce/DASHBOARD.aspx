<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DASHBOARD.aspx.cs" Inherits="ECommerce.DASHBOARD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DASHBOARD</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 49px;
        }
        .auto-style3 {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="ProductButton1" runat="server" OnClick="ProductButton1_Click" Text="Product" Width="128px" />
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="SearchButton1" runat="server" OnClick="SearchButton1_Click" Text="Search" Width="127px" />
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="LogOutButton1" runat="server" OnClick="LogOutButton1_Click" Text="LogOut" Width="126px" />
                </td>
                <td class="auto-style3"></td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
