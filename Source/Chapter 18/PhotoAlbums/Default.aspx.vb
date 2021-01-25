Imports PlanetWroxModel

Partial Class PhotoAlbums_Default
  Inherits BasePage

  Protected Sub ListView1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DataBound
    If Not String.IsNullOrEmpty(DropDownList1.SelectedValue) Then
      Dim photoAlbumId As Integer = Convert.ToInt32(DropDownList1.SelectedValue)
      Using myEntities As PlanetWroxEntities = New PlanetWroxEntities()
        Dim photoAlbumOwner As String = (From p In myEntities.PhotoAlbums
                                        Where p.Id = photoAlbumId
                                        Select p.UserName).Single()
        If User.Identity.IsAuthenticated And (User.Identity.Name = photoAlbumOwner Or User.IsInRole("Managers")) Then
          EditLink.NavigateUrl = String.Format("~/ManagePhotoAlbum.aspx?PhotoAlbumId={0}", DropDownList1.SelectedValue)
          EditLink.Visible = True
        Else
          EditLink.Visible = False
        End If
        If Not String.IsNullOrEmpty(photoAlbumOwner) Then
          Dim ownerProfile As ProfileCommon = Profile.GetProfile(photoAlbumOwner)
          UserNameLabel.Text = photoAlbumOwner
          BioLabel.Text = ownerProfile.Bio
          PhotoAlbumDetails.Visible = True
        Else
          PhotoAlbumDetails.Visible = False
        End If
      End Using
    Else
      EditLink.Visible = False
    End If
  End Sub
End Class
