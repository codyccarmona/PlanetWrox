Imports System.Data
Imports System.Data.SqlClient

Partial Class Management_Genres
  Inherits System.Web.UI.Page

  Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
    Select Case e.Row.RowType
      Case DataControlRowType.DataRow
        Dim myRowView As DataRowView = CType(e.Row.DataItem, DataRowView)
        If Convert.ToInt32(myRowView("NumberOfReviews")) > 0 Then
          Dim deleteLink As LinkButton = TryCast(e.Row.FindControl("DeleteLink"), LinkButton)
          If deleteLink IsNot Nothing Then
            deleteLink.Enabled = False
          End If
        End If
    End Select
  End Sub

  Protected Sub SqlDataSource1_Deleted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.SqlDataSourceStatusEventArgs) Handles SqlDataSource1.Deleted
    If e.Exception IsNot Nothing AndAlso TypeOf (e.Exception) Is SqlException Then
      Dim myException As SqlException = CType(e.Exception, SqlException)
      If myException.Number = 547 Then
        ErrorMessage.Text = "Sorry, you can’t delete this genre because " &
              "it has associated reviews that you need to delete first."
        e.ExceptionHandled = True
      End If
    End If
  End Sub
End Class
