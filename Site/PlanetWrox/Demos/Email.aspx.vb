Imports System.Net.Mail
Public Class Email
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim myMessage As MailMessage = New MailMessage()
        myMessage.Subject = "Test Message"
        myMessage.Body = "Hellow world, from Planet Wrox"
        myMessage.From = New MailAddress("codycarmona@gmail.com", "Sender Name")
        myMessage.To.Add(New MailAddress("c.carmona@wfbsusa.com", "Receiver Name"))

        Dim mySmtpClient As SmtpClient = New SmtpClient()
        mySmtpClient.Send(myMessage)
    End Sub

End Class