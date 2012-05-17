Public Class ControlDB

    Dim conDB As OleDb.OleDbConnection

    'cadena de conexio del MADU
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Madu\Documents\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

    'DarkWizard Torre
    Dim conString1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\SVN\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"
    'DarkWizard Portatil
    Dim conString2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DarkWizard\Documents\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

    'tableadapters:
    Dim empleatDA As New profit_playDataSetTableAdapters.EmpleatTableAdapter
    Dim usuariDA As New profit_playDataSetTableAdapters.UsuariTableAdapter
    Dim ingredientDA As New profit_playDataSetTableAdapters.IngredientTableAdapter
    Dim comandaDA As New profit_playDataSetTableAdapters.ComandaTableAdapter
    Dim producteDA As New profit_playDataSetTableAdapters.ProducteTableAdapter
    Dim compraDA As New profit_playDataSetTableAdapters.CompraTableAdapter
    Dim producte_ingredientDA As New profit_playDataSetTableAdapters.Producte_IngredientTableAdapter
    Dim jocDA As New profit_playDataSetTableAdapters.JocTableAdapter
    Dim taulapreusDA As New profit_playDataSetTableAdapters.TaulaPreusTableAdapter

    'DataSet:
    Private DS As New profit_playDataSet()
    Private cmd As OleDb.OleDbCommand

    Public Sub connect()
        Try

            conDB = New OleDb.OleDbConnection(conString2)
            conDB.Open()

        Catch ex As Exception

            MsgBox("Error en conectar-se a la BD", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try
    End Sub

    Public Sub disconnect()
        conDB.Close()
    End Sub

    Public Function getAllUsers() As DataTable

        Try
            connect()
            usuariDA.Connection = conDB
            usuariDA.Fill(DS.Usuari)
            disconnect()

        Catch ex As Exception

            MsgBox("Error recupetant els usuaris", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try

        Return DS.Usuari

    End Function

    Public Function deleteUser(ByVal id As Integer) As Integer

        Dim res As Integer = 0

        Try
            connect()
            usuariDA.Connection = conDB
            res = usuariDA.DeleteUser(id)
            disconnect()

        Catch ex As Exception

            MsgBox("Error agafant tots els usuaris", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try

        Return res

    End Function

    Public Function getLastUserId() As Integer

        Dim res As Integer = 1

        Try
            connect()
            usuariDA.Connection = conDB
            res = usuariDA.GetLastUserId()
            disconnect()

        Catch ex As Exception

            res = 1

        End Try

        Return res

    End Function

    Public Sub InsertNewUser(ByVal Nom As String, ByVal Punts As Integer, ByVal Comensals As Integer)

        Try

            connect()
            usuariDA.Connection = conDB
            usuariDA.InsertNewUser(Nom, Punts, Comensals)
            disconnect()

        Catch ex As Exception

            MsgBox("Error inserint usuari", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try
    End Sub

    Public Function ConsultaEmpleat(ByVal user As String) As DataTable

        Try
            connect()
            empleatDA.Connection = conDB
            empleatDA.ConsultaPassword(DS.Empleat, user)
            disconnect()

        Catch ex As Exception

            MsgBox("Error llegint el usuari", MsgBoxStyle.Critical, "Error Base de Dades")

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

            MsgBox("Error contant els empleats", MsgBoxStyle.Critical, "Error Base de Dades")

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

            MsgBox("Error recuperant els empleats", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try

        Return DS.Empleat

    End Function

    Public Function SetEmpleat(ByVal nom As String, ByVal cognom As String, ByVal username As String, ByVal password As String, ByVal rol As String) As Boolean

        Dim ok As Boolean = False
        Try

            connect()
            empleatDA.Connection = conDB
            empleatDA.InsertEmpleat(rol, nom, username, password, cognom)
            disconnect()
            ok = True

        Catch ex As Exception

            MsgBox("Error inserint empleats", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try

        Return ok

    End Function

    Public Function getIdEmpleatByUsername(ByVal username As String) As Integer

        Dim res As Integer = 0
        Try

            connect()
            empleatDA.Connection = conDB
            res = empleatDA.getIdEmpleatByUsername(username)
            disconnect()

        Catch ex As Exception

            MsgBox("Error traduint empleat", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try

        Return res

    End Function

    Public Function deleteEmpleat(ByVal id As Integer, ByVal username As String) As Integer

        Dim modif As Integer = 0

        Try
            connect()
            empleatDA.Connection = conDB
            modif = empleatDA.DeleteEmpleat(id, username)
            disconnect()
        Catch ex As Exception

            MsgBox("Error borrant empleat", MsgBoxStyle.Critical, "Error Base de Dades")

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

            MsgBox("Error contant productes", MsgBoxStyle.Critical, "Error Base de Dades")

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

            MsgBox("Error recuperant productes", MsgBoxStyle.Critical, "Error Base de Dades")

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
            MsgBox("Error recuperant ingredients", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error en guardar la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error recuperant la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error recuperant la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error borrant la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
        End Try
        Return ok
    End Function

    Public Function DeleteComandaByUserId(ByVal id As Integer) As Integer

        Dim res As Integer = 0
        Try
            connect()
            comandaDA.Connection = conDB
            res = comandaDA.DeleteComandaByUserId(id)
            disconnect()
        Catch ex As Exception
            MsgBox("Error eliminant totes les comandes", MsgBoxStyle.Critical, "Error Base de Dades")
        End Try

        Return res

    End Function

    Public Function SolAnulaComanda(ByVal id_comanda As Integer, ByVal id_usuari As Integer) As Boolean

        Dim ok As Boolean = False
        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.solAnularComandaByUserId("Sol.licitat per anular", id_comanda, id_usuari)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error en la sol·licitut d'anular la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error sol·licitut per pagar la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
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

            MsgBox("Error recuperant el preu del producte", MsgBoxStyle.Critical, "Error Base de Dades")

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
            MsgBox("Error recuperant el preu del producte", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error recuperant el id del ingredient pel nom", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error recuperant el nom del producte", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error recuperant el producte", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error recuperant el stock actual", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error actualitzant el stock", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error recuperant els plats", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error fent la compra", MsgBoxStyle.Critical, "Error Base de Dades")
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
            MsgBox("Error capturant les compres", MsgBoxStyle.Critical, "Error Base de Dades")
        End Try

        Return DS.Compra

    End Function

    Public Function SetProducte(ByVal nom As String, ByVal descripcio As String, ByVal preu As String, ByVal tipus As String) As Boolean

        Dim ok As Boolean = False

        Try
            connect()
            producteDA.Connection = conDB
            producteDA.InsertProducte(nom, preu, tipus)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error en guardar la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
        End Try

        Return ok
    End Function

    Public Function SetIngredientProducte(ByVal idProducte As String, ByVal idIngredient As String) As Boolean

        Dim ok As Boolean = False

        Try
            connect()
            producte_ingredientDA.Connection = conDB
            producte_ingredientDA.InsertProducteIngredient(idProducte, idIngredient, "")
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error en guardar la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
        End Try

        Return ok
    End Function

    Public Function SetIngredient(ByVal nom As String, ByVal preu As String, ByVal quantitat As String, ByVal stock As String, ByVal stockminim As String) As Boolean

        Dim ok As Boolean = False

        Try
            connect()
            ingredientDA.Connection = conDB
            ingredientDA.InsertIngredient(nom, preu, quantitat, stock, stockminim)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error en guardar la comanda", MsgBoxStyle.Critical, "Error Base de Dades")
        End Try

        Return ok
    End Function

    Public Function getQuestions() As DataTable

        Try
            connect()
            jocDA.Connection = conDB
            jocDA.Fill(DS.Joc)
            disconnect()

        Catch ex As Exception

            MsgBox("Error recupetant els questions", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try

        Return DS.Joc

    End Function

    Public Function UpdateInteresTaulaById(ByVal interes As String, ByVal id_producte As String) As Boolean
        Dim ok As Boolean = False

        Try
            connect()
            taulapreusDA.Connection = conDB
            taulapreusDA.UpdateInteres(interes, id_producte)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error update interes", MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Function UpdateStockTaulaPreus(ByVal id_producte As String, ByVal stock As String) As Boolean
        Dim ok As Boolean = False

        Try
            connect()
            taulapreusDA.Connection = conDB
            taulapreusDA.UpdateEsPotPreparar(stock, id_producte)
            disconnect()
            ok = True
        Catch ex As Exception
            MsgBox("Error update interes", MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Sub InsertProducteTaulaPreus(ByVal IdProducte As String, ByVal Preu As Double)

        Try

            connect()
            taulapreusDA.Connection = conDB
            taulapreusDA.InsertProducteTaulaPreus(IdProducte, "1", Preu, "3")
            disconnect()

        Catch ex As Exception

            MsgBox("Error inserint producte a taula preus", MsgBoxStyle.Critical, "Error Base de Dades")

        End Try
    End Sub

    Public Function GetTaulaPreus() As DataTable

        Try
            connect()
            taulapreusDA.Connection = conDB
            taulapreusDA.Fill(DS.TaulaPreus)
            disconnect()
        Catch ex As Exception
            MsgBox("Error recuperant taulapreus", MsgBoxStyle.Critical, "Error Base de Dades")
        End Try
        Return DS._Producte_Ingredient
    End Function



End Class
