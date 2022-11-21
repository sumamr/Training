<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myservices.aspx.cs" Inherits="LocalBusiness.myservices" EnableEventValidation="false" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>myservices</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 42px;
        }
        .auto-style3 {
            height: 44px;
        }
        .auto-style4 {
            width: 263px;
            height: 216px;
        }
        .auto-style5 {
            height: 44px;
            width: 263px;
        }
        .auto-style6 {
            height: 216px;
        }
        .auto-style7 {
            margin-left: 72px;
        }
         .StarEmpty{
            background-image:url('images/img2.jfif');
            height:100px;
            width:100px;
        }
        .StarFilled{
            background-image:url('images/img1.jfif');
            height:100px;
            width:100px;
        }
        .header{
            float:right;
            width:100%;
            background-color:black;
            height:50px;
            color:wheat;
            font-size:20px;

        }
           footer{
position:fixed;bottom:0;width:100%;padding:3px;text-align:center;background-color:gray;font-size:20px;
}
        .auto-style8 {
            height: 216px;
            width: 150px;
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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        

            <ContentTemplate>

         
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3" style="font-size: larger">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; My Services&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" SelectCommand="SELECT * FROM [serviceprovider]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" Height="185px" Width="259px" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" ForeColor="Black">
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
                </td>
                <td class="auto-style8">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Ratings :"></asp:Label>
&nbsp;&nbsp;&nbsp;
                
                       
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">one star</asp:ListItem>
                        <asp:ListItem Value="2">two stars</asp:ListItem>
                        <asp:ListItem Value="3">three stars</asp:ListItem>
                        <asp:ListItem Value="4">four stars</asp:ListItem>
                        <asp:ListItem Value="5">five stars</asp:ListItem>
                    </asp:DropDownList>
                
                       
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Feedback :"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style7"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Font-Size="Large" OnClick="Button1_Click" Text="Submit" />
                
                       
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style3" colspan="2">
                    &nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
       </ContentTemplate>
    </form>
    <footer>
        <p>My Services List</p>
    </footer>
</body>
</html>
