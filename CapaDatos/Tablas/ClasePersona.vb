Imports Oracle.DataAccess.Client
Public Class ClasePersona
    Inherits ClaseTabla
    Public Enum Tipo_EstadoCivil As Byte
        Soltero = 0
        Casado = 1
    End Enum
    Public Enum Tipo_Sexo As Byte
        Femenino = 0
        Masculino = 1
    End Enum

    Private Persona As DataRow

    Public Property ApellidoyNombre() As String
        Get
            Return Persona("ApellidoyNombre").ToString
        End Get
        Set(ByVal pApellidoyNombre As String)
            Persona("ApellidoyNombre") = pApellidoyNombre
        End Set
    End Property
    Public Property Sexo() As Tipo_Sexo
        Get
            Return CType(IIf(IsDBNull(Persona("Sexo")), 0, Persona("Sexo")), Tipo_Sexo)
        End Get
        Set(ByVal pSexo As Tipo_Sexo)
            Persona("Sexo") = pSexo
        End Set
    End Property
    Public Property Dni() As String
        Get
            Return Persona("Dni").ToString
        End Get
        Set(ByVal pDni As String)
            Persona("Dni") = pDni
        End Set
    End Property
    Public Property Cuil() As String
        Get
            Return Persona("Cuil").ToString
        End Get
        Set(ByVal pCuil As String)
            Persona("Cuil") = pCuil
        End Set
    End Property
    Public Property FechaNacimiento() As Date
        Get
            Return IIf(IsDBNull(Persona("FechaNacimiento")), #01-01-1978#, Persona("FechaNacimiento"))
        End Get
        Set(ByVal pFechaNacimiento As Date)
            Persona("FechaNacimiento") = pFechaNacimiento
        End Set
    End Property
    Public Property EstadoCivil() As Tipo_EstadoCivil
        Get
            Return CType(Persona("EstadoCivil"), Tipo_EstadoCivil)
        End Get
        Set(ByVal pEstadoCivil As Tipo_EstadoCivil)
            Persona("EstadoCivil") = pEstadoCivil
        End Set
    End Property
    Public Property Id_Persona As String
        Get
            Return Persona("Id_Persona").ToString
        End Get
        Protected Set(pIdPersona As String)
            Persona("Id_Persona") = pIdPersona
        End Set
    End Property
    Public Sub New(pIdPersona As Integer)
        MyBase.Tabla = "Persona"
        MyBase.Vista = "PersonaVW"
        Persona = MyBase.ObtenerRegistroConId(pIdPersona.ToString)
        Id_Persona = pIdPersona.ToString
    End Sub

    Protected Overrides Function InsertCommand() As OracleCommand
        With Cmd
            .Parameters.Clear()
            .CommandText = "INSERT INTO PERSONA VALUES (:Id_Persona,:ApellidoyNombre,:Sexo,:Dni,:CUIL,:FechaNacimiento,:EstadoCivil)
                                RETURNING Id_Persona INTO :Last_id"
            .Parameters.Add(New OracleParameter(":Id_Persona", OracleDbType.Int64) With {.Value = CInt(Id_Persona)})
            .Parameters.Add(New OracleParameter(":ApellidoyNombre", OracleDbType.Varchar2) With {.Value = ApellidoyNombre})
            .Parameters.Add(New OracleParameter(":Sexo", OracleDbType.Int16) With {.Value = CInt(Sexo)})
            .Parameters.Add(New OracleParameter(":Dni", OracleDbType.Varchar2) With {.Value = Dni})
            .Parameters.Add(New OracleParameter(":CUIL", OracleDbType.Varchar2) With {.Value = Cuil})
            .Parameters.Add(New OracleParameter(":FechaNacimiento", OracleDbType.Date) With {.Value = FechaNacimiento})
            .Parameters.Add(New OracleParameter(":EstadoCivil", OracleDbType.Int16) With {.Value = CInt(EstadoCivil)})
            .Parameters.Add(New OracleParameter(":Last_id", OracleDbType.Int32, ParameterDirection.ReturnValue))
            .Connection = Conexion
        End With
        Return Cmd
    End Function
    Protected Overrides Function UpdateCommand() As OracleCommand
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
            .Parameters.Add(New OracleParameter(":ApellidoyNombre", OracleDbType.Varchar2) With {.Value = ApellidoyNombre})
            .Parameters.Add(New OracleParameter(":Sexo", OracleDbType.Int32) With {.Value = Sexo})
            .Parameters.Add(New OracleParameter(":Dni", OracleDbType.Varchar2) With {.Value = Dni})
            .Parameters.Add(New OracleParameter(":CUIL", OracleDbType.Varchar2) With {.Value = Cuil})
            .Parameters.Add(New OracleParameter(":FechaNacimiento", OracleDbType.Date) With {.Value = CType(FechaNacimiento, Date)})
            .Parameters.Add(New OracleParameter(":EstadoCivil", OracleDbType.Int32) With {.Value = EstadoCivil})
            .Parameters.Add(New OracleParameter(":Id_Persona", OracleDbType.Int64) With {.Value = CInt(Id_Persona)})
            .Connection = Conexion
        End With
        Return Cmd
    End Function
    Protected Overrides Function DeleteCommand() As OracleCommand
        With Cmd
            .Parameters.Clear()
            .CommandText = "DELETE FROM PERSONA
                                WHERE Id_Persona = :Id_Persona"
            .Parameters.Add(New OracleParameter(":Id_Persona", OracleDbType.Int64) With {.Value = CInt(Id_Persona)})
            .Connection = Conexion
        End With
        Return Cmd
    End Function
End Class

