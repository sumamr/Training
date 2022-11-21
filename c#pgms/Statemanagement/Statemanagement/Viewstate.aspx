<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewstate.aspx.cs" Inherits="Statemanagement.Viewstate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View State</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 35px;
        }
        .auto-style4 {
            height: 36px;
        }
        .auto-style5 {
            height: 41px;
        }
        .auto-style6 {
            height: 30px;
            width: 175px;
        }
        .auto-style7 {
            height: 35px;
            width: 175px;
        }
        .auto-style8 {
            height: 36px;
            width: 175px;
        }
        .auto-style9 {
            height: 41px;
            width: 175px;
        }
        .auto-style10 {
            margin-left: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="USERNAME"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="utextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="PASSWORD"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="ptextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" Text="Submit" />
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style10" Font-Size="Large" OnClick="Button2_Click" Text="ReStore" Width="102px" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
