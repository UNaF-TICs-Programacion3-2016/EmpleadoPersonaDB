Imports System.Collections.Specialized
Imports Oracle.DataAccess.Client
Imports CapaEntidad

Public Class TablaDB

    Private _Conexion As New OracleConnection
    Protected _Cmd As OracleCommand
    Protected _Adapter As OracleDataAdapter

    Public Sub New()
        Conexion.ConnectionString = "Data Source=localhost;
                                        User Id = UNAF;
                                        Password = Unaf;"
    End Sub

    Public ReadOnly Property Conexion As OracleConnection
        Get
            Return _Conexion
        End Get
    End Property

    Protected Property Cmd() As OracleCommand
        Get
            Return _Cmd
        End Get
        Set(ByVal pCmd As OracleCommand)
            _Cmd = pCmd
        End Set
    End Property

    Protected Property Adapter() As OracleDataAdapter
        Get
            Return New OracleDataAdapter(Conexion.ConnectionString, Conexion)
        End Get
        Set(ByVal pAdapter As OracleDataAdapter)
            _Adapter = pAdapter
        End Set
    End Property

    Protected Function ObtenerRegistroConId(SelectString As String, Id As String) As DataRow
        Dim Tabla As New DataTable
        Try
            Cmd = New OracleCommand(SelectString, Conexion)
            Cmd.Parameters.Add(New OracleParameter(":ID", OracleDbType.Long) With {.Value = Id})
            Adapter = New OracleDataAdapter()
            Adapter.SelectCommand = Cmd
            Adapter.Fill(Tabla)
            If Tabla.Rows.Count Then
                Return Tabla.Rows(0)
            ElseIf Id < 0 Then
                Return Tabla.NewRow()
            Else
                Err.Raise(-5, , "Error al Recuperar el Registro " + vbCrLf +
                          SelectString)
            End If
        Catch Ex As Exception
            MsgBox(Ex.ToString)
        End Try
    End Function

    Protected Function ListarRegistros(SelectString As String) As DataTable

        Dim Tabla As New DataTable
        Try
            Cmd = New OracleCommand(SelectString, Conexion)
            Adapter = New OracleDataAdapter(Cmd)
            Adapter.Fill(Tabla)
            Return Tabla
        Catch Ex As Exception
            MsgBox(Ex.ToString)
        End Try

    End Function

End Class

Public Class TransaccionDB

    Private Transaction As OracleTransaction
    Private CommandList As List(Of OracleCommand)
    Private DataSetList As List(Of DataSet)
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

    Public Sub Aplicar(Optional Adapter As OracleDataAdapter)
        Try
            For Each Cmd In CommandList
                EstablecerValorDeRelas(Cmd)
                Cmd.ExecuteNonQuery()
                GuardarUltimoId(Cmd)
            Next
            For Each Ds In DataSetList
                Adapter.Update(Ds)
            Next
            Transaction.Commit()
        Catch ex As Exception
            Transaction.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub GuardarUltimoId(Comando As OracleCommand)
        Dim IdTabla As Integer
        Dim NombreTabla As String
        Dim Parametro As OracleParameter
        IdTabla = 0
        NombreTabla = ""
        With Comando
            For Each Parametro In .Parameters
                If Parametro.ParameterName = "Last_id" Then
                    IdTabla = Long.Parse(.Parameters("Last_id").Value.ToString)
                ElseIf Parametro.ParameterName Like "Id_*" Then
                    NombreTabla = Replace(Parametro.ParameterName, "Id_", "")
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
                If Parametro.ParameterName Like "Rela_*" And Parametro.value = 0 Then
                    NombreTabla = Replace(Parametro.ParameterName, "Rela_", "")
                    Parametro.value = Integer.Parse(TablasId.GetValues(NombreTabla).ToString)
                    Exit Sub
                End If
            Next
            If .Parameters.Contains("Rela_*") Then Err.Raise(515,, "No se encontro el Valor para el Rela")
        End With

    End Sub
End Class

