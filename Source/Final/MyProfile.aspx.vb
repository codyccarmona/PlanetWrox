﻿
Partial Class _MyProfile
  Inherits BasePage

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If Not Page.IsPostBack Then
      FirstName.Text = Profile.FirstName
      LastName.Text = Profile.LastName
      DateOfBirth.Text = Profile.DateOfBirth.ToShortDateString()
      Bio.Text = Profile.Bio
      
    End If
  End Sub

  Protected Sub SaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveButton.Click
    If Page.IsValid Then
      Profile.FirstName = FirstName.Text
      Profile.LastName = LastName.Text
      Profile.DateOfBirth = DateTime.Parse(DateOfBirth.Text)
      Profile.Bio = Bio.Text
      ' Clear the existing list
      Profile.FavoriteGenres.Clear()
      ' Now add the selected genres
      For Each myItem As ListItem In PreferenceList.Items
        If myItem.Selected Then
          Profile.FavoriteGenres.Add(Convert.ToInt32(myItem.Value))
        End If
      Next
    End If
  End Sub

  Protected Sub PreferenceList_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles PreferenceList.DataBound
    For Each myItem As ListItem In PreferenceList.Items
      Dim currentValue As Integer = Convert.ToInt32(myItem.Value)
      If Profile.FavoriteGenres.Contains(currentValue) Then
        myItem.Selected = True
      End If
    Next
  End Sub
End Class
