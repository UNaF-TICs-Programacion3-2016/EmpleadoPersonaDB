Imports Oracle.DataAccess.Client

Public MustInherit Class ClaseTabla

    Private _Conexion As New OracleConnection
    Protected _Cmd As OracleCommand
    Protected _Adapter As OracleDataAdapter
    Protected _Tabla As String
    Protected _Vista As String

    Public Sub New()
        Conexion.ConnectionString = "Data Source=localhost;
                                        User Id = UNAF;
                                        Password = Unaf;"
        _Adapter = New OracleDataAdapter()
    End Sub

    Public ReadOnly Property Conexion As OracleConnection
        Get
            Return _Conexion
        End Get
    End Property

    Public Property Tabla() As String
        Get
            Return _Tabla
        End Get
        Set(ByVal pTabla As String)
            _Tabla = pTabla
        End Set
    End Property

    Protected Property Vista() As String
        Get
            Return _Vista
        End Get
        Set(ByVal pTabla As String)
            _Vista = pTabla
        End Set
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
            Return _Adapter
        End Get
        Set(ByVal pAdapter As OracleDataAdapter)
            _Adapter = pAdapter
        End Set
    End Property

    Public Function ObtenerRegistroConId(Id As String) As DataRow
        Dim TablaDT As New DataTable
        Dim SelectString As String
        SelectString = "Select * From " + Tabla + " Where Id_" + Tabla +
            " = " + Id
        Try
            Cmd = New OracleCommand(SelectString, Conexion)
            Adapter.SelectCommand = Cmd
            Adapter.Fill(TablaDT)
            If TablaDT.Rows.Count Then
                Return TablaDT.Rows(0)
            ElseIf Id < 0 Then
                Return TablaDT.NewRow()
            Else
                Err.Raise(-5, , "Error al Recuperar el Registro " + vbCrLf +
                          SelectString)
            End If
        Catch Ex As Exception
            MsgBox(Ex.ToString + vbCrLf +
                   SelectString)
        End Try
    End Function

    Public Function ListarRegistros(Optional Filtro As String = "") As DataTable
        Dim TablaDT As New DataTable
        Dim SelectString As String = "Select * From " + Vista
        If Filtro <> "" Then
            SelectString = SelectString + " Where " + Filtro
        End If
        Try
            Cmd = New OracleCommand(SelectString, Conexion)
            Adapter = New OracleDataAdapter(Cmd)
            Adapter.Fill(TablaDT)
            Return TablaDT
        Catch Ex As Exception
            MsgBox(Ex.ToString)
        End Try

    End Function

    Public Function Insertar() As Boolean
        Dim Txn As New TransaccionDB
        Insertar = False
        Try
            Conexion.Open()
            Txn.IniciarTransaccion(Conexion)
            Txn.Add(InsertCommand())
            Txn.Aplicar()
            Insertar = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function
    Public Function Actualizar() As Boolean
        Dim Txn As New TransaccionDB
        Actualizar = False
        Try
            Conexion.Open()
            Txn.IniciarTransaccion(Conexion)
            Txn.Add(UpdateCommand())
            Txn.Aplicar()
            Actualizar = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function
    Public Function Eliminar() As Boolean
        Dim Txn As New TransaccionDB
        Eliminar = False
        Try
            Conexion.Open()
            Txn.IniciarTransaccion(Conexion)
            Txn.Add(DeleteCommand())
            Txn.Aplicar()
            Eliminar = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            Conexion.Close()
        End Try
    End Function

    Protected MustOverride Function InsertCommand() As OracleCommand
    Protected MustOverride Function UpdateCommand() As OracleCommand
    Protected MustOverride Function DeleteCommand() As OracleCommand

End Class

