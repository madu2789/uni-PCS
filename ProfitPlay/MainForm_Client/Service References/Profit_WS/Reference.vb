﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.5448
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace Profit_WS
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="Profit_WS.Service1Soap")>  _
    Public Interface Service1Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/MultiplicaNumeros", ReplyAction:="*")>  _
        Function MultiplicaNumeros(ByVal a As Integer, ByVal b As Integer) As Integer
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento a del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/LogEmpleat", ReplyAction:="*")>  _
        Function LogEmpleat(ByVal request As Profit_WS.LogEmpleatRequest) As Profit_WS.LogEmpleatResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class LogEmpleatRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="LogEmpleat", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Profit_WS.LogEmpleatRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Profit_WS.LogEmpleatRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class LogEmpleatRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public a As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public b As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal a As String, ByVal b As String)
            MyBase.New
            Me.a = a
            Me.b = b
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class LogEmpleatResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="LogEmpleatResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As Profit_WS.LogEmpleatResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As Profit_WS.LogEmpleatResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class LogEmpleatResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public LogEmpleatResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal LogEmpleatResult As Boolean)
            MyBase.New
            Me.LogEmpleatResult = LogEmpleatResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface Service1SoapChannel
        Inherits Profit_WS.Service1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class Service1SoapClient
        Inherits System.ServiceModel.ClientBase(Of Profit_WS.Service1Soap)
        Implements Profit_WS.Service1Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function MultiplicaNumeros(ByVal a As Integer, ByVal b As Integer) As Integer Implements Profit_WS.Service1Soap.MultiplicaNumeros
            Return MyBase.Channel.MultiplicaNumeros(a, b)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Profit_WS_Service1Soap_LogEmpleat(ByVal request As Profit_WS.LogEmpleatRequest) As Profit_WS.LogEmpleatResponse Implements Profit_WS.Service1Soap.LogEmpleat
            Return MyBase.Channel.LogEmpleat(request)
        End Function
        
        Public Function LogEmpleat(ByVal a As String, ByVal b As String) As Boolean
            Dim inValue As Profit_WS.LogEmpleatRequest = New Profit_WS.LogEmpleatRequest
            inValue.Body = New Profit_WS.LogEmpleatRequestBody
            inValue.Body.a = a
            inValue.Body.b = b
            Dim retVal As Profit_WS.LogEmpleatResponse = CType(Me,Profit_WS.Service1Soap).LogEmpleat(inValue)
            Return retVal.Body.LogEmpleatResult
        End Function
    End Class
End Namespace