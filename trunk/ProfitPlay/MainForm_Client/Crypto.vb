Public Class crypto

    Private _shiftCount As Integer

    Public Property ShiftCount() As Integer
        Get
            Return _shiftCount
        End Get
        Set(ByVal value As Integer)
            _shiftCount = value
        End Set
    End Property

    Public Sub New(ByVal shiftCount As Integer)
        Me.ShiftCount = shiftCount
    End Sub

    Public Function Encipher(ByVal plainText As String) As String

        Dim cipherText As String = String.Empty
        Dim cipherInChars(plainText.Length) As Char
        For i As Integer = 0 To plainText.Length - 1
            cipherInChars(i) = _
               Convert.ToChar((Convert.ToInt32(Convert.ToChar(plainText(i))) + Me.ShiftCount))
        Next
        cipherText = New String(cipherInChars)
        Return cipherText

    End Function


    Public Function Decipher(ByVal cipherText As String) As String
        Dim plainText As String = String.Empty
        Dim cipherInChars(cipherText.Length) As Char
        For i As Integer = 0 To cipherText.Length - 1
            cipherInChars(i) = _
               Convert.ToChar((Convert.ToInt32(Convert.ToChar(cipherText(i))) - Me.ShiftCount))
        Next
        plainText = New String(cipherInChars)
        Return plainText
    End Function

End Class