<%@ Page Title= "State" Language="vb" AutoEventWireup="false" CodeBehind="State.aspx.vb" Inherits="PlanetWrox.State" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label" ViewStateMode="Enabled"></asp:Label>
                        <asp:Label ID="Label2" runat="server" EnableViewState="False" Text="Label"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="SetDate" runat="server" Text="Set Date" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                            <TodayDayStyle BackColor="#CCCCCC" />
                        </asp:Calendar>
                    </td>
                    <td>
                        <asp:Button ID="PlainPostBack" runat="server" Text="Plain PostBack" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
