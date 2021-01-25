Imports PlanetWroxModel

Partial Class Reviews_ViewDetails
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim reviewId As Integer = Convert.ToInt32(Request.QueryString.Get("ReviewId"))
    Dim myReview As Review = TryCast(Cache("Reviews" + reviewId.ToString()), Review)
    If myReview Is Nothing Then
      Using myEntities As New PlanetWroxEntities()
        myReview = (From r In myEntities.Reviews
                    Where r.Id = reviewId
                    Select r).SingleOrDefault()
        If myReview IsNot Nothing Then
          Cache.Insert("Reviews" + reviewId.ToString(), myReview, Nothing, DateTime.Now.AddMinutes(20), System.Web.Caching.Cache.NoSlidingExpiration)
        End If
      End Using
    End If

    If myReview IsNot Nothing Then
      TitleLabel.Text = myReview.Title
      SummaryLabel.Text = myReview.Summary
      BodyLabel.Text = myReview.Body
      Title = myReview.Title
      MetaDescription = myReview.Summary
    End If
  End Sub
End Class
