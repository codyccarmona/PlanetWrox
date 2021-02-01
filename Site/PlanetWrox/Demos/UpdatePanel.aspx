<%@ Page Title="Update Panel Demo" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/Frontend.Master" CodeBehind="UpdatePanel.aspx.vb" Inherits="PlanetWrox.UpdatePanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="server">
    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </ContentTemplate>
    </asp:UpdatePanel>
    
</asp:Content>
