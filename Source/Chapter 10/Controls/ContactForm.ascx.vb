Imports System.IO ' Provides access to the File class for reading the file
Imports System.Net.Mail ' Provides access to the various mail related classes

Partial Class Controls_ContactForm
  Inherits System.Web.UI.UserControl

  Protected Sub CustomValidator1_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
    If Not String.IsNullOrEmpty(PhoneHome.Text) Or Not String.IsNullOrEmpty(PhoneBusiness.Text) Then
      args.IsValid = True
    Else
      args.IsValid = False
    End If
  End Sub

  Protected Sub SendButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SendButton.Click
    If Page.IsValid Then
      Dim fileName As String = Server.MapPath("~/App_Data/ContactForm.txt")
      Dim mailBody As String = File.ReadAllText(fileName)

      mailBody = mailBody.Replace("##Name##", Name.Text)
      mailBody = mailBody.Replace("##Email##", EmailAddress.Text)
      mailBody = mailBody.Replace("##HomePhone##", PhoneHome.Text)
      mailBody = mailBody.Replace("##BusinessPhone##", PhoneBusiness.Text)
      mailBody = mailBody.Replace("##Comments##", Comments.Text)

      Dim myMessage As MailMessage = New MailMessage()
      myMessage.Subject = "Response from web site"
      myMessage.Body = mailBody

      myMessage.From = New MailAddress("you@yourprovider.com", "Sender Name")
      myMessage.To.Add(New MailAddress("you@yourprovider.com", "Receiver Name"))

      Dim mySmtpClient As SmtpClient = New SmtpClient()
      mySmtpClient.Send(myMessage)

      Message.Visible = True
      FormTable.Visible = False
      System.Threading.Thread.Sleep(5000)
    End If
  End Sub

End Class
