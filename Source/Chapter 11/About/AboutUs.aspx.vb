
Partial Class About_AboutUs
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If Not Page.IsPostBack Then
      Banner2.NavigateUrl = "http://imar.spaanjaars.com"
    End If
  End Sub

End Class
