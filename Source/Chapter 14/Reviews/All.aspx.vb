Imports PlanetWroxModel

Partial Class Reviews_All
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Using myEntities As New PlanetWroxEntities()
      Dim allReviews = From review In myEntities.Reviews
      Where review.Authorized = True
      Order By review.CreateDateTime Descending
      Select review
      GridView1.DataSource = allReviews
      GridView1.DataBind()
    End Using
  End Sub
End Class
