<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LocalBusiness.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            margin:20px;
            padding:10px;
        }
        .auto-style2 {
            height: 36px;
        }
        .auto-style3 {
            height: 40px;
        }
        .auto-style4 {
            height: 41px;
        }
        .auto-style5 {
            height: 38px;
        }
        .auto-style6 {
            height: 43px;
        }
        .auto-style7 {
            height: 34px;
        }
        .auto-style8 {
            height: 37px;
        }
        .auto-style10 {
            height: 40px;
            width: 234px;
        }
        .auto-style11 {
            height: 41px;
            width: 234px;
        }
        .auto-style12 {
            height: 38px;
            width: 234px;
        }
        .auto-style13 {
            height: 43px;
            width: 234px;
        }
        .auto-style14 {
            height: 36px;
            width: 234px;
        }
        .auto-style15 {
            height: 34px;
            width: 234px;
        }
        .auto-style16 {
            height: 37px;
            width: 234px;
        }
         footer{
position:fixed;bottom:0;width:100%;padding:3px;text-align:center;background-color:dimgrey;font-size:20px;
}
         header{
              padding: 2px;
             text-align: center;
  background: #1abc9c;
  color: lightblue;
  font-size: 30px;
         }
         table  {
             border :1px solid black; 
             width:2px;
         }
        .auto-style17 {
            height: 118px;
            width: 234px;
        }
        .auto-style18 {
            height: 118px;
        }
    </style>
    
</head>
<body>
    <header>
        <p>Registration Form</p>
    </header>
    <form id="form1" runat="server">
        <center>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2" style="font-size: larger">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Name :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="ntextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Email :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="etextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Mobile :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="mtextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="City :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="ctextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Locality :"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="ltextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Address :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="atextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="Label7" runat="server" Font-Size="Large" Text="ZipCode :"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="ztextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Label ID="Label8" runat="server" Font-Size="Large" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="ptextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="Label9" runat="server" Font-Size="Large" Text="Confirm Password :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="cptextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Button ID="Submit" runat="server" Font-Size="Large" Height="27px" Text="Submit" OnClick="Submit_Click" />
                </td>
                <td class="auto-style18">
                    <asp:Label ID="Label10" runat="server" Text="Save along with Role:"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="2">Customer</asp:ListItem>
                        <asp:ListItem Value="3">Service Provider</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
        <div>
        </div>
            </center>
    </form>
    <footer>
        <p>New User Please Register Above Form</p>
    </footer>
</body>
</html>
