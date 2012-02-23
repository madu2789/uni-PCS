﻿Public Class ControlDB

    Dim conDB As OleDb.OleDbConnection

    'cadena de conexio del MADU
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Madu\Documents\pcs1112_g04\trunk\ProfitPlay\ProfitPlay_DB\profit_play.accdb;Persist Security Info=False"

    'tableadapters:
    Dim empleatDA As New ProvaDataSetTableAdapters.EmpleadoTableAdapter
    Dim alergiaDA As New ProvaDataSetTableAdapters.AlergiasTableAdapter
    Dim cartaDA As New ProvaDataSetTableAdapters.CartaTableAdapter
    Dim ingredientDA As New ProvaDataSetTableAdapters.IngredientesTableAdapter
    Dim taulaDA As New ProvaDataSetTableAdapters.MesaTableAdapter
    Dim comandaDA As New ProvaDataSetTableAdapters.PedidoTableAdapter
    Dim producteDA As New ProvaDataSetTableAdapters.ProductoTableAdapter
    Dim producte_ingredientDA As New ProvaDataSetTableAdapters.Producto_IngredienteTableAdapter

    'DataSet:
    Private DS As New ProvaDataSet()
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

    Public Function consulta_empleat(ByVal user As String, ByVal password As String) As Boolean
        Dim ok As Boolean = False
        Dim busca_user As String = ""
        Dim trobat_login As String = ""
        Dim trobat_password As String = ""

        'per probar
        connect()
        Try
            cmd = conDB.CreateCommand
            busca_user = "SELECT password FROM [Empleado] WHERE nom = '" & user & "';"
            cmd.CommandText = busca_user
            Dim cmdReader As System.Data.OleDb.OleDbDataReader = cmd.ExecuteReader()
            While cmdReader.Read()
                trobat_password = cmdReader(0)
            End While
            If trobat_password = password Then
                ok = True
            End If
        Catch ex As Exception
            MsgBox("error llegeix user", MsgBoxStyle.Critical)
        End Try
        disconnect()

        Return ok
    End Function

    Public Function GetProductes() As DataTable
        Try
            connect()
            producteDA.Connection = conDB
            producteDA.Fill(DS.Producto)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return DS.Producto
    End Function



End Class
