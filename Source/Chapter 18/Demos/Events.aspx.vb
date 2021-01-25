
Partial Class Demos_Events
  Inherits BasePage

  Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
    WriteMessage("Button1_Click")
  End Sub

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    WriteMessage("Page_Load")
  End Sub

  Protected Sub GridView1_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Sorted
    WriteMessage("GridView1_Sorted")
  End Sub

  Protected Sub GridView1_Sorting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSortEventArgs) Handles GridView1.Sorting
    WriteMessage("GridView1_Sorting")
  End Sub

  Protected Sub GridView1_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowCreated
    WriteMessage("GridView1_RowCreated")
  End Sub

  Protected Sub GridView1_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DataBinding
    WriteMessage("GridView1_DataBinding")
  End Sub

  Protected Sub GridView1_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DataBound
    WriteMessage("GridView1_DataBound")
  End Sub

  Protected Sub GridView1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GridView1.RowDataBound
    WriteMessage("GridView1_RowDataBound")
  End Sub

  Protected Sub EntityDataSource1_ContextCreating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.EntityDataSourceContextCreatingEventArgs) Handles EntityDataSource1.ContextCreating
    WriteMessage("EntityDataSource1_ContextCreating")
  End Sub

  Protected Sub EntityDataSource1_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.EntityDataSourceSelectingEventArgs) Handles EntityDataSource1.Selecting
    WriteMessage("EntityDataSource1_Selecting")
  End Sub

  Protected Sub Page_PreRenderComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRenderComplete
    WriteMessage("Page_PreRenderComplete<br />-----------------")
  End Sub

  Private Sub WriteMessage(ByVal handlerName As String)
    If Page.IsPostBack Then
      PostBack.Text &= handlerName & "<br />"
    Else
      NoPostBack.Text &= handlerName & "<br />"
    End If
  End Sub

End Class
