Public Class ControlDB

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

    Public Function consulta_empleat(ByVal user As String) As String()

        Dim trobat(2) As String

        Try
            connect()

            'no mo reconeix al DS
            empleatDA.Connection = conDB
            Dim empleat As String = empleatDA.ComprovaPassword(user)

        Catch ex As Exception
            MsgBox("error llegeix user", MsgBoxStyle.Critical)
        End Try
        disconnect()

        Return trobat
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

    Public Function GetCarta() As DataTable
        Try
            connect()
            cartaDA.Connection = conDB
            cartaDA.Fill(DS.Carta)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return DS.Carta
    End Function

    Public Function SetComanda(ByVal id_comanda As String, ByVal id_taula As String, ByVal productes As ArrayList) As Boolean
        Dim ok As Boolean = False
        Try
            connect()
            comandaDA.Connection = conDB

            'revisar format de la query

            Dim estat As String = ""
            Dim notes As String = ""
            Dim hora As String = ""
            Dim producte As String = productes.Item(1)

            For Each producte In productes
                comandaDA.InsertComanda(estat, id_taula, producte, notes, hora)
            Next

            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return ok
    End Function

    Public Function GetComanda() As DataTable
        Try
            connect()
            comandaDA.Connection = conDB
            comandaDA.Fill(DS.Pedido)
            disconnect()
        Catch ex As Exception
            MsgBox("error DB", MsgBoxStyle.Critical)
        End Try
        Return DS.Carta
    End Function

End Class
