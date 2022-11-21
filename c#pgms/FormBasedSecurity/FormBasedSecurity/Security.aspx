<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Security.aspx.cs" Inherits="FormBasedSecurity.Security" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 39px;
        }
        .auto-style3 {
            height: 38px;
        }
        .auto-style4 {
            height: 34px;
        }
        .auto-style5 {
            height: 35px;
        }
        .auto-style6 {
            height: 37px;
        }
        .auto-style7 {
            height: 39px;
            width: 218px;
        }
        .auto-style8 {
            height: 38px;
            width: 218px;
        }
        .auto-style9 {
            height: 34px;
            width: 218px;
        }
        .auto-style10 {
            height: 35px;
            width: 218px;
        }
        .auto-style11 {
            height: 37px;
            width: 218px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="User Name :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="utextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="ptextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Button ID="Button1" runat="server" Font-Size="Large" Text="Login" OnClick="Button1_Click" />
                </td>
                <td class="auto-style4">
                    <asp:CheckBox ID="CheckBox1" runat="server" Font-Size="Large" Text="Register Me" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                <td class="auto-style6">
                     <a href="Registation/Registration.aspx">Registation/Registration.aspx</a>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
