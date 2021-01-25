Imports PlanetWroxModel

Partial Class Reviews_AllByGenre
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Using myEntities As New PlanetWroxEntities()
      Dim allGenres = From genre In myEntities.Genres
                      Order By genre.Name
                      Select New With {genre.Name, genre.Reviews}
      Repeater1.DataSource = allGenres
      Repeater1.DataBind()
    End Using
  End Sub
End Class
