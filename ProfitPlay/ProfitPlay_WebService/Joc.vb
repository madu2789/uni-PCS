Public Class Joc
    Dim BD As New ProfitPlay_DB.ControlDB

    Public pregunta As String
    Public correcta As String
    Public incorrecta As String

    Public Sub setPregunta(ByVal s As String)
        pregunta = s
    End Sub

    Public Sub setCorrecte(ByVal s As String)
        correcta = s
    End Sub

    Public Sub setIncorrecta(ByVal s As String)
        incorrecta = s
    End Sub

    Public Function getPregunta() As String
        Return pregunta
    End Function

    Public Function getCorrecta() As String
        Return correcta
    End Function

    Public Function getIncorrecta() As String
        Return incorrecta
    End Function

    Public Function getAllQuestions() As DataTable
        Return BD.getQuestions
    End Function

End Class
