Public Class Banner
    Inherits System.Web.UI.UserControl

    Public Property DisplayDirection As Direction
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        HorizontalPanel.Visible = False
        VerticalPanel.Visible = False

        Select Case DisplayDirection
            Case Direction.Horizontal
                HorizontalPanel.Visible = True
                HorizontalLink.HRef = NavigateUrl
            Case Direction.Vertical
                VerticalPanel.Visible = True
                VerticalLink.HRef = NavigateUrl
        End Select
    End Sub

    Public Property NavigateUrl() As String
        Get
            Dim _navigateUrl As Object = ViewState("NavigateUrl")
            If _navigateUrl IsNot Nothing Then
                Return CType(_navigateUrl, String)
            Else
                Return "http://p2p.wrox.com"
            End If
        End Get
        Set(value As String)
            ViewState("NavigateUrl") = value
        End Set
    End Property
End Class