<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordStrength.aspx.cs" Inherits="AjaxGettingStarted.PasswordStrength" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .barBarder
    {
        border:2px solid black;
        width:120px;
       background:red;
    }
    .BarIndicator{
       background:green;
       
    }
    .poor{
        background-color:darkred;
    }
    .weak{
        background-color:red;
    }
    .average{
        background-color:yellow;
    }
    .strong{
        background-color:green;
    }
    .verystrong{
        background-color:forestgreen;
    }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="Label1" runat="server" Text="Enter Password"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <ajaxToolkit:PasswordStrength ID="PasswordStrength1" runat="server" MinimumNumericCharacters="2" MinimumSymbolCharacters="1" MinimumLowerCaseCharacters="3" MinimumUpperCaseCharacters="2" PreferredPasswordLength="8" HelpStatusLabelID="Label2" PrefixText="Password Strength: " StrengthIndicatorType="BarIndicator" TargetControlID="TextBox1" BarIndicatorCssClass="" BarBorderCssClass=" barBarder" RequiresUpperAndLowerCaseCharacters="True" TextStrengthDescriptions="poor;weak;average;strong;verystrong" DisplayPosition="BelowRight" HelpHandlePosition="BelowRight" StrengthStyles="poor;weak;average;strong;verystrong" />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
