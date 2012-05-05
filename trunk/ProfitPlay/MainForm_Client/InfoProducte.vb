Imports System.Windows.Forms

Public Class info_producte

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If (nud_cantitat.Value <= 0) Then

            MsgBox("Selecciona una quantitat correcte", MsgBoxStyle.Exclamation, "ERROR EN LA QUANTITAT")

        Else

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Public Function getQuanitat() As Integer
        Return nud_cantitat.Value
    End Function

End Class
