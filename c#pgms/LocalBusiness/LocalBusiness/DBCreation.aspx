<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBCreation.aspx.cs" Inherits="LocalBusiness.DBCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Landing Page</title>
    <style>
        ul {
  list-style-type: none;
  margin: 0;
  padding: 0;
  overflow: hidden;
  background-color: darkslategray;
}

li {
  float: right;
}

li a {
  display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size:20px;
}

li a:hover {
  background-color: #111;
}
.images {
            display: flex;
            flex-wrap: wrap;
            margin: 0 50px;
            padding: 30px;
        }
  
        .photo {
            max-width: 31.333%;
            padding: 0 10px;
            height: 240px;
        }
  
        .photo img {
            width: 100%;
            height: 85%;
        }
        .ili{
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
   <img src="images/logo.jfif" alt="logo" />
       <ul>
 <li> <a class="suma" href="ServiceafterLogin.aspx">Service Provider</a></li>
  <li><a href="Login.aspx">Customer</a></li>
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">HyperLink</asp:HyperLink>
 <li><a href="Home.aspx">Home</a></li>
           
          
           </ul>
  </div>        
<div class="ili">
    <p>
        A service provider is a business that supplies expert care or specialized services rather than an actual product. The term is usually saved for companies related to communication or technology, such as mobile phone companies or Internet service providers. Other service-related businesses, such as banks or mechanics, 
        rarely are called a service provider, even though the name would fit.
    </p>
</div>
        <div class="images">
        <div class="photo">
   <img src="images/simg1.jpeg" alt="photo"/>
        </div>
        <div class="photo">
            <img src="images/simg2.jpeg" alt="photo"/>
        </div>
        <div class="photo">
            <img src="images/simg3.jfif" alt="photo" />
        </div>
        <div class="photo">
            <img src="images/simg4.jfif" alt="photo" />
        </div>
        <div class="photo">
            <img src="images/simg6.jpeg" alt="photo" />
        </div>
            <div class="photo">
                <img src="images/simg9.jfif" alt="photo" />
            </div>
            </div>
    </form>
    <footer>
        <p>
           This is web page for our local business called Service provider.If you want any service we are here to help you .Contact No:7204830895
        </p>
    </footer>
</body>
</html>
