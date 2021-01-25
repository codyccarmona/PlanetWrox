Imports System.Net.Mail

Partial Class Demos_Email
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim myMessage As MailMessage = New MailMessage()
    myMessage.Subject = "Test Message"
    myMessage.Body = "Hello world, from Planet Wrox"
    myMessage.From = New MailAddress("you@yourprovider.com", "Sender Name")
    myMessage.To.Add(New MailAddress("you@yourprovider.com", "Receiver Name"))

    Dim mySmtpClient As SmtpClient = New SmtpClient()
    mySmtpClient.Send(myMessage)

  End Sub
End Class
