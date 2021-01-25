﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ContactForm.ascx.vb" Inherits="Controls_ContactForm" %>
<style type="text/css">
  .style1
  {
    width: 100%;
  }
</style>
<script type="text/javascript">
  function ValidatePhoneNumbers(source, args)
  {
    var phoneHome = document.getElementById('<%= PhoneHome.ClientID %>');
    var phoneBusiness = document.getElementById('<%= PhoneBusiness.ClientID %>');
    if (phoneHome.value != '' || phoneBusiness.value != '')
    {
      args.IsValid = true;
    }
    else
    {
      args.IsValid = false;
    }
  }
</script>
<table class="style1" runat="server" id="FormTable">
  <tr>
    <td colspan="3">
      <h1>Get in touch with us</h1>
      <p>Use the form below to get in touch with us. Enter your name, e-mail address, and your home or business phone number to get in touch with us.</p>
    </td>
  </tr>
  <tr>
    <td>
      Name
    </td>
    <td>
      <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    </td>
    <td>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" CssClass="ErrorMessage" ErrorMessage="Enter your name">*</asp:RequiredFieldValidator>
    </td>
  </tr>
  <tr>
    <td>
      E-mail address
    </td>
    <td>
      <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox>
    </td>
    <td>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailAddress" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Enter an e-mail address">*</asp:RequiredFieldValidator>
      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailAddress" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Enter a valid e-mail address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    </td>
  </tr>
  <tr>
    <td>
      E-mail address again
    </td>
    <td>
      <asp:TextBox ID="ConfirmEmailAddress" runat="server"></asp:TextBox>
    </td>
    <td>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ConfirmEmailAddress" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Confirm the e-mail address">*</asp:RequiredFieldValidator>
      <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="EmailAddress" ControlToValidate="ConfirmEmailAddress" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Retype the e-mail address">*</asp:CompareValidator>
    </td>
  </tr>
  <tr>
    <td>
      Home phone number
    </td>
    <td>
      <asp:TextBox ID="PhoneHome" runat="server"></asp:TextBox>
    </td>
    <td>
      <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="ValidatePhoneNumbers" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Enter your home or business phone number">*</asp:CustomValidator>
    </td>
  </tr>
  <tr>
    <td>
      Business phone number
    </td>
    <td>
      <asp:TextBox ID="PhoneBusiness" runat="server"></asp:TextBox>
    </td>
    <td>
    </td>
  </tr>
  <tr>
    <td>
      Comments
    </td>
    <td>
      <asp:TextBox ID="Comments" runat="server" Height="78px" TextMode="MultiLine" Width="341px"></asp:TextBox>
    </td>
    <td>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Comments" CssClass="ErrorMessage" Display="Dynamic" ErrorMessage="Enter a comment">*</asp:RequiredFieldValidator>
    </td>
  </tr>
  <tr>
    <td>
    </td>
    <td>
      <asp:Button ID="SendButton" runat="server" Text="Send" />
    </td>
    <td>
    </td>
  </tr>
  <tr>
    <td colspan="3">
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="ErrorMessage" HeaderText="Please correct the following errors before you press the Send button:" />
    </td>
  </tr>
</table>
<asp:Label ID="Message" runat="server" Text="Message Sent" Visible="False" />