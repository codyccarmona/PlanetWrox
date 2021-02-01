Imports System.IO
Imports System.Net.Mail

Public Class ContactForm
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub CustomValidator1_ServerValidate(source As Object, args As ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        If Not String.IsNullOrEmpty(PhoneHome.Text) Or Not String.IsNullOrEmpty(PhoneBusiness.Text) Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If
    End Sub

    Protected Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        If Page.IsValid Then
            Dim fileName As String = Server.MapPath("~/App_Data/ContactForm.txt")
            Dim mailBody As String = File.ReadAllText(fileName)

            mailBody = mailBody.Replace("##Name##", Name.Text)
            mailBody = mailBody.Replace("##Email##", EmailAddress.Text)
            mailBody = mailBody.Replace("##HomePhone##", PhoneHome.Text)
            mailBody = mailBody.Replace("##BusinessPhone##", PhoneBusiness.Text)
            mailBody = mailBody.Replace("##Comments##", Comments.Text)

            Dim myMessage As MailMessage = New MailMessage()
            myMessage.Subject = "Reponse from web site"
            myMessage.Body = mailBody

            myMessage.From = New MailAddress("codycarmona@gmail.com", "Sender Name")
            myMessage.To.Add(New MailAddress("c.carmona@wfbsusa.com", "Receiver Name"))

            Dim mySmtpClient As SmtpClient = New SmtpClient()
            mySmtpClient.Send(myMessage)

            Message.Visible = True
            FormTable.Visible = False


        End If
    End Sub
End Class