Imports System.Collections.Specialized
Imports Oracle.DataAccess.Client

Public Class TransaccionDB

    Private Transaction As OracleTransaction
    Private CommandList As New List(Of OracleCommand)
    Private DataSetList As New List(Of DataSet)
    Private TablasId As New NameValueCollection()

    Public Sub IniciarTransaccion(Con As OracleConnection)
        Transaction = Con.BeginTransaction(IsolationLevel.ReadCommitted)
    End Sub

    Public Sub Add(Cmd As OracleCommand)
        Cmd.Transaction = Transaction
        CommandList.Add(Cmd)
    End Sub

    Public Sub Add(Ds As DataSet)
        DataSetList.Add(Ds)
    End Sub

    Public Sub Aplicar()
        For Each Cmd In CommandList
            EstablecerValorDeRelas(Cmd)
            Cmd.ExecuteNonQuery()
            GuardarUltimoId(Cmd)
        Next
        Transaction.Commit()
    End Sub
    Public Sub Aplicar(Adapter As OracleDataAdapter)
        For Each Ds In DataSetList
            Adapter.Update(Ds)
        Next
    End Sub
    Private Sub GuardarUltimoId(Comando As OracleCommand)
        Dim IdTabla As Integer
        Dim NombreTabla As String
        Dim Parametro As OracleParameter
        IdTabla = 0
        NombreTabla = ""
        With Comando
            For Each Parametro In .Parameters
                If UCase(Parametro.ParameterName) = UCase(":Last_id") Then
                    IdTabla = Integer.Parse(.Parameters(":Last_id").Value.ToString)
                ElseIf UCase(Parametro.ParameterName) Like ":ID_*" Then
                    NombreTabla = Replace(Parametro.ParameterName, ":Id_", "")
                    If IdTabla = 0 Then
                        IdTabla = Parametro.Value
                    End If
                End If
            Next
            TablasId.Add(NombreTabla, IdTabla)
        End With
    End Sub
    Private Sub EstablecerValorDeRelas(Comando As OracleCommand)
        Dim NombreTabla As String
        With Comando
            For Each Parametro In .Parameters
                If Parametro.ParameterName Like ":Rela_*" Then
                    If Parametro.value = 0 Then
                        NombreTabla = Replace(Parametro.ParameterName, ":Rela_", "")
                        Parametro.value = Integer.Parse(TablasId.GetValues(NombreTabla).ToString)
                        Exit Sub
                    End If
                End If
            Next
            If .Parameters.Contains(":Rela_*") Then Err.Raise(515,, "No se encontro el Valor para el Rela")
        End With

    End Sub
End Class

