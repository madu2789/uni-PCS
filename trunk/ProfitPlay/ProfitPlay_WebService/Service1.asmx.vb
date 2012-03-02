Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la siguiente línea.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Service1
    Inherits System.Web.Services.WebService
    Dim carta As New Carta
    Dim empleat As New Empleado

    <WebMethod()> _
  Public Function donamDades(ByVal a As Integer, ByVal b As Integer) As DataTable
        Return carta.donamDades
    End Function

    <WebMethod()> _
    Public Function MultiplicaNumeros(ByVal a As Integer, ByVal b As Integer) As Integer
        Return a * b
    End Function


    <WebMethod()> _
    Public Function LogEmpleat(ByVal user As String, ByVal password As String) As Boolean
        Return empleat.log_empleat(user, password)
    End Function

End Class