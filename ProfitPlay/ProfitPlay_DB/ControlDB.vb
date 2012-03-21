Public Class ControlDB

    Dim conDB As OleDb.OleDbConnection

    'cadena de conexio del MADU
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Madu\Documents\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

    'tableadapters:
    Dim empleatDA As New profit_playDataSetTableAdapters.ComandaTableAdapter
    Dim ingredientDA As New profit_playDataSetTableAdapters.IngredientTableAdapter
    Dim usuariDA As New profit_playDataSetTableAdapters.UsuariTableAdapter
    Dim comandaDA As New profit_playDataSetTableAdapters.ComandaTableAdapter
    Dim producteDA As New profit_playDataSetTableAdapters.ProducteTableAdapter
    Dim producte_ingredientDA As New profit_playDataSetTableAdapters.Producte_IngredientTableAdapter

    'DataSet:
    Private DS As New profit_playDataSet()
    Private cmd As OleDb.OleDbCommand

    Public Sub connect()
        Try
            conDB = New OleDb.OleDbConnection(conString)
            conDB.Open()
        Catch ex As Exception
            MsgBox("error connexió!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub disconnect()
        conDB.Close()
    End Sub

    Public Function consulta_empleat(ByVal user As String) As DataTable
        Try
            connect()

            'no mo reconeix al DS
            empleatDA.Connection = conDB
            ' empleatDA.ComprovaPassword(DS.Empleado, user)

        Catch ex As Exception
            MsgBox("error llegeix user", MsgBoxStyle.Critical)
        End Try
        disconnect()

        Return DS.Empleat
    End Function

    Public Function GetEmpleats() As DataTable
        Try
            connect()
            empleatDA.Connection = conDB
            ' empleatDA.Fill(DS.Empleat)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return DS.Empleat
    End Function

    Public Function SetEmpleat(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Dim ok As Boolean = False
        Try
            connect()
            comandaDA.Connection = conDB

            'empleatDA.InsertEmpleado(nom, password, rol)
            disconnect()

        Catch ex As Exception
            MsgBox("error DB empleat", MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Function GetProductes() As DataTable
        Try
            connect()
            producteDA.Connection = conDB
            producteDA.Fill(DS.Producte)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB productes", MsgBoxStyle.Critical)
        End Try
        Return DS.Producte
    End Function

    Public Function SetComanda(ByVal id_comanda As String, ByVal id_taula As String, ByVal productes As String) As Boolean
        Dim ok As Boolean = False
        Try
            connect()
            comandaDA.Connection = conDB

            'revisar format de la query

            Dim estat As String = ""
            Dim notes As String = ""
            Dim hora As String = ""
            Dim producte As String = ""

            For Each producte In productes
                ' comandaDA.InsertComanda(estat, id_taula, producte, notes, hora)
            Next

            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Function GetComanda() As DataTable
        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.Fill(DS.Comanda)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return DS.Comanda
    End Function

End Class
