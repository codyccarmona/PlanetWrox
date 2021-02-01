Public Class UpdatePanel
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = System.DateTime.Now.ToString()
    End Sub

End Class