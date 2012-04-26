Public Class ControlDB

    Dim conDB As OleDb.OleDbConnection

    'cadena de conexio del MADU
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Madu\Documents\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

    'DarkWizard Torre
    Dim conString1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\SVN\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"
    'DarkWizard Portatil
    Dim conString2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\darkwizard\Documents\Visual Studio 2008\Projects\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

    'tableadapters:
    Dim empleatDA As New profit_playDataSetTableAdapters.EmpleatTableAdapter
    Dim usuariDA As New profit_playDataSetTableAdapters.UsuariTableAdapter
    Dim ingredientDA As New profit_playDataSetTableAdapters.IngredientTableAdapter
    Dim comandaDA As New profit_playDataSetTableAdapters.ComandaTableAdapter
    Dim producteDA As New profit_playDataSetTableAdapters.ProducteTableAdapter
    Dim compraDA As New profit_playDataSetTableAdapters.CompraTableAdapter
    Dim producte_ingredientDA As New profit_playDataSetTableAdapters.Producte_IngredientTableAdapter

    'DataSet:
    Private DS As New profit_playDataSet()
    Private cmd As OleDb.OleDbCommand

    Public Sub connect()
        Try

            conDB = New OleDb.OleDbConnection(conString1)
            conDB.Open()

        Catch ex As Exception

            MsgBox("Error en conectar-se a la BD", MsgBoxStyle.Critical)

        End Try
    End Sub

    Public Sub disconnect()
        conDB.Close()
    End Sub

    Public Function getLastUserId() As Integer

        Dim res As Integer = 0

        Try
            connect()
            usuariDA.Connection = conDB
            res = usuariDA.GetLastUserId()
            disconnect()

        Catch ex As Exception

            MsgBox("Error agafant ultima ID", MsgBoxStyle.Critical)

        End Try

        Return res
    End Function

    Public Sub InsertNewUser(ByVal Nom As String, ByVal Punts As Integer)

        Try

            connect()
            usuariDA.Connection = conDB
            usuariDA.InsertNewUser(Nom, Punts)
            disconnect()

        Catch ex As Exception

            MsgBox("Error insereix usuari", MsgBoxStyle.Critical)
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Function ConsultaEmpleat(ByVal user As String) As DataTable

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

    Public Function deleteEmpleat(ByVal Nom As String, ByVal Sur As String) As Integer

        MsgBox("Nom " + Nom + " Cognom " + Sur)
        Dim modif As Integer = -1

        Try

            connect()
            empleatDA.Connection = conDB
            If (Sur = "") Then
                modif = empleatDA.DeleteEmpleat(Nom, "")
            Else
                modif = empleatDA.DeleteEmpleat(Nom, Sur)
            End If

            disconnect()

        Catch ex As Exception

            MsgBox("Error delete empleat", MsgBoxStyle.Critical)

        End Try

        Return modif

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

    Public Function SetComanda(ByVal id_user As Integer, ByVal id_producte As Integer, ByVal estat As String, ByVal notes As String, ByVal hora As Date) As Boolean

        Dim ok As Boolean = False

        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.InsertComanda(id_user, id_producte, hora, notes, estat)
            disconnect()
            ok = True
        Catch ex As Exception
            ' MsgBox("Error en guardar la comanda", MsgBoxStyle.Critical)
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

    Public Function GetComandaByUserId(ByVal id As Integer) As DataTable
        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.FillComandaByUserId(DS.Comanda, id)
            disconnect()
        Catch ex As Exception
            MsgBox("Error get comanda", MsgBoxStyle.Critical)
        End Try
        Return DS.Comanda
    End Function

    Public Function DeleteComanda(ByVal id_comanda As String) As Boolean
        Dim ok As Boolean = False

        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.DeleteComanda(id_comanda)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error delete comanda", MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Sub DeleteComandaByUserId(ByVal id As Integer)

        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.DeleteComandaByUserId(id)
            disconnect()
        Catch ex As Exception
            MsgBox("Error eliminar totes comandes", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function SolAnulaComanda(ByVal id_comanda As String) As Boolean

        Dim ok As Boolean = False
        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.UpdateEstat("Sol·licitat per anular", id_comanda)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error sol·licitut anular comanda", MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Function SolPagarComanda(ByVal id_comanda As String) As Boolean

        Dim ok As Boolean = False
        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.UpdateEstat("Sol·licitat per pagar", id_comanda)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error sol·licitut pagar comanda", MsgBoxStyle.Critical)
        End Try
        Return ok
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
            MsgBox("Error Id Ingredient By nom", MsgBoxStyle.Critical)
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

    Public Function GetPlats() As DataTable

        Try
            connect()
            producte_ingredientDA.Connection = conDB
            producte_ingredientDA.Fill(DS._Producte_Ingredient)
            disconnect()
        Catch ex As Exception
            MsgBox("Error get plats", MsgBoxStyle.Critical)
        End Try
        Return DS._Producte_Ingredient
    End Function

    Public Function insertCompra(ByVal id_i As Integer, ByVal q As Integer, ByVal e As String) As Integer

        Dim res As Integer = 0

        Try
            connect()
            compraDA.Connection = conDB
            res = compraDA.Insert(id_i, q, e)
            disconnect()
        Catch ex As Exception
            MsgBox("Error fent la compra", MsgBoxStyle.Critical)
        End Try
        Return res
    End Function

    Public Function getCompres() As DataTable
        Try
            connect()
            compraDA.Connection = conDB
            compraDA.Fill(DS.Compra)
            disconnect()
        Catch ex As Exception
            MsgBox("Error capturant les compres", MsgBoxStyle.Critical)
        End Try

        Return DS.Compra

    End Function
End Class
