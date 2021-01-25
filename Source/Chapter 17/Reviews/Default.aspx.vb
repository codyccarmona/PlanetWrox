Imports PlanetWroxModel

Partial Class Reviews_Default
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Using myEntities As PlanetWroxEntities = New PlanetWroxEntities()
      If Profile.FavoriteGenres.Count > 0 Then
        Dim favGenres = From genre In myEntities.Genres
                        Order By genre.Name
                        Where Profile.FavoriteGenres.Contains(genre.Id)
                        Select New With {genre.Name, genre.Reviews}
        GenreRepeater.DataSource = favGenres
        GenreRepeater.DataBind()
      End If
      GenreRepeater.Visible = GenreRepeater.Items.Count > 0
      NoRecords.Visible = GenreRepeater.Items.Count = 0
    End Using
  End Sub
End Class
