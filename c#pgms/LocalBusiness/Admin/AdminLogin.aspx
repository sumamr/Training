<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="LocalBusiness.Login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login1</title>
    <style>
        footer{
position:fixed;bottom:0;width:100%;padding:3px;text-align:center;background-color:gray;font-size:20px;
}
         .suma{
              padding: 2px;
             float:right;
             background: #1abc9c;
             color: lightblue;
             font-size: 20px;
             width:100%;
             margin:30px;
             height:50px;
         }
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
     <header>
        <center><h2>Please fill the below login Form</h2></center>
    </header>
    <form id="form1" runat="server">
       <div class="suma">
       
        <a href="ServiceafterLogin.aspx">Service Provider</a>
       <a href="myservices.aspx">My Services</a>
       <a href="Login.aspx">Log Out</a>
       
  </div>  
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Login ID="Login2" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" OnAuthenticate="Login2_Authenticate">
                        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
                    </asp:Login>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    <footer>
        <p>Login Form</p>
    </footer>
</body>
</html>
