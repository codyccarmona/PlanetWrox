﻿
Partial Class MasterPages_Frontend
  Inherits System.Web.UI.MasterPage

  Protected Sub ThemeList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ThemeList.SelectedIndexChanged
    Dim preferredTheme As HttpCookie = New HttpCookie("PreferredTheme")
    preferredTheme.Expires = DateTime.Now.AddMonths(3)
    preferredTheme.Value = ThemeList.SelectedValue
    Response.Cookies.Add(preferredTheme)
    Response.Redirect(Request.Url.ToString())
  End Sub

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If Not Page.IsPostBack Then
      Dim selectedTheme As String = Page.Theme
      Dim preferredTheme As HttpCookie = Request.Cookies.Get("PreferredTheme")
      If preferredTheme IsNot Nothing Then
        selectedTheme = preferredTheme.Value
      End If
      If Not String.IsNullOrEmpty(selectedTheme) AndAlso ThemeList.Items.FindByValue(selectedTheme) IsNot Nothing Then
        ThemeList.Items.FindByValue(selectedTheme).Selected = True
      End If
    End If
    Select Case Page.Theme.ToLower()
      Case "darkgrey"
        Menu1.Visible = False
        TreeView1.Visible = True
      Case Else
        Menu1.Visible = True
        TreeView1.Visible = False
    End Select
  End Sub

End Class

