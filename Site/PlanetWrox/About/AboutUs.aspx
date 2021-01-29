<%@ Page Title="About Us" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/Frontend.Master" CodeBehind="AboutUs.aspx.vb" Inherits="PlanetWrox.AboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    <p>I made this site to learn a skill so I can make money and stop having to learn to make more money</p>
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <Wrox:Banner ID="Banner2" runat="server" DisplayDirection="Horizontal" />
</asp:Content>
