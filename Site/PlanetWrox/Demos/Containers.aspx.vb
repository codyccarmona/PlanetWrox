Public Class Containers
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Panel1.Visible = False
    End Sub

    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Panel1.Visible = CheckBox1.Checked
    End Sub

    Protected Sub Wizard1_FinishButtonClick(sender As Object, e As WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
        Result.Text = "Your name is " & YourName.Text
        Result.Text &= "<br />Your favorite language is " & FavoriteLanguage.SelectedValue
    End Sub
End Class