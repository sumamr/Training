<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies1.aspx.cs" Inherits="Statemanagement.Cookies1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookies1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="UserName :"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="utextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" Text="Submit" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
