
Partial Class Errors_Error404
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Response.Status = "404 Not Found"
    Response.StatusCode = 404
  End Sub
End Class
