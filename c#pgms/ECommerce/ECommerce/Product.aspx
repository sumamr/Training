<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="ECommerce.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 35px;
        }
        .auto-style3 {
            height: 34px;
        }
        .auto-style4 {
            height: 33px;
        }
        .auto-style5 {
            height: 35px;
            width: 346px;
        }
        .auto-style6 {
            height: 34px;
            width: 346px;
        }
        .auto-style7 {
            height: 33px;
            width: 346px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product Form&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Code :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="codetextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Name :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="nametextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Description :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="desctextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Manufacturer :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="mtextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Price :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="pricetextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="productButton1" runat="server" Font-Size="Large" OnClick="productButton1_Click" Text="Submit" Width="134px" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
