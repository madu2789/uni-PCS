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
   Public Function GetEmpleat() As DataTable
        Return empleat.GetEmpleats
    End Function

    <WebMethod()> _
   Public Function SetEmpleat(ByVal nom As String, ByVal password As String, ByVal rol As String) As Boolean
        Return comanda.SetComanda(nom, password, rol)
    End Function


End Class