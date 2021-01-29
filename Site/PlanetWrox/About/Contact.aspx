<%@ Page Title="Contact Us" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/Frontend.Master" CodeBehind="Contact.aspx.vb" Inherits="PlanetWrox.Contact" %>
<%@ Register src="../Controls/ContactForm.ascx" tagname="ContactForm" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <uc1:ContactForm ID="ContactForm1" runat="server" />
</asp:Content>
