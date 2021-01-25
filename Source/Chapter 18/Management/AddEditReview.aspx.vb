
Partial Class Management_AddEditReview
  Inherits System.Web.UI.Page

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If Request.QueryString.Get("Id") IsNot Nothing Then
      DetailsView1.DefaultMode = DetailsViewMode.Edit
    End If
  End Sub

  Protected Sub DetailsView1_ItemInserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewInsertedEventArgs) Handles DetailsView1.ItemInserted
    EndEditing()
  End Sub

  Protected Sub DetailsView1_ItemInserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewInsertEventArgs) Handles DetailsView1.ItemInserting
    e.Values("UpdateDateTime") = DateTime.Now
  End Sub

  Protected Sub DetailsView1_ItemUpdated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewUpdatedEventArgs) Handles DetailsView1.ItemUpdated
    EndEditing()
  End Sub

  Protected Sub DetailsView1_ItemUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.DetailsViewUpdateEventArgs) Handles DetailsView1.ItemUpdating
    e.NewValues("UpdateDateTime") = DateTime.Now
  End Sub

  Private Sub EndEditing()
    Response.Redirect("Reviews.aspx")
  End Sub

End Class
