﻿Public Class BasePage
  Inherits System.Web.UI.Page

  Private Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles Me.PreInit
    Dim preferredTheme As HttpCookie = Request.Cookies.Get("PreferredTheme")
    If preferredTheme IsNot Nothing Then
      Page.Theme = preferredTheme.Value
    End If
  End Sub
  Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
    If Me.Title = "Untitled Page" Or String.IsNullOrEmpty(Me.Title) Then
      Throw New Exception("Page title cannot be ""Untitled Page"" or an empty string.")
    End If
  End Sub

End Class