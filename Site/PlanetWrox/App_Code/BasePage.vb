Public Class BasePage
    Inherits System.Web.UI.Page

    Private Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
        Dim prefTheme As HttpCookie = Request.Cookies.Get("PreferredTheme")
        If prefTheme IsNot Nothing Then
            Page.Theme = prefTheme.Value
        End If
    End Sub

    Private Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        If Me.Title = "Untitled Page" Or String.IsNullOrEmpty(Me.Title) Then
            Throw New Exception("Page title cannot be ""Untitled Page"" or an empty string.")
        End If
    End Sub
End Class

