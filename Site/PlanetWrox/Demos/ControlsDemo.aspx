<%@ Page Title= "Controls Demo" Language="vb" AutoEventWireup="false" CodeBehind="ControlsDemo.aspx.vb" Inherits="PlanetWrox.ControlsDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 
        Your Name<asp:TextBox ID="YourName" runat="server"></asp:TextBox>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit Information" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
 
    </form>
</body>
</html>
