Public Class ListControls
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "In the DDL you selected " & DropDownList1.SelectedValue & "<br />"

        For Each item As ListItem In CheckBoxList1.Items
            If item.Selected Then
                Label1.Text &= "In the CBL you select " & item.Value & "<br />"
            End If
        Next
    End Sub
End Class