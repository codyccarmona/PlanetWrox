Namespace Wrox.Samples
    Public Class Calculator
        ''' <summary>
        ''' Practice comments. This is too convenient
        ''' </summary>
        ''' <param name="a"> holds first number</param>
        ''' <param name="b">holds second number</param>
        ''' <returns>first num + sec num</returns>
        Public Function Add(ByVal a As Double, ByVal b As Double) As Double
            Return a + b
        End Function

        Public Function Subtract(ByVal a As Double, ByVal b As Double) As Double
            Return a - b
        End Function

        Public Function Multiply(ByVal a As Double, ByVal b As Double) As Double
            Return a * b
        End Function

        Public Function Divide(ByVal a As Double, ByVal b As Double) As Double
            Return a / b
        End Function

    End Class
End Namespace