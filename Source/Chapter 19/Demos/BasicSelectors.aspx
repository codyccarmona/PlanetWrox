﻿<%@ Page Title="Basic Selectors Demo" Language="VB" MasterPageFile="~/MasterPages/Frontend.master" AutoEventWireup="false" CodeFile="BasicSelectors.aspx.vb" Inherits="Demos_BasicSelectors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="Server">
  <h1>Basic Selectors</h1>
  <div class="SampleClass">I am a div.</div>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="cpClientScript">
  <script type="text/javascript">
    $(function ()
    {
      $('*').css('color', 'Green');                                 // Universal
      $('#Footer').css('border-bottom', '2px solid black');         // ID
      $('h1').bind('click', function () { alert('Hello World') });  // Element
      $('.SampleClass').addClass('PleaseWait').hide(5000);          // Class
      $('#Footer, #Header').slideUp('slow').slideDown('slow');      // Grouped
      $('#Sidebar img').fadeTo(5000, 0.1);                          // Combined
    });
  </script>
</asp:Content>
