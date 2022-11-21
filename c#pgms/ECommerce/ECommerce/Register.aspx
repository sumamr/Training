<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ECommerce.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 34px;
        }
        .auto-style4 {
            height: 32px;
        }
        .auto-style5 {
            height: 31px;
        }
        .auto-style6 {
            height: 33px;
        }
        .auto-style7 {
            height: 37px;
        }
        .auto-style8 {
            height: 38px;
        }
        .auto-style10 {
            height: 34px;
            width: 428px;
        }
        .auto-style11 {
            height: 32px;
            width: 428px;
        }
        .auto-style12 {
            height: 31px;
            width: 428px;
        }
        .auto-style13 {
            height: 33px;
            width: 428px;
        }
        .auto-style14 {
            height: 37px;
            width: 428px;
        }
        .auto-style15 {
            height: 38px;
            width: 428px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registration Form</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Name :"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="nametextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Email :"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="emailtextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Mobile :"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="mobiletextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Address :"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="addresstextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style14">
                        <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Location :"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="locationtextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Password :"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="passwordtextbox" runat="server" TextMode="Password" ToolTip="alphanumeric"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">
                        <asp:Label ID="Label7" runat="server" Font-Size="Large" Text="ZipCode :"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="zipcodetextbox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style15">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" Text="Submit" Width="94px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
