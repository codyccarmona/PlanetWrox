Imports System.Web.Services
Public Class WebServices
    Inherits BasePage

    <WebMethod()>
    Public Shared Function HelloWorld(ByVal yourName As String) As String
        Return String.Format("Hello {0}", yourName)
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

End Class