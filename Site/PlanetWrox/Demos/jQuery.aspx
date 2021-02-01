<%@ Page Title="jQuery Demo" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/Frontend.Master" CodeBehind="jQuery.aspx.vb" Inherits="PlanetWrox.jQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <input id="Button1" type="button" value="button" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('#MainContent').css('background-color', 'green')
            $('#Button1').click(function () {
                $('#MainContent').css('background-color', 'red').animate({ width: '100px', height: '800px' })
            });
        });
    </script>
</asp:Content>
