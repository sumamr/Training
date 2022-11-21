<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manageServices.aspx.cs" Inherits="LocalBusiness.manageServices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Managing Services</title>
    <style type="text/css">
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
        .auto-style4 {
            height: 33px;
            width: 326px;
        }
        .auto-style6 {
            width: 326px;
            height: 60px;
        }
        .auto-style7 {
            height: 55px;
            width: 326px;
        }
        .auto-style8 {
            height: 55px;
        }
        .auto-style9 {
            height: 50px;
            width: 326px;
        }
        .auto-style10 {
            height: 50px;
        }
        .auto-style11 {
            height: 60px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="header">
      <a href="#myprofile">My Profile</a>
      &emsp;<a href="ListOfServices.aspx">ListofServices</a>
       &emsp;<a href="Login.aspx">Log Out</a>  
  </div> 
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" Height="140px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="192px">
                            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#594B9C" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#33276A" />
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Service Names :"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="Mechanic">Mechanic</asp:ListItem>
                            <asp:ListItem Value="Doctor">Doctor</asp:ListItem>
                            <asp:ListItem Value="Electricle">Electricle</asp:ListItem>
                            <asp:ListItem>Plumbing</asp:ListItem>
                            <asp:ListItem>Wiring</asp:ListItem>
                            <asp:ListItem>Software</asp:ListItem>
                            <asp:ListItem>Home Appliances</asp:ListItem>
                            <asp:ListItem>Hardware</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Description :"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="12pt" ForeColor="Red" OnClick="Button1_Click" Text="Add" Width="77px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
    <footer>
        <p>Managing All Services</p>
    </footer>
</body>
</html>
