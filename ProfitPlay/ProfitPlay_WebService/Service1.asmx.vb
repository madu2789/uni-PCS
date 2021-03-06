﻿Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Runtime.Serialization
Imports System.Collections.Generic


' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la siguiente línea.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service1

    Inherits System.Web.Services.WebService

    Dim empleat As New Empleat
    Dim usuari As New Usuari
    Dim comanda As New Comanda
    Dim producte As New Producte
    Dim ingredient As New Ingredient
    Dim plat As New Plat
    Dim compra As New Compra
    Dim joc As New Joc
    Dim taulapreus As New TaulaPreus

    Public em As New EmpleatBD

    Public Class UsuariBD
        Public Id_usuari As Integer
        Public Nom As String
        Public Punts As Integer
        Public Comensals As Integer
    End Class

    Public Class EmpleatBD
        Public id As Integer
        Public rol As String
        Public nom As String
        Public cognom As String
        Public username As String
        Public password As String
    End Class

    Public Class ProducteBD
        Public id As Integer
        Public tipus As String
        Public nom As String
        Public descripicio As String
        Public preu As Double
    End Class

    Public Class IngredientDB
        Public id As Integer
        Public preu As Double
        Public quantitat As Integer
        Public stock_minim As Integer
        Public stock_actual As Integer
        Public nom As String
    End Class

    Public Class ComandaDB
        Public id As Integer
        Public Id_usuari As Integer
        Public Id_producte As Integer
        Public Hora As String
        Public Notes As String
        Public Estat As String
    End Class

    Public Class PlatDB
        Public id_producte As Integer
        Public id_ingredient As Integer
        Public quantitat As Integer
    End Class

    Public Class TaulaPreusDB
        Public Id_producte As Integer
        Public EsPotPreparar As Integer
        Public PreuEstandard As Integer
        Public Interes As String
    End Class

    <WebMethod()> _
    Public Function LogEmpleat(ByVal user As String, ByVal password As String) As String
        Return empleat.log_empleat(user, password)
    End Function

    <WebMethod()> _
    Public Function deleteEmpleat(ByVal username As String) As Integer
        Return empleat.deleteEmpleat(username)
    End Function

    <WebMethod()> _
 Public Function ContaEmpleats() As Integer
        Return empleat.ContaEmpleats
    End Function

    <WebMethod()> _
   Public Function GetEmpleat(ByVal id As Integer) As EmpleatBD

        Dim idBD As Integer
        Dim info As DataTable = empleat.GetEmpleat(id)

        Dim empl As New EmpleatBD

        For Each fila In info.Rows

            idBD = CInt(fila("Id_empleat"))
            If id = idBD Then

                empl.id = fila("Id_empleat").ToString
                empl.rol = fila("Rol").ToString
                empl.nom = fila("Nom").ToString
                empl.cognom = fila("Cognom").ToString
                empl.username = fila("Username").ToString
                empl.password = fila("Password").ToString

            End If
        Next

        Return empl
    End Function

    <WebMethod()> _
   Public Function SetEmpleat(ByVal nom As String, ByVal cognom As String, ByVal username As String, ByVal password As String, ByVal rol As String) As Boolean
        Return empleat.SetEmpleat(nom, cognom, username, password, rol)
    End Function

    <WebMethod()> _
   Public Function getEmpleats() As List(Of Empleat)

        Dim dades As New List(Of Empleat)
        Dim info As DataTable = empleat.getEmpleats()
        For Each fila In info.Rows

            Dim empl As New Empleat

            empl.id = fila("Id_empleat").ToString
            empl.rol = fila("Rol").ToString
            empl.nom = fila("Nom").ToString
            empl.cognom = fila("Cognom").ToString
            empl.username = fila("Username").ToString
            empl.password = fila("Password").ToString
            dades.Add(empl)

        Next

        Return dades

    End Function

    <WebMethod()> _
       Public Function GetAllPlats() As List(Of PlatDB)

        Dim dades As New List(Of PlatDB)
        Dim info As DataTable = plat.ObtePlats()
        For Each fila In info.Rows

            Dim empl As New PlatDB

            empl.id_ingredient = fila("Id_ingredient").ToString
            empl.id_producte = (fila("Id_producte").ToString)
            empl.quantitat = fila("Quantitat").ToString
            dades.Add(empl)

        Next

        Return dades
    End Function

    <WebMethod()> _
        Public Function GetAllUsers() As List(Of UsuariBD)

        Dim users As New List(Of UsuariBD)
        Dim info As DataTable = usuari.getAllUsers

        For Each fila In info.Rows

            Dim pro As New UsuariBD
            pro.Id_usuari = fila("Id_usuari").ToString
            pro.nom = fila("Nom").ToString
            pro.Punts = fila("PuntsGuardats").ToString
            pro.Comensals = fila("Comensals").ToString
            users.Add(pro)

        Next

        Return users

    End Function

    <WebMethod()> _
        Public Function deleteUser(ByVal id As Integer) As Integer
        Return usuari.deleteUser(id)
    End Function

    <WebMethod()> _
        Public Function GetLastUserId() As Integer
        Return usuari.getLastUserId()
    End Function

    <WebMethod()> _
        Public Sub InsertNewUser(ByVal Nom As String, ByVal Punts As Integer, ByVal Comensals As Integer)
        usuari.InsertNewUser(Nom, Punts, Comensals)
    End Sub

    <WebMethod()> _
    Public Function ContaProductes() As Integer
        Return producte.ContaProductes
    End Function

    <WebMethod()> _
    Public Function GetNomProducteById(ByVal id_producte As Integer) As String
        Return producte.GetNomProducteById(id_producte)
    End Function

    <WebMethod()> _
   Public Function GetIdProducteByNom(ByVal Nom As String) As Integer
        Return producte.GetIdProducteByNom(Nom)
    End Function

    <WebMethod()> _
   Public Function GetPreuProducteById(ByVal id_producte As Integer) As Double
        Return producte.GetPreuProducteById(id_producte)
    End Function

    <WebMethod()> _
   Public Function GetAllProductes() As List(Of ProducteBD)

        Dim productes As New List(Of ProducteBD)
        Dim info As DataTable = producte.ObteProductes

        For Each fila In info.Rows

            Dim pro As New ProducteBD
            pro.id = fila("Id_producte").ToString
            pro.nom = fila("Nom").ToString
            pro.preu = fila("Preu").ToString
            pro.tipus = fila("Categoria").ToString
            pro.descripicio = fila("Descripcio").ToString

            productes.Add(pro)
        Next

        Return productes
    End Function

    <WebMethod()> _
   Public Function GetStockActualById(ByVal id As Integer) As Integer
        Return ingredient.getStockActualById(id)
    End Function

    <WebMethod()> _
   Public Sub UpdateStockActualById(ByVal id As Integer, ByVal s As Integer)
        ingredient.updateStockActualById(id, s)
    End Sub

    <WebMethod()> _
   Public Function GetNomIngredientById(ByVal id As Integer) As String
        Return ingredient.getNomIngredientById(id)
    End Function

    <WebMethod()> _
   Public Function GetIdIngredientByNom(ByVal nom As String) As Integer
        Return ingredient.getIdIngredientByNom(nom)
    End Function

    <WebMethod()> _
   Public Function GetIngredients() As List(Of IngredientDB)

        Dim ingredients As New List(Of IngredientDB)
        Dim info As DataTable = ingredient.ObteIngredients

        For Each fila In info.Rows

            Dim pro As New IngredientDB

            pro.id = fila("Id_ingredient").ToString
            pro.preu = fila("Preu").ToString
            pro.quantitat = fila("Quantitat").ToString
            pro.stock_minim = fila("StockMinim").ToString
            pro.nom = fila("Nom").ToString
            pro.stock_actual = fila("StockActual").ToString

            ingredients.Add(pro)
        Next

        Return ingredients
    End Function

    <WebMethod()> _
   Public Function GetAllComandes() As List(Of ComandaDB)

        Dim comandes As New List(Of ComandaDB)
        Dim info As DataTable = comanda.GetComanda

        For Each fila In info.Rows

            Dim pro As New ComandaDB

            pro.id = fila("Id_comanda").ToString
            pro.Id_usuari = fila("Id_usuari").ToString
            pro.Id_producte = fila("Id_producte").ToString
            pro.Hora = fila("Hora").ToString
            pro.Notes = fila("Notes").ToString
            pro.Estat = fila("Estat").ToString

            comandes.Add(pro)
        Next

        Return comandes
    End Function

    <WebMethod()> _
   Public Function GetComandaByUserId(ByVal id As Integer) As List(Of ComandaDB)

        Dim comandes As New List(Of ComandaDB)
        Dim info As DataTable = comanda.GetComandaByUserId(id)

        For Each fila In info.Rows

            Dim pro As New ComandaDB

            pro.id = fila("Id_comanda").ToString
            pro.Id_usuari = fila("Id_usuari").ToString
            pro.Id_producte = fila("Id_producte").ToString
            pro.Hora = fila("Hora").ToString
            pro.Notes = fila("Notes").ToString
            pro.Estat = fila("Estat").ToString

            comandes.Add(pro)
        Next

        Return comandes
    End Function

    <WebMethod()> _
    Public Function SetComanda(ByVal id_user As String, ByVal id_producte As String, ByVal estat As String, ByVal notes As String, ByVal hora As Date) As Boolean
        Return comanda.SetComanda(id_user, id_producte, estat, notes, hora)
    End Function

    <WebMethod()> _
   Public Function AnulaComanda(ByVal id_comanda As Integer) As Boolean
        Return comanda.AnulaComanda(id_comanda)
    End Function

    <WebMethod()> _
  Public Function SolPagarComanda(ByVal id_comanda As String) As Boolean
        Return comanda.SolPagarComanda(id_comanda)
    End Function

    <WebMethod()> _
    Public Function getUnaComandaByUserID(ByVal id_user As Integer, ByVal id_producte As Integer) As Integer
        Dim id As Integer = comanda.getUnaComandaByUserId(id_user, id_producte)
        Return id
    End Function

    <WebMethod()> _
  Public Function SolAnulaComanda(ByVal id_producte As Integer, ByVal id_user As Integer) As Boolean
        Return comanda.SolAnularComanda(id_producte, id_user)
    End Function

    <WebMethod()> _
    Public Function deleteComandaByUserId(ByVal id As Integer) As Integer
        Return comanda.AnulaComanda(id)
    End Function

    <WebMethod()> _
    Public Function insertCompra(ByVal id_i As Integer, ByVal q As Integer, ByVal e As String) As Integer
        Return compra.insertCompra(id_i, q, e)
    End Function

    <WebMethod()> _
    Public Function getCompres() As List(Of Compra)

        Dim dades As New List(Of Compra)
        Dim info As DataTable = compra.getCompres()
        For Each fila In info.Rows

            Dim empl As New Compra

            empl.Id_ingredient = fila("Id_ingredient").ToString
            empl.Estat = fila("Estat").ToString
            empl.Id_compra = fila("Id_compra").ToString
            empl.Quantitat = fila("Quantitat").ToString
            dades.Add(empl)

        Next

        Return dades
    End Function

    <WebMethod()> _
    Public Function SetProducte(ByVal nom As String, ByVal descripcio As String, ByVal preu As String, ByVal tipus As String) As Boolean
        Return producte.SetProducte(nom, descripcio, preu, tipus, descripcio)
    End Function

    <WebMethod()> _
    Public Function InsertRelacioProducteIngredient(ByVal idProducte As String, ByVal idIngredient As String) As Boolean
        Return producte.InsertRelacioProducteIngredient(idProducte, idIngredient)
    End Function

    <WebMethod()> _
   Public Function InsertIngredient(ByVal nom As String, ByVal preu As Integer, ByVal quantitat As Integer, ByVal stock As Integer, ByVal stockminim As Integer) As Boolean
        Return ingredient.SetIngredient(nom, preu, quantitat, stock, stockminim)
    End Function

    <WebMethod()> _
   Public Function getAllQuestions() As List(Of Joc)

        Dim dades As New List(Of Joc)
        Dim info As DataTable = joc.getAllQuestions

        For Each fila In info.Rows

            Dim empl As New Joc

            empl.pregunta = fila("Pregunta").ToString
            empl.correcta = fila("Correcta").ToString
            empl.incorrecta = fila("Incorrecta").ToString
            dades.Add(empl)

        Next
        Return dades

    End Function

    <WebMethod()> _
    Public Function UpdateInteresById(ByVal interes As String, ByVal id_producte As String) As Boolean
        Return taulapreus.UpdateInteresById(interes, id_producte)
    End Function

    <WebMethod()> _
    Public Sub InsertProducteTaulaPreus(ByVal IdProducte As String, ByVal Preu As Double)
        taulapreus.InsertProducteTaulaPreus(IdProducte, Preu)
    End Sub

    <WebMethod()> _
    Public Function UpdateStockTaulaPreus(ByVal id_producte As String, ByVal stock As String) As Boolean
        Return taulapreus.UpdateInteresById(stock, id_producte)
    End Function

    <WebMethod()> _
    Public Function UpdateEstatById(ByVal id_comanda As String, ByVal estat As String) As Boolean
        Return comanda.UpdateStockActualById(id_comanda, estat)
    End Function

    <WebMethod()> _
    Public Function GetTaulaPreus() As List(Of TaulaPreusDB)

        Dim dades As New List(Of TaulaPreusDB)
        Dim info As DataTable = taulapreus.GetTaulaPreus()

        For Each fila In info.Rows

            Dim taula As New TaulaPreusDB

            taula.Id_producte = fila("Id_producte").ToString
            taula.EsPotPreparar = fila("EsPotPreparar").ToString
            taula.PreuEstandard = fila("PreuEstandard").ToString
            taula.Interes = fila("Interes").ToString
            dades.Add(taula)

        Next
        Return dades

    End Function

End Class