Public Class Mainform_client

    Public Shared nom_taula As String
    Public Shared punts_taula As String

    Public Sub New(ByVal nom As String, ByVal punts As String)
        InitializeComponent()
        lbl_taula.Text = nom + ": " + Id_usuari.ToString
        lbl_punts.Text = lbl_punts.Text + punts
        nom_taula = nom
        punts_taula = punts
    End Sub

    Private Sub Mainform_client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btn_menu_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_menu_anular.Click
        Client_Anula.Show()
        Me.Hide()
    End Sub

    Private Sub btn_estat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estat.Click
        Client_Pago.Show()
        Me.Hide()
    End Sub

    Private Sub btn_veurecarta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_veurecarta.Click
        Client_Carta.Show()
        Me.Hide()
    End Sub

    Private Sub btn_jugar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jugar.Click
        Client_Juego.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Pagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Pagar.Click
        Client_Pago.Show()
        Me.Hide()
    End Sub

    Public Function GetNom() As String
        Return nom_taula
    End Function

    Public Function GetPunts() As String
        Return punts_taula
    End Function


    Private Sub lbl_taula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_taula.Click

    End Sub
End Class