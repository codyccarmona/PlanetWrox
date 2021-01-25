<%@ Page Title="Events Demo" Language="VB" MasterPageFile="~/MasterPages/Frontend.master" AutoEventWireup="false" CodeFile="Events.aspx.vb" Inherits="Demos_Events" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpMainContent" runat="Server">
  <table>
    <tr>
      <td>
        <h1>No PostBack</h1>
        <asp:Label ID="NoPostBack" runat="server" />
      </td>
      <td>
        <h1>PostBack</h1>
        <asp:Label ID="PostBack" runat="server" />
      </td>
    </tr>
  </table>
  <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="EntityDataSource1">
    <Columns>
      <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
      <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
      <asp:BoundField DataField="SortOrder" HeaderText="SortOrder" SortExpression="SortOrder" />
    </Columns>
  </asp:GridView>
  <asp:Button ID="Button1" runat="server" Text="Button" />
  <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=PlanetWroxEntities" DefaultContainerName="PlanetWroxEntities" EnableFlattening="False" EntitySetName="Genres">
  </asp:EntityDataSource>
</asp:Content>
