﻿Public Class ControlDB

    Dim conDB As OleDb.OleDbConnection

    'cadena de conexio del MADU
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Madu\Documents\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

    'DarkWizard Torre
    Dim conString1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\SVN\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"
    'DarkWizard Portatil
    Dim conString2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\darkwizard\Documents\Visual Studio 2008\Projects\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

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

            conDB = New OleDb.OleDbConnection(conString2)
            conDB.Open()

        Catch ex As Exception

            MsgBox("Error en conectar-se a la BD", MsgBoxStyle.Critical)

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
            disconnect()

        Catch ex As Exception

            MsgBox("Error llegeix usuari", MsgBoxStyle.Critical)

        End Try

        Return DS.Empleat

    End Function

    Public Function ContaEmpleats() As Integer

        Dim numUsuaris As Integer = 0

        Try

            connect()
            empleatDA.Connection = conDB
            numUsuaris = empleatDA.ContaEmpleats()
            disconnect()

        Catch ex As Exception

            MsgBox("Error conta empleats", MsgBoxStyle.Critical)

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

            MsgBox("Error get empleats", MsgBoxStyle.Critical)

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

            MsgBox("Set Empleat", MsgBoxStyle.Critical)

        End Try

        Return ok

    End Function

    Public Function ContaProductes() As Integer

        Dim numProductes As Integer = 0
        Try

            connect()
            producteDA.Connection = conDB
            numProductes = empleatDA.ContaEmpleats()
            disconnect()

        Catch ex As Exception

            MsgBox("Error conta productes", MsgBoxStyle.Critical)

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

            MsgBox("Error get productes", MsgBoxStyle.Critical)

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
            MsgBox("Error get ingredients", MsgBoxStyle.Critical)
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
            MsgBox("Error get comanda", MsgBoxStyle.Critical)
        End Try
        Return DS.Comanda
    End Function

    Public Function GetPreuProducteById(ByVal id_producte As Integer) As Double

        Dim preu As Double = 0

        Try

            connect()
            producteDA.Connection = conDB
            preu = producteDA.GetPreuProducteById(id_producte)
            disconnect()

        Catch ex As Exception

            MsgBox("Error get preu producte", MsgBoxStyle.Critical)

        End Try

        Return preu

    End Function

    Public Function GetNomIngredientById(ByVal id_ingredient As Integer) As String

        Dim Nom As String = "NULL"

        Try
            connect()
            ingredientDA.Connection = conDB
            Nom = ingredientDA.GetNomIngredientById(id_ingredient)
            disconnect()
        Catch ex As Exception
            MsgBox("Error get preu producte", MsgBoxStyle.Critical)
        End Try

        Return Nom

    End Function

    Public Function GetIdIngredientByNom(ByVal Nom As String) As Integer

        Dim Id As Integer = 0

        Try
            connect()
            ingredientDA.Connection = conDB
            Id = ingredientDA.GetIdIngredientByNom(Nom)
            disconnect()
        Catch ex As Exception
            MsgBox("Error get preu producte", MsgBoxStyle.Critical)
        End Try

        Return Id

    End Function

    Public Function GetNomProducteByID(ByVal id_producte As Integer) As String

        Dim Nom As String = "NULL"

        Try
            connect()
            producteDA.Connection = conDB
            Nom = producteDA.GetNomProducteById(id_producte)
            disconnect()
        Catch ex As Exception
            MsgBox("Error get nom producte", MsgBoxStyle.Critical)
        End Try

        Return Nom

    End Function

    Public Function GetIDProducteByNom(ByVal Nom As String) As Integer

        Dim Id As Integer = 0

        Try
            connect()
            producteDA.Connection = conDB
            Id = producteDA.GetIDProducteByNom(Nom)
            disconnect()
        Catch ex As Exception
            MsgBox("Error get Producte", MsgBoxStyle.Critical)
        End Try

        Return Id

    End Function

    Public Function GetStockActualById(ByVal id As Integer) As Integer

        Dim stock As Integer = 0

        Try
            connect()
            ingredientDA.Connection = conDB
            stock = ingredientDA.GetStockActualById(id)
            disconnect()
        Catch ex As Exception
            MsgBox("Error get stock actual", MsgBoxStyle.Critical)
        End Try

        Return stock

    End Function

    Public Function UpdateStockActualById(ByVal id As Integer, ByVal stock As Integer)

        Try
            connect()
            ingredientDA.Connection = conDB
            stock = ingredientDA.UpdateStockById(stock, id)
            disconnect()
        Catch ex As Exception
            MsgBox("Error Update Stock", MsgBoxStyle.Critical)
        End Try

        Return stock

    End Function

End Class
