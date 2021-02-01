Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class NameService
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function HelloWorld(ByVal yourName As String) As String
        Return String.Format("Hello, {0}", yourName)
    End Function


End Class