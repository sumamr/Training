<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customvalidation.aspx.cs" Inherits="CustomValidation.customvalidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Validation</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 39px;
        }
        .auto-style3 {
            height: 37px;
        }
        .auto-style4 {
            height: 38px;
        }
        .auto-style5 {
            height: 40px;
        }
        .auto-style6 {
            height: 36px;
        }
        .auto-style7 {
            height: 37px;
            width: 120px;
        }
        .auto-style8 {
            height: 38px;
            width: 120px;
        }
        .auto-style9 {
            height: 39px;
            width: 120px;
        }
        .auto-style10 {
            height: 40px;
            width: 120px;
        }
        .auto-style11 {
            height: 36px;
            width: 120px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2" style="font-size: x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Details&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Student Name :"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="nametextbox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nametextbox" Display="Dynamic" ErrorMessage="Name is Mandatory" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Student Email :"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="emailtextbox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailtextbox" Display="Dynamic" ErrorMessage="Email is mandatory" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Re-enter Email :"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="remailtextbox" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="emailtextbox" ControlToValidate="remailtextbox" Display="Dynamic" ErrorMessage="Email Id is not matching" ForeColor="Red">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Class :"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="classtextbox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="classtextbox" Display="Dynamic" ErrorMessage="Class is mandatory" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="classtextbox" Display="Dynamic" ErrorMessage="Enter Class Range from 1-12" ForeColor="Red" MaximumValue="12" MinimumValue="1"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Fees :"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="feestextbox" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="feestextbox" Display="Dynamic" ErrorMessage="Fees is Mandatory" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Gender :"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="Femalebutton" runat="server" Font-Size="Large" GroupName="gen" Text="Female" />
                        <asp:RadioButton ID="malebutton" runat="server" Font-Size="Large" GroupName="gen" Text="Male" />
                        <asp:RadioButton ID="RadioButton3" runat="server" Font-Size="Large" GroupName="gen" Text="Do not want to disclose" />
                        <asp:CustomValidator ID="CustomValidator1" runat="server" Display="Dynamic" ErrorMessage="Please select a gender" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" Width="159px" />
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Font-Size="Large" Text="Submit" Width="123px" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
