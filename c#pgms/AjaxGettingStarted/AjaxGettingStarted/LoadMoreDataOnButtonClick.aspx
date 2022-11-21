<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadMoreDataOnButtonClick.aspx.cs" Inherits="AjaxGettingStarted.LoadMoreDataOnButtonClick" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table {
            margin: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <table border="1">
                        <tr>
                            <th align="center" colspan="6">EMPLOYEE DETAILS</th>
                        </tr>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <HeaderTemplate>
                                <tr>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Gender</th>
                                    <th>Age</th>
                                    <th>Designation</th>
                                    <th>Salary</th>
                                </tr>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("id") %></td>
                                    <td><%# Eval("name") %></td>
                                    <td><%# Eval("gender") %></td>
                                    <td><%# Eval("age") %></td>
                                    <td><%# Eval("designation") %></td>
                                    <td><%# Eval("salary") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        <tr>
                            <td colspan="6" align="center">
                                <asp:Button ID="Button1" runat="server" Text="Load More" OnClick="Button1_Click" />
                                <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="10">
                                    <ProgressTemplate>
                                        <asp:Image ID="Image1" ImageUrl="~/images/image.jfif" Height="45" Width="45" runat="server" />
                                    </ProgressTemplate>
                                </asp:UpdateProgress>

                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
