<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceafterLogin.aspx.cs" Inherits="LocalBusiness.ServiceafterLogin" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Serviceafterlogin</title>
    <style>
        .header{
            float:right;
            width:100%;
            background-color:black;
            height:50px;
            color:wheat;
            font-size:20px;

        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 36px;
        }
        .auto-style3 {
            height: 41px;
        }
         footer{
position:fixed;bottom:0;width:100%;padding:3px;text-align:center;background-color:gray;font-size:20px;
}
        .auto-style4 {
            height: 36px;
            width: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
             <div class="header">
             <a href="Home.aspx">My Profile</a>
             &emsp;<a href="manageServices.aspx">Manage Services</a>
             &emsp;<a href="Login.aspx">Log Out</a>  
             </div> 
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style4"></td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2"></td>
                <td class="auto-style2" colspan="2"></td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2">
                    
                    <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound" ForeColor="Black">
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="Black" HorizontalAlign="Left" BackColor="#CCCCCC" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>
                    
                    <br />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" SelectCommand="SELECT * FROM [servicebooking]"></asp:SqlDataSource>
                </td>
                <td class="auto-style3" colspan="2">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>Accept</asp:ListItem>
                        <asp:ListItem>Reject</asp:ListItem>
                    </asp:DropDownList>
                    </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2"></td>
                <td class="auto-style3" colspan="2">
                    <asp:Button ID="SButton" runat="server" Font-Size="Large" OnClick="SButton_Click" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="2"></td>
                <td class="auto-style3" colspan="2"></td>
            </tr>
        </table>
    </form>
    <footer>
        <p>Service Provider Page</p>
    </footer>
</body>
</html>
