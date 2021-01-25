
Partial Class Demos_Source
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Server.Transfer("Target.aspx?Test=SomeValue")
  End Sub
End Class
