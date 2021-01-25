﻿
Partial Class Demos_CalculatorDemo
  Inherits BasePage

  Protected Sub CalculateButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
    If ValueBox1.Text.Length > 0 AndAlso ValueBox2.Text.Length > 0 Then
      Dim result As Double = 0
      Dim value1 As Double = Convert.ToDouble(ValueBox1.Text)
      Dim value2 As Double = Convert.ToDouble(ValueBox2.Text)
      Dim myCalculator As New Calculator()

      Trace.Write(String.Format("Performing the calculation with the {0} operator", OperatorList.SelectedValue))

      Select Case OperatorList.SelectedValue
        Case "+"
          result = myCalculator.Add(value1, value2)
        Case "-"
          result = myCalculator.Subtract(value1, value2)
        Case "*"
          result = myCalculator.Multiply(value1, value2)
        Case "/"
          result = myCalculator.Divide(value1, value2)
      End Select
      ResultLabel.Text = result.ToString()
    Else
      ResultLabel.Text = String.Empty
      Trace.Warn("Custom Category", "TextBox controls are empty; time to add Validation controls?")
    End If
  End Sub
End Class