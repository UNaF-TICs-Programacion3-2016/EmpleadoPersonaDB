
Public Class PersonaEN
    Public Enum Tipo_EstadoCivil As Byte
        Soltero = 0
        Casado = 1
    End Enum
    Public Enum Tipo_Sexo As Byte
        Femenino = 0
        Masculino = 1
    End Enum

    Private _Id_Persona As Long
    Private _ApellidoyNombre As String
    Private _Sexo As Tipo_Sexo
    Private _Dni As String
    Private _Cuil As String
    Private _FechaNacimiento As Date
    Private _EstadoCivil As Tipo_EstadoCivil

    Public Property ApellidoyNombre() As String
        Get
            Return _ApellidoyNombre
        End Get
        Set(ByVal pApellidoyNombre As String)
            _ApellidoyNombre = pApellidoyNombre
        End Set
    End Property
    Public Property Sexo() As Tipo_Sexo
        Get
            Return _Sexo
        End Get
        Set(ByVal pSexo As Tipo_Sexo)
            _Sexo = pSexo
        End Set
    End Property
    Public Property Dni() As String
        Get
            Return _Dni
        End Get
        Set(ByVal pDni As String)
            _Dni = pDni
        End Set
    End Property
    Public Property Cuil() As String
        Get
            Return _Cuil
        End Get
        Set(ByVal pCuil As String)
            _Cuil = pCuil
        End Set
    End Property
    Public Property FechaNacimiento() As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal pFechaNacimiento As Date)
            _FechaNacimiento = pFechaNacimiento
        End Set
    End Property
    Public Property EstadoCivil() As Tipo_EstadoCivil
        Get
            Return _EstadoCivil
        End Get
        Set(ByVal pEstadoCivil As Tipo_EstadoCivil)
            _EstadoCivil = pEstadoCivil
        End Set
    End Property
    Public Property Id_Persona As Long
        Get
            Return _Id_Persona
        End Get
        Protected Set(pIdPersona As Long)
            _Id_Persona = pIdPersona
        End Set
    End Property
    Public Sub New(PersonaRow As DataRow)
        Try
            Id_Persona = PersonaRow("Id_Persona")
            ApellidoyNombre = PersonaRow("ApellidoyNombre")
            Sexo = CType(PersonaRow("Sexo"), Tipo_Sexo)
            Dni = PersonaRow("DNI")
            Cuil = PersonaRow("CUIL")
            FechaNacimiento = PersonaRow("FechaNacimiento")
            EstadoCivil = CType(PersonaRow("EstadoCivil"), Tipo_EstadoCivil)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Insertar()
        Dim oPersonaDB As personadb
    End Sub

End Class
