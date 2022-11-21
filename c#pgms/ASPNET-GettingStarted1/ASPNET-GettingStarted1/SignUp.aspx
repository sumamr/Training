<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ASPNET_GettingStarted1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>SignUp Form</h1>
    <table class="nav-justified" style="background-color: #FFFFFF">
        <tr>
            <td style="height: 40px; width: 168px">
                <asp:Label ID="Label1" runat="server" Text="Name :" Font-Size="Large"></asp:Label>
            </td>
            <td style="height: 40px">
                <asp:TextBox ID="name" runat="server" OnTextChanged="name_TextChanged" required></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="name" Display="Dynamic" ErrorMessage="Name is Required" Font-Size="Medium" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px; height: 51px;">
                <asp:Label ID="Label2" runat="server" Text="Email :" Font-Size="Large"></asp:Label>
            </td>
            <td style="height: 51px">
                <asp:TextBox ID="emailtext" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailtext" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailtext" Display="Dynamic" ErrorMessage="Invalid Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px; height: 40px;">
                <asp:Label ID="Label3" runat="server" Text="Password :" Font-Size="Large"></asp:Label>
            </td>
            <td style="height: 40px">
                <asp:TextBox ID="passwordtext" runat="server" style="margin-bottom: 11" TextMode="Password" ToolTip="alphanumeric"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="passwordtext" Display="Dynamic" ErrorMessage="Password is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="passwordtext" ErrorMessage="Password should contain 8 chararters" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px; height: 46px;">
                <asp:Label ID="Label4" runat="server" Text="Mobile :" Font-Size="Large"></asp:Label>
            </td>
            <td style="height: 46px">
                <asp:TextBox ID="mobiletext" runat="server" BackColor="White" MaxLength="10"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="mobiletext" Display="Dynamic" ErrorMessage="Mobile number is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm">
                <asp:Label ID="Label5" runat="server" Text="DOB :" Font-Size="Large"></asp:Label>
            </td>
            <td>
                <asp:Calendar ID="Cal" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px; height: 45px;">
                <asp:Label ID="Label6" runat="server" Text="Sex :" Font-Size="Large"></asp:Label>
            </td>
            <td style="height: 45px; background-color: #FFFFFF;">
                <asp:RadioButtonList ID="gen" runat="server" RepeatDirection="Horizontal" Width="216px">
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="gen" ErrorMessage="select Gender" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px; height: 42px;">
                <asp:Label ID="Label7" runat="server" Text="Education :" Font-Size="Large"></asp:Label>
            </td>
            <td style="height: 42px">
                <asp:CheckBox ID="ug" runat="server" Text="UG" />
                <asp:CheckBox ID="pg" runat="server" Text="PG" />
                <asp:CheckBox ID="others" runat="server" Text="Others" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px; height: 42px;">
                <asp:Label ID="Label8" runat="server" Text="Location :" Font-Size="Large"></asp:Label>
            </td>
            <td style="height: 42px">
                <asp:DropDownList ID="location" runat="server" Width="122px">
                    <asp:ListItem>Channapatna</asp:ListItem>
                    <asp:ListItem>Maddur</asp:ListItem>
                    <asp:ListItem>Mandya</asp:ListItem>
                    <asp:ListItem>Bangalore</asp:ListItem>
                    <asp:ListItem>Tamil Nadu</asp:ListItem>
                    <asp:ListItem>Kerala</asp:ListItem>
                    <asp:ListItem>Andra Pradesh</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 168px">
                <a href="RegisteredUser.aspx">To see  Registered user ? Click Here</a>
                
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 169" Text="Submit" Width="86px" />
            </td>
            <td>

            </td>
        </tr>
    </table>
</asp:Content>
