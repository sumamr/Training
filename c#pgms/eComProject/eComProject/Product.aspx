<%@ Page Title="Product" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="eComProject.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Flipkart Products</h1>
    <table class="auto-style1">
            <tr>
                <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Product Form&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Code :"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="codetextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Name :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="nametextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Description :"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="desctextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Manufacturer :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="mtextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Price :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="pricetextbox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="productButton1" runat="server" Font-Size="Large" OnClick="productButton1_Click" Text="Submit" Width="86px" />
                </td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CssClass="auto-style1" DataKeyNames="code" DataSourceID="SqlDataSource1" Font-Size="Large" Height="176px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" PageSize="3" Width="430px">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="code" HeaderText="code" ReadOnly="True" SortExpression="code" />
                        <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                        <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                        <asp:BoundField DataField="manufacturer" HeaderText="manufacturer" SortExpression="manufacturer" />
                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbcs %>" DeleteCommand="DELETE FROM [productnew] WHERE [code] = @code" InsertCommand="INSERT INTO [productnew] ([code], [name], [description], [manufacturer], [price]) VALUES (@code, @name, @description, @manufacturer, @price)" SelectCommand="SELECT * FROM [productnew]" UpdateCommand="UPDATE [productnew] SET [name] = @name, [description] = @description, [manufacturer] = @manufacturer, [price] = @price WHERE [code] = @code">
                    <DeleteParameters>
                        <asp:Parameter Name="code" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="code" Type="Int32" />
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="description" Type="String" />
                        <asp:Parameter Name="manufacturer" Type="String" />
                        <asp:Parameter Name="price" Type="Double" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="name" Type="String" />
                        <asp:Parameter Name="description" Type="String" />
                        <asp:Parameter Name="manufacturer" Type="String" />
                        <asp:Parameter Name="price" Type="Double" />
                        <asp:Parameter Name="code" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </tr>
        </table>
</asp:Content>
