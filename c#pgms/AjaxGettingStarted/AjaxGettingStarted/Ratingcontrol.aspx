<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ratingcontrol.aspx.cs" Inherits="AjaxGettingStarted.Ratingcontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 197px;
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
        .auto-style3 {
            width: 197px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <table cellpadding="2" class="auto-style1">
                <tr>
                    <td class="auto-style2" style="font-size: larger">RATE OUR WEBSITE</td>
                    <td>
                        <ajaxToolkit:Rating ID="Rating2" runat="server" CurrentRating="1" AutoPostBack="True" StarCssClass="StarEmpty" FilledStarCssClass="StarFilled" EmptyStarCssClass="StarEmpty" WaitingStarCssClass="StarFilled" OnClick="Rating2_Click">
                        </ajaxToolkit:Rating>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
