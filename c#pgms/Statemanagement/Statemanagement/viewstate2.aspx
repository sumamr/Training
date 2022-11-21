<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewstate2.aspx.cs" Inherits="Statemanagement.viewstate2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 34px;
        }
        .auto-style3 {
            height: 36px;
        }
        .auto-style4 {
            height: 46px;
        }
        .auto-style5 {
            height: 48px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="USERNAME :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="utextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="PASSWORD :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="ptextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="RESTORE" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