Public Class PersonaDB
    Inherits TablaDB

    Private Persona As DataRow

    Public Sub New(pIdPersona As Integer)
        Persona = MyBase.ObtenerRegistroConId("Select * From Persona Where Id_Persona = :ID",
                                                pIdPersona.ToString)
    End Sub
    Public Sub Insertar(oPersona As PersonaEN)
        Dim Txn As New TransaccionDB
        Try
            ActualizarDataRow(oPersona)
            Txn.IniciarTransaccion(Conexion)
            Txn.Add(InsertCommand())
            Txn.Aplicar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Public Sub Actualizar(oPersona As PersonaEN)
        Dim Txn As New TransaccionDB
        Try
            ActualizarDataRow(oPersona)
            Txn.IniciarTransaccion(Conexion)
            Txn.Add(UpdateCommand())
            Txn.Aplicar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Public Sub Eliminar()
        Dim Txn As New TransaccionDB
        Try
            Txn.IniciarTransaccion(Conexion)
            Txn.Add(DeleteCommand())
            Txn.Aplicar()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub ActualizarDataRow(oPersona As PersonaEN)
        With oPersona
            Persona("Id_Persona") = .Id_Persona
            Persona("ApellidoyNombre") = .ApellidoyNombre
            Persona("Sexo") = .Sexo
            Persona("Dni") = .Dni
            Persona("Cuil") = .Cuil
            Persona("EstadoCivil") = .EstadoCivil
            Persona("FechaNacimiento") = .FechaNacimiento
        End With
    End Sub
    Private Function InsertCommand() As OracleCommand
        With Cmd
            .Parameters.Clear()
            .CommandText = "INSERT INTO PERSONA VALUES (:Id_Persona,:ApellidoyNombre,:Sexo,:Dni,:CUIL,:FechaNacimiento,:EstadoCivil)
                 RETURNING Id_Persona INTO :Last_id"
            .Parameters.Add(New OracleParameter(":Id_Persona", OracleDbType.Varchar2) With {.Value = Persona("Id_Persona")})
            .Parameters.Add(New OracleParameter(":ApellidoyNombre", OracleDbType.Varchar2) With {.Value = Persona("ApellidoyNombre")})
            .Parameters.Add(New OracleParameter(":Sexo", OracleDbType.Int32) With {.Value = Persona("Sexo")})
            .Parameters.Add(New OracleParameter(":Dni", OracleDbType.Varchar2) With {.Value = Persona("Dni")})
            .Parameters.Add(New OracleParameter(":CUIL", OracleDbType.Varchar2) With {.Value = Persona("CUIL")})
            .Parameters.Add(New OracleParameter(":FechaNacimiento", OracleDbType.Date) With {.Value = CType(Persona("FechaNacimiento"), Date)})
            .Parameters.Add(New OracleParameter(":EstadoCivil", OracleDbType.Int32) With {.Value = Persona("EstadoCivil")})
            .Parameters.Add(New OracleParameter(":Last_id", OracleDbType.Int32, ParameterDirection.ReturnValue))
            .Connection = Conexion
        End With
        Return Cmd
    End Function
    Private Function UpdateCommand() As OracleCommand
        With Cmd
            .Parameters.Clear()
            .CommandText = "UPDATE PERSONA SET 
                                ApellidoyNombre = :ApellidoyNombre
                                ,Sexo = :Sexo
                                ,Dni = :Dni
                                ,CUIL = :CUIL
                                ,FechaNacimiento = :FechaNacimiento
                                ,EstadoCivil = :EstadoCivil
                            WHERE Id_Persona = :Id_Persona"
            .Parameters.Add(New OracleParameter(":ApellidoyNombre", OracleDbType.Varchar2) With {.Value = Persona("ApellidoyNombre")})
            .Parameters.Add(New OracleParameter(":Sexo", OracleDbType.Int32) With {.Value = Persona("Sexo")})
            .Parameters.Add(New OracleParameter(":Dni", OracleDbType.Varchar2) With {.Value = Persona("Dni")})
            .Parameters.Add(New OracleParameter(":CUIL", OracleDbType.Varchar2) With {.Value = Persona("CUIL")})
            .Parameters.Add(New OracleParameter(":FechaNacimiento", OracleDbType.Date) With {.Value = CType(Persona("FechaNacimiento"), Date)})
            .Parameters.Add(New OracleParameter(":EstadoCivil", OracleDbType.Int32) With {.Value = Persona("EstadoCivil")})
            .Parameters.Add(New OracleParameter(":Id_Persona", OracleDbType.Varchar2) With {.Value = Persona("Id_Persona")})
            .Connection = Conexion
        End With
        Return Cmd
    End Function
    Private Function DeleteCommand() As OracleCommand
        With Cmd
            .Parameters.Clear()
            .CommandText = "DELETE FROM PERSONA
                                WHERE Id_Persona = :Id_Persona"
            .Parameters.Add(New OracleParameter(":Id_Persona", OracleDbType.Varchar2) With {.Value = Persona("Id_Persona")})
            .Connection = Conexion
        End With
        Return Cmd
    End Function
End Class

Public Class EmpleadoDB
    Inherits TablaDB

    Private Empleado As DataRow

    Public Sub New(pIdEmpleado)
        Empleado = MyBase.ObtenerRegistroConId("Select * From Persona Where Id_Persona = :ID", pIdPersona.ToString)
    End Sub

    Public Sub Insertar(oEmpleado As Empleado)
        With oEmpleado


        End With
    End Sub
End Class
