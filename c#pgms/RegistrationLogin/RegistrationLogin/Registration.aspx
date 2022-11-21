<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="RegistrationLogin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            width: 141px;
        }
        .auto-style6 {
            width: 86%;
        }
        .auto-style7 {
            margin-left: 73px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">Registration</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Name :"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="nametextbox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametextbox" Display="Dynamic" ErrorMessage="Name is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Email :"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="emailtextbox" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailtextbox" Display="Dynamic" ErrorMessage="Invalid Email" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="emailtextbox" ErrorMessage="Email is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Mobile :"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="mobiletextbox" runat="server" MaxLength="10"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="mobiletextbox" Display="Dynamic" ErrorMessage="Mobile Number is Mandatory" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Password :" ToolTip="alphanumeric"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="passwordtextbox" runat="server" TextMode="Password" ToolTip="alphanumeric"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="passwordtextbox" ErrorMessage="Password is Mandatory" ForeColor="#CC0000" ToolTip="alphanumeric"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Confirm Password :"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="cpasswordtextbox" runat="server" TextMode="Password" ToolTip="alphanumeric"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordtextbox" ControlToValidate="cpasswordtextbox" ErrorMessage="Confirm Password is not matching with Password" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style7" OnClick="Button1_Click" Text="Register" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
