<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListSearhExtender.aspx.cs" Inherits="AjaxGettingStarted.ListSearhExtender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 550px;
        }
        .auto-style2 {
            width: 201px;
        }
        .MyPromptCss{
            font-style:italic;
            font-weight:bold;
         
            color:purple;
            background-color:lightblue;
        }
        .auto-style3 {
            width: 201px;
            height: 44px;
        }
        .auto-style4 {
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">CHOOSE FRUITS</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                      <asp:DropDownList ID="DropDownList1" runat="server" Width="105px" Height="20px">
                             <asp:ListItem>Apple</asp:ListItem>
                            <asp:ListItem>Mango</asp:ListItem>
                            <asp:ListItem>Guava</asp:ListItem>
                            <asp:ListItem>Grapes</asp:ListItem>
                            <asp:ListItem>Papaya</asp:ListItem>
                            <asp:ListItem>Pine Apple</asp:ListItem>
                            <asp:ListItem>Watermelon</asp:ListItem>
                            <asp:ListItem>Straberry</asp:ListItem>
                            <asp:ListItem>Blueberry</asp:ListItem>
                            <asp:ListItem>Banana</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        
                        
                        <asp:ListBox ID="ListBox1" runat="server" Height="156px" Width="150px">
                            <asp:ListItem>Apple</asp:ListItem>
                            <asp:ListItem>Mango</asp:ListItem>
                            <asp:ListItem>Guava</asp:ListItem>
                            <asp:ListItem>Grapes</asp:ListItem>
                            <asp:ListItem>Papaya</asp:ListItem>
                            <asp:ListItem>Pine Apple</asp:ListItem>
                            <asp:ListItem>Watermelon</asp:ListItem>
                            <asp:ListItem>Straberry</asp:ListItem>
                            <asp:ListItem>Blueberry</asp:ListItem>
                            <asp:ListItem>Banana</asp:ListItem>
                        </asp:ListBox>
                        
                        
                        <ajaxToolkit:ListSearchExtender ID="ListBox1_ListSearchExtender" runat="server" BehaviorID="ListBox1_ListSearchExtender" TargetControlID="ListBox1" PromptText="Type to Find" QueryTimeout="2000" PromptCssClass="MyPromptCss" QueryPattern="Contains">
                        </ajaxToolkit:ListSearchExtender>
                        
                        
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                        <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        
                        
                       
                        
                        
                        <ajaxToolkit:ListSearchExtender ID="DropDownList1_ListSearchExtender" runat="server" BehaviorID="DropDownList1_ListSearchExtender" TargetControlID="DropDownList1">
                        </ajaxToolkit:ListSearchExtender>
                        
                        
                    </td>
                    <td class="auto-style4">
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
