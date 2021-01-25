Imports System.Net.Mail

Partial Class Demos_ExceptionHandling
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Try
      Dim myMessage As MailMessage = New MailMessage()
      myMessage.Subject = "Exception Handling Test"
      myMessage.Body = "Test message body"
      myMessage.From = New MailAddress("you@yourprovider.com")
      myMessage.To.Add(New MailAddress("you@yourprovider.com"))
      Dim mySmtpClient As New SmtpClient()
      mySmtpClient.Send(myMessage)
      Message.Text = "Message sent"
    Catch
      Message.Text = "An error occurred while sending your e‑mail. Please try again."
    End Try
  End Sub
End Class
