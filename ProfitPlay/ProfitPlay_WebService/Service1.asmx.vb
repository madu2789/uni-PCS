Imports System.Web.Services
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
    Dim comanda As New Comanda
    Dim producte As New Producte


    Public Class EmpleatBD
        Public id As Integer
        Public rol As String
        Public nom As String
        Public cognom As String
        Public username As String
        Public password As String
    End Class

    Public em As New EmpleatBD


    <WebMethod()> _
    Public Function LogEmpleat(ByVal user As String, ByVal password As String) As String
        Return empleat.log_empleat(user, password)
    End Function

    <WebMethod()> _
   Public Function GetProducte() As DataTable
        Return producte.GetProducte
    End Function

    <WebMethod()> _
   Public Function GetComanda() As DataTable
        Return comanda.GetComanda
    End Function

    <WebMethod()> _
    Public Function SetComanda(ByVal id_comanda As String, ByVal taula As String, ByVal producte As String) As Boolean
        Return comanda.SetComanda(id_comanda, taula, producte)
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
                ' MsgBox(fila("Id_empleat").ToString + fila("Rol").ToString + fila("Nom").ToString, MsgBoxStyle.Exclamation)

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
   Public Function SetEmpleat(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Return comanda.SetComanda(nom, password, rol)
    End Function


End Class