
Imports Oracle.DataAccess.Client

Public Class ClaseEmpleado
    Inherits ClasePersona
    Public Enum Tipo_Estado As Byte
        Activo
        Licencia
        Suspendido
        Baja
    End Enum
    Public Enum Tipo_Departamento As Byte
        Personal
        Contable
        Tesoreria
        Administracion
    End Enum
    Public Enum Tipo_Categoria As Byte
        Cadete
        Adminitrativo
        Ordenanza
        Profesional
        Gerente
        JefeDeDepartamento
        JefeDeArea
    End Enum

    Private Empleado As DataRow

    Public Property FechaIngreso() As Date
        Get
            Return IIf(IsDBNull(Empleado("FechaIngreso")), #01-01-1978#, Empleado("FechaIngreso"))
        End Get
        Set(ByVal pFechaIngreso As Date)
            Empleado("FechaIngreso") = pFechaIngreso
        End Set
    End Property
    Public Property Departamento() As Tipo_Departamento
        Get
            Return CType(IIf(IsDBNull(Empleado("Departamento")), 0, Empleado("Departamento")), Tipo_Departamento)
        End Get
        Set(ByVal pDepartamento As Tipo_Departamento)
            Empleado("Departamento") = pDepartamento
        End Set
    End Property
    Public Property Categoria() As Tipo_Categoria
        Get
            Return CType(IIf(IsDBNull(Empleado("Categoria")), 0, Empleado("Categoria")), Tipo_Categoria)
        End Get
        Set(ByVal pCategoria As Tipo_Categoria)
            Empleado("Categoria") = pCategoria
        End Set
    End Property
    Public Property Estado() As Tipo_Estado
        Get
            Return CType(IIf(IsDBNull(Empleado("Estado")), 0, Empleado("Estado")), Tipo_Estado)
        End Get
        Set(ByVal pEstado As Tipo_Estado)
            Empleado("Estado") = pEstado
        End Set
    End Property
    Public Property SueldoBruto() As Double
        Get
            Return IIf(IsDBNull(Empleado("SueldoBruto")), 0, Empleado("SueldoBruto"))
        End Get
        Set(ByVal pSueldoBruto As Double)
            Empleado("SueldoBruto") = pSueldoBruto
        End Set
    End Property
    Public Property Id_Empleado As Long
        Get
            Return Empleado("Id_Empleado")
        End Get
        Protected Set(pIdEmpleado As Long)
            Empleado("Id_Empleado") = pIdEmpleado.ToString
        End Set
    End Property
    Public Property Rela_Persona As Long
        Get
            Return Id_Persona
        End Get
        Set(pRelaPersona As Long)
            Id_Persona = pRelaPersona
        End Set
    End Property

    Public Sub New(Optional pRelaPersona As Integer = -1, Optional pIdEmpleado As Integer = -1)
        MyBase.New(pRelaPersona.ToString)
        Tabla = "Empleado"
        Vista = "EmpleadoVW"
        Empleado = ObtenerRegistroConId(pIdEmpleado.ToString)
        Id_Empleado = pIdEmpleado.ToString
    End Sub



    Protected Overrides Function InsertCommand() As OracleCommand
        With Cmd
            .Parameters.Clear()
            .CommandText = "INSERT INTO EMPLEADO VALUES 
                        (:Rela_Persona,:Id_Empleado
                        ,:FechaIngreso,:Departamento
                        ,:Categoria,:Estado,:SueldoBruto)
                   RETURNING Id_Empleado INTO :Last_id"
            .Parameters.Add(New OracleParameter(":Rela_Persona", OracleDbType.Int64) With {.Value = CInt(Rela_Persona)})
            .Parameters.Add(New OracleParameter(":Id_Empleado", OracleDbType.Int64) With {.Value = CInt(Id_Empleado)})
            .Parameters.Add(New OracleParameter(":FechaIngreso", OracleDbType.Date) With {.Value = FechaIngreso})
            .Parameters.Add(New OracleParameter(":Departamento", OracleDbType.Int16) With {.Value = Departamento})
            .Parameters.Add(New OracleParameter(":Categoria", OracleDbType.Int16) With {.Value = Categoria})
            .Parameters.Add(New OracleParameter(":Estado", OracleDbType.Int16) With {.Value = Estado})
            .Parameters.Add(New OracleParameter(":SueldoBruto", OracleDbType.Double) With {.Value = SueldoBruto})
            .Parameters.Add(New OracleParameter(":Last_id", OracleDbType.Int32, ParameterDirection.ReturnValue))
            .Connection = Conexion
        End With
        Return Cmd
    End Function
    Protected Overrides Function UpdateCommand() As OracleCommand
        With Cmd
            .Parameters.Clear()
            .CommandText = "UPDATE EMPLEADO SET 
                                Rela_Persona = :Rela_Persona                                
                               ,FechaIngreso = :FechaIngreso
                               ,Departamento = :Departamento
                               ,Categoria = :Categoria
                               ,Estado = :Estado
                               ,SueldoBruto = :SueldoBruto
                            WHERE Id_Empleado = :Id_Empleado"
            .Parameters.Add(New OracleParameter(":Rela_Persona", OracleDbType.Int64) With {.Value = CInt(Rela_Persona)})
            .Parameters.Add(New OracleParameter(":FechaIngreso", OracleDbType.Date) With {.Value = FechaIngreso})
            .Parameters.Add(New OracleParameter(":Departamento", OracleDbType.Int16) With {.Value = Departamento})
            .Parameters.Add(New OracleParameter(":Categoria", OracleDbType.Int16) With {.Value = Categoria})
            .Parameters.Add(New OracleParameter(":Estado", OracleDbType.Int16) With {.Value = Estado})
            .Parameters.Add(New OracleParameter(":SueldoBruto", OracleDbType.Double) With {.Value = SueldoBruto})
            .Parameters.Add(New OracleParameter(":Id_Empleado", OracleDbType.Int64) With {.Value = CInt(Id_Empleado)})
            .Connection = Conexion
        End With
        Return Cmd
    End Function
    Protected Overrides Function DeleteCommand() As OracleCommand

        With Cmd
            .Parameters.Clear()
            .CommandText = "DELETE FROM EMPLEADO
                                WHERE Id_Empleado = :Id_Empleado"
            .Parameters.Add(New OracleParameter(":Id_Empleado", OracleDbType.Int64) With {.Value = CInt(Id_Empleado)})
            .Connection = Conexion
        End With
        Return Cmd
    End Function

End Class

