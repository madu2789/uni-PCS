Public Class ControlDB

    Dim conDB As OleDb.OleDbConnection

    'cadena de conexio del MADU
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Madu\Documents\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"
    Dim conString1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\SVN\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"
    'tableadapters:
    Dim empleatDA As New profit_playDataSetTableAdapters.EmpleatTableAdapter
    Dim ingredientDA As New profit_playDataSetTableAdapters.IngredientTableAdapter
    Dim comandaDA As New profit_playDataSetTableAdapters.ComandaTableAdapter
    Dim producteDA As New profit_playDataSetTableAdapters.ProducteTableAdapter
    Dim producte_ingredientDA As New profit_playDataSetTableAdapters.Producte_IngredientTableAdapter

    'DataSet:
    Private DS As New profit_playDataSet()
    Private cmd As OleDb.OleDbCommand

    Public Sub connect()
        Try
            conDB = New OleDb.OleDbConnection(conString)
            'conDB = New OleDb.OleDbConnection(conString1)
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

            empleatDA.Connection = conDB
            empleatDA.ConsultaPassword(DS.Empleat, user)

        Catch ex As Exception
            MsgBox("error llegeix user", MsgBoxStyle.Critical)
        End Try
        disconnect()

        Return DS.Empleat
    End Function

    Public Function ContaEmpleats() As Integer
        Dim numUsuaris As Integer = 0
        Try
            connect()
            empleatDA.Connection = conDB
            numUsuaris = empleatDA.ContaEmpleats()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return numUsuaris
    End Function

    Public Function GetEmpleats() As DataTable
        Try
            connect()
            empleatDA.Connection = conDB
            empleatDA.Fill(DS.Empleat)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return DS.Empleat
    End Function

    Public Function SetEmpleat(ByVal nom As String, ByVal password As String, ByVal rol As String, ByVal cognom As String) As Boolean
        Dim ok As Boolean = False
        Try
            connect()
            empleatDA.Connection = conDB
            empleatDA.InsertEmpleat(rol, nom, nom, password, cognom)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Function ContaProductes() As Integer
        Dim numProductes As Integer = 0
        Try
            connect()
            producteDA.Connection = conDB
            numProductes = empleatDA.ContaEmpleats()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return numProductes
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

    Public Function getIngredients() As DataTable

        Try
            connect()
            ingredientDA.Connection = conDB
            ingredientDA.Fill(DS.Ingredient)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB ingredients", MsgBoxStyle.Critical)
        End Try
        Return DS.Ingredient

    End Function

    Public Function SetComanda(ByVal id_user As String, ByVal id_producte As String, ByVal notes As String, ByVal hora As Date) As Boolean

        Dim ok As Boolean = False
        Dim estat As String = "Sol·licitat"
        Try
            connect()
            comandaDA.Connection = conDB

            'revisar format de la query
            comandaDA.InsertComanda(CInt(id_user), CInt(id_producte), hora, notes, estat)
            ok = True
            disconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
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
            MsgBox("error DB comandes", MsgBoxStyle.Critical)
        End Try
        Return DS.Comanda
    End Function

End Class
