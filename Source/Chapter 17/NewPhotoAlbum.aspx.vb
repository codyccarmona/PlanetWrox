Imports PlanetWroxModel

Partial Class _NewPhotoAlbum
  Inherits BasePage

  Protected Sub EntityDataSource1_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.EntityDataSourceChangedEventArgs) Handles EntityDataSource1.Inserted
    Dim myPhotoAlbum As PhotoAlbum = CType(e.Entity, PhotoAlbum)
    Response.Redirect(String.Format("ManagePhotoAlbum.aspx?PhotoAlbumId={0}", myPhotoAlbum.Id.ToString()))
  End Sub

  Protected Sub EntityDataSource1_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.EntityDataSourceChangingEventArgs) Handles EntityDataSource1.Inserting
    Dim myPhotoAlbum As PhotoAlbum = CType(e.Entity, PhotoAlbum)
    myPhotoAlbum.UserName = User.Identity.Name
  End Sub
End Class
