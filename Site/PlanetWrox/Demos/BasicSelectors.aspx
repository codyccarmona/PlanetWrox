﻿<%@ Page Title="jQuery Selector Demo" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/Frontend.Master" CodeBehind="BasicSelectors.aspx.vb" Inherits="PlanetWrox.BasicSelectors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <h1>Basic Selectors</h1>
    <div class="SampleClass">I am a div.</div>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="cpClientScript">
    <script type="text/javascript">
        $(function () {
            $('*').css('color', 'Green');
            $('#Footer').css('border-bottom', '2px solid black');
            $('h1').bind('click', function () { alert('Hellow World') });
            $('.SampleClass').addClass('PleaseWait').hide(5000);
            $('#Footer, #Header').slideUp('slow').slideDown('slow');
            $('#Sidebar img').fadeTo(5000, 0.1);
        });
    </script>
</asp:Content>

