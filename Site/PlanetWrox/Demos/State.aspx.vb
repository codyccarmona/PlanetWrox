Public Class State
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles SetDate.Click
        Label1.Text = DateTime.Now.ToString()
        Label2.Text = DateTime.Now.ToString()
    End Sub
End Class