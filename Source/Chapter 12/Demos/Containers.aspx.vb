
Partial Class Demos_Containers
  Inherits BasePage

  Protected Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
    Panel1.Visible = CheckBox1.Checked
  End Sub

  Protected Sub Wizard1_FinishButtonClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
    Result.Text = "Your name is " & YourName.Text
    Result.Text &= "<br />Your favorite language is " &
        FavoriteLanguage.SelectedValue
  End Sub
End Class
