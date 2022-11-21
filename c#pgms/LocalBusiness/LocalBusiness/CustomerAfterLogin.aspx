<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAfterLogin.aspx.cs" Inherits="LocalBusiness.CustomerAfterLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 49px;
        }
        .auto-style3 {
            height: 51px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style6 {
            height: 39px;
        }
        .auto-style7 {
            height: 35px;
        }
        .suma{
            float:right;
        }
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
        .auto-style12 {
            height: 49px;
            width: 231px;
        }
        .auto-style14 {
            height: 39px;
            width: 220px;
        }
        .auto-style15 {
            height: 49px;
            width: 220px;
        }
        .auto-style16 {
            margin-left: 206px;
        }
        .auto-style17 {
            width: 154px;
        }
        .auto-style18 {
            height: 49px;
            width: 134px;
        }
        .auto-style19 {
            height: 39px;
            width: 134px;
        }
        .auto-style21 {
            height: 39px;
            width: 441px;
        }
        .auto-style22 {
            height: 49px;
            width: 441px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="header">
      <a href="#myprofile">My Profile</a>
      &emsp;<a href="#myservicelist">My Service List</a>
       &emsp;<a href="#logout">Log Out</a>  
  </div> 
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2"></td>
                <td class="auto-style3" colspan="4"></td>
            </tr>
            <tr>
                <td class="auto-style18">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Services :"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Mechanic</asp:ListItem>
                        <asp:ListItem>Plumbing</asp:ListItem>
                        <asp:ListItem>Mobile Service</asp:ListItem>
                        <asp:ListItem>Internet</asp:ListItem>
                        <asp:ListItem>Electrician</asp:ListItem>
                        <asp:ListItem>Electricle</asp:ListItem>
                        <asp:ListItem>Doctor</asp:ListItem>
                        <asp:ListItem>Home Appliances</asp:ListItem>
                        <asp:ListItem>Laptop Services</asp:ListItem>
                        <asp:ListItem>Software</asp:ListItem>
                        <asp:ListItem>Hardware</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style15">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Search By Name:"></asp:Label>
                </td>
                <td class="auto-style12">
                    <asp:TextBox ID="stextbox" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button3" runat="server" Font-Size="Large" Text="Search" OnClick="Button3_Click" />
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19"></td>
                <td class="auto-style21">
                    <asp:Button ID="Button1" runat="server" Font-Size="Large" Text="View" OnClick="Button1_Click" />
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td class="auto-style6" colspan="3">
                    <asp:Button ID="Button2" runat="server" Font-Size="Large" Text="Book" CssClass="auto-style16" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7" colspan="2">
                    
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" SelectCommand="SELECT * FROM [serviceprovider]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderWidth="3px" CellPadding="4" ForeColor="Black" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" BorderStyle="Solid" CellSpacing="2">
                        <Columns>
                        <asp:TemplateField>
                            <HeaderTemplate>
                                <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" Text="Select All" OnCheckedChanged="CheckBox1_CheckedChanged"/>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:CheckBox ID="suma" runat="server" OnCheckedChanged="suma_CheckedChanged"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="Black" HorizontalAlign="Left" BackColor="#CCCCCC" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" ForeColor="White" Font-Bold="True" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                       
                    </asp:GridView>
                </td>
                <td class="auto-style7" colspan="4"></td>
            </tr>
        </table>
    </form>
    <footer>
        <p>Customer Service Page</p>
    </footer>
</body>
</html>
