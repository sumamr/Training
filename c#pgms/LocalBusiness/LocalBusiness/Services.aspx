<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="LocalBusiness.Services" %>

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
        .auto-style2 {
            height: 33px;
        }
        .auto-style3 {
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <div>
            <div class="header">
      <a href="Home.aspx">My Profile</a>
      &emsp;<a href="manageServices.aspx">My Service List</a>
       &emsp;<a href="Login.aspx">Log Out</a>  
  </div> 
                  <table class="auto-style1">
                      <tr>
                          <td>
                              <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                                  <FooterStyle BackColor="#CCCCCC" />
                                  <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                  <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                  <RowStyle BackColor="White" />
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
                          <td class="auto-style2"></td>
                          <td class="auto-style2"></td>
                      </tr>
                      <tr>
                          <td class="auto-style2"></td>
                          <td class="auto-style2"></td>
                      </tr>
                      <tr>
                          <td class="auto-style3"></td>
                          <td class="auto-style3"></td>
                      </tr>
                      <tr>
                          <td class="auto-style2"></td>
                          <td class="auto-style2"></td>
                      </tr>
                  </table>
    </form>
    <footer>
        <p>SERVICES</p>
    </footer>
</body>
</html>
