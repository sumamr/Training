<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceProviderDetails.aspx.cs" Inherits="LocalBusiness.ServiceProviderDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <div>
            <div class="header">
      <a href="Home.aspx">My Profile</a>
      &emsp;<a href="myservices.aspx">My Service List</a>
       &emsp;<a href="Login.aspx">Log Out</a>  
  </div> 
                  <table class="auto-style1">
                      <tr>
                          <td>
                              <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                                  <AlternatingRowStyle BackColor="#CCCCCC" />
                                  <FooterStyle BackColor="#CCCCCC" />
                                  <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                  <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                  <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                  <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                  <SortedAscendingHeaderStyle BackColor="#808080" />
                                  <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                  <SortedDescendingHeaderStyle BackColor="#383838" />
                              </asp:GridView>
                          </td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td>&nbsp;</td>
                          <td>&nbsp;</td>
                      </tr>
                      <tr>
                          <td>&nbsp;</td>
                          <td>&nbsp;</td>
                      </tr>
                  </table>
        </div>
    </form>
    <footer>
        <p>Service Provider Details</p>
    </footer>
</body>
</html>
