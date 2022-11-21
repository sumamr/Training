<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviceprovider.aspx.cs" Inherits="ServiceProviderFprm.servicprovider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Service Provider</title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 134px;
            height: 37px;
        }
        .auto-style6 {
            height: 37px;
        }
        .auto-style7 {
            width: 134px;
            height: 38px;
        }
        .auto-style8 {
            height: 38px;
        }
        .auto-style9 {
            width: 134px;
            height: 35px;
        }
        .auto-style10 {
            height: 35px;
        }
        .auto-style11 {
            width: 134px;
            height: 34px;
        }
        .auto-style12 {
            height: 34px;
        }
        form
        {
            height:100%;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            width: 935px;
            height: 614px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="border-style: double; background-color: #C0C0C0" class="auto-style14">
        <table class="auto-style1" align="center" valign="middle">
            <tr>
                <td class="auto-style4" colspan="2" style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Service Provider</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Name :"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="nametextbox" runat="server" Width="134px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="White" BorderColor="Red" ControlToValidate="nametextbox" Display="Dynamic" ErrorMessage="Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Email :"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="emailtextbox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailtextbox" Display="Dynamic" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailtextbox" ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Mobile :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="mobiletextbox" runat="server" MaxLength="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="mobiletextbox" Display="Dynamic" ErrorMessage="Mobile number is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Service Type :"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Electronics</asp:ListItem>
                        <asp:ListItem>Software</asp:ListItem>
                        <asp:ListItem>Electricals</asp:ListItem>
                        <asp:ListItem>Home Appliances</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Service type is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Address :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="addresstextbox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="addresstextbox" Display="Dynamic" ErrorMessage="Address is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Location :"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Malleshwaram</asp:ListItem>
                        <asp:ListItem>Neharu nagar</asp:ListItem>
                        <asp:ListItem>MG Road</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList2" Display="Dynamic" ErrorMessage="Location is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label7" runat="server" Font-Size="Large" Text="City :"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="citytextbox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="citytextbox" Display="Dynamic" ErrorMessage="City is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label8" runat="server" Font-Size="Large" Text="Zipcode :"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="zipcodetextbox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="zipcodetextbox" Display="Dynamic" ErrorMessage="Zipcode is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10" colspan="2">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Save" Font-Size="Large" />
                </td>
            </tr>
        </table>
        <div class="auto-style13">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="searchserviceprovider.aspx">Search Service Form</a>
        </div>
    </form>
</body>
</html>
