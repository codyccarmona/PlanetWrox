Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://www.planetwrox.com/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class NameService
  Inherits System.Web.Services.WebService

  <WebMethod()>
  Public Function HelloWorld(ByVal yourName As String) As String
    Return String.Format("Hello {0}", yourName)
  End Function

End Class