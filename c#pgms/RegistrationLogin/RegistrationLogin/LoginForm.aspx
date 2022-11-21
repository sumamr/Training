<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="RegistrationLogin.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Form</title>
    <style type="text/css">
        .auto-style1 {
            width: 61%;
            margin-bottom: 64px;
        }
        .auto-style4 {
            width: 208px;
            height: 29px;
        }
        .auto-style5 {
            height: 29px;
        }
        .auto-style6 {
            width: 208px;
            height: 34px;
        }
        .auto-style7 {
            height: 34px;
        }
        .auto-style9 {
            height: 35px;
        }
        .auto-style10 {
            margin-left: 93px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login Form</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Name:"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="nametextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Password:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="passwordtextbox" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                                                <a href="Registration.aspx">Not Registered yet ? Click Here</a>
                    </td>
                    <td class="auto-style9">

                        <asp:Button ID="Button1" runat="server" CssClass="auto-style10" OnClick="Button1_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
