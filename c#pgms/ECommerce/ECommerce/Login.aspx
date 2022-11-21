<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ECommerce.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 240px;
            height: 53px;
        }
        .auto-style4 {
            height: 53px;
        }
        .auto-style5 {
            width: 240px;
            height: 51px;
        }
        .auto-style6 {
            height: 51px;
        }
        .auto-style7 {
            width: 240px;
            height: 42px;
        }
        .auto-style8 {
            height: 42px;
        }
        .auto-style9 {
            width: 240px;
            height: 44px;
        }
        .auto-style10 {
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login Form</div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Email :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="emailtextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="passwordtextbox" runat="server" TextMode="Password" ToolTip="alphanumeric"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="LoginButton1" runat="server" Font-Size="Large" OnClick="LoginButton1_Click" Text="Login" Width="80px" />
                </td>
                <td class="auto-style6">
                    <a href="Register.aspx">Not Registered Yet?Click Here</a>
                    </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    </form>
</body>
</html>
