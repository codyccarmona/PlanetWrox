
Partial Class Demos_ControlsDemo
    Inherits System.Web.UI.Page

  Protected Sub SubmitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
    Label1.Text = "Your name is " & YourName.Text
  End Sub
End Class
