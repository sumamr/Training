<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EvenNumber.aspx.cs" Inherits="CustomValidation.EvenNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Even Number</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 44px;
        }
        .auto-style3 {
            height: 48px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            height: 48px;
            width: 327px;
        }
        .auto-style6 {
            height: 44px;
            width: 327px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="2" class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="2" style="font-size: larger">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; EVEN NUMBER&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Enter Even Number :"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="etextbox" runat="server"></asp:TextBox>
                        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="etextbox" Display="Dynamic" ErrorMessage="Please enter even Number" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="etextbox" Display="Dynamic" ErrorMessage="Please enter a value" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Font-Size="Large" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
