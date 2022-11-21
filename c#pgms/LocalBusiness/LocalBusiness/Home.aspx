<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LocalBusiness.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <style>
        .header{
            float:right;
            width:100%;
            background-color:black;
            height:50px;
            color:white;
            font-size:20px;

        }
        footer{
position:fixed;bottom:0;width:100%;padding:3px;text-align:center;background-color:dimgrey;font-size:20px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="header">
  <a href="ServiceafterLogin.aspx">Service Provider</a>&nbsp;
 &emsp; <a href="Login.aspx">Customer</a>
 &emsp;<a href="#home">Home</a>
 
  </div>    
        <div>
            <center><h1>WELCOME TO LOCAL BUSINESS PROJECT</h1></center>
        </div>
    </form>
    
    <footer>
        <p><h1>HOME</h1></p>
    </footer>
</body>
</html>
