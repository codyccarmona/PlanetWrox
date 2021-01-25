Imports System.Web.Services

Partial Class Demos_WebServices
  Inherits BasePage

  <WebMethod()>
  Public Shared Function HelloWorld(ByVal yourName As String) As String
    Return String.Format("Hello {0}", yourName)
  End Function

End Class
