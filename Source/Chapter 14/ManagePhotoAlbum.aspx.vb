Imports PlanetWroxModel

Partial Class _ManagePhotoAlbum
  Inherits BasePage

  Protected Sub EntityDataSource1_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.EntityDataSourceChangingEventArgs) Handles EntityDataSource1.Inserting
    Dim photoAlbumId As Integer = Convert.ToInt32(Request.QueryString.Get("PhotoAlbumId"))
    Dim myPicture As Picture = CType(e.Entity, Picture)
    myPicture.PhotoAlbumId = photoAlbumId

    Dim FileUpload1 As FileUpload = CType(ListView1.InsertItem.FindControl("FileUpload1"), FileUpload)
    Dim virtualFolder As String = "~/GigPics/"
    Dim physicalFolder As String = Server.MapPath(virtualFolder)
    Dim fileName As String = Guid.NewGuid().ToString()
    Dim extension As String = System.IO.Path.GetExtension(FileUpload1.FileName)
    FileUpload1.SaveAs(System.IO.Path.Combine(physicalFolder, fileName + extension))
    myPicture.ImageUrl = virtualFolder + fileName + extension
  End Sub

  Protected Sub ListView1_ItemInserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ListViewInsertEventArgs) Handles ListView1.ItemInserting
    Dim FileUpload1 As FileUpload = CType(ListView1.InsertItem.FindControl("FileUpload1"), FileUpload)
    If Not FileUpload1.HasFile OrElse Not FileUpload1.FileName.ToLower().EndsWith(".jpg") Then
      Dim cusValImage As CustomValidator = CType(ListView1.InsertItem.FindControl("cusValImage"), CustomValidator)
      cusValImage.IsValid = False
      e.Cancel = True
    End If
  End Sub

End Class
