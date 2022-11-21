<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LocalBusiness.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .auto-style1 {
            width: 30%;
            margin:20px;
            padding:20px;
        }
        .auto-style2 {
            height: 37px;
        }
        .auto-style6 {
            height: 42px;
            width: 198px;
        }
        .auto-style7 {
            height: 36px;
            width: 198px;
        }
        .auto-style8 {
            height: 35px;
            width: 198px;
        }
         footer{
position:fixed;bottom:0;width:100%;padding:3px;text-align:center;background-color:gray;font-size:20px;
}
         .suma{
              padding: 2px;
             float:left;
             background: #1abc9c;
             color: lightblue;
             font-size: 20px;
             width:100%;
             margin:30px;
             height:50px;
         }
        table {
  border: 1px solid black;
  
  
}
        .auto-style9 {
            height: 42px;
            width: 351px;
        }
        .auto-style10 {
            height: 36px;
            width: 351px;
        }
        .auto-style11 {
            height: 35px;
            width: 351px;
        }
    </style>
</head>
<body>
    <header>
        <center><p><h2>Please fill the below login Form</h2></p></center>
    </header>
    <center>
    <form id="form1" runat="server">
        <div class="suma">
       
        <a href="ServiceafterLogin.aspx">Service Provider</a>
       <a href="myservices.aspx">My Services</a>
       <a href="Login.aspx">Log Out</a>
       
  </div>  
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2" style="font-size: larger">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Email :"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="etextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="ptextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" Font-Size="Large" Text="Login" OnClick="Button1_Click" />
                </td>
                <td class="auto-style11"><a href="Registration.aspx">New User Click here To Register</a></td>
                
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
        </center>
    <footer>
        <p>Login Form</p>
    </footer>
</body>
</html>
