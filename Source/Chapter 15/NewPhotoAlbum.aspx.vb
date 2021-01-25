Imports PlanetWroxModel

Partial Class _NewPhotoAlbum
  Inherits BasePage

  Protected Sub EntityDataSource1_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.EntityDataSourceChangedEventArgs) Handles EntityDataSource1.Inserted
    Dim myPhotoAlbum As PhotoAlbum = CType(e.Entity, PhotoAlbum)
    Response.Redirect(String.Format("ManagePhotoAlbum.aspx?PhotoAlbumId={0}", myPhotoAlbum.Id.ToString()))
  End Sub
End Class
