Public Class Source
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Redirect("Target.aspx?Test=SomeValue")
    End Sub

End Class