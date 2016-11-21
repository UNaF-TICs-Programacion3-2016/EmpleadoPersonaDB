Imports CapaDatos
Public Class Frm_Inicial_Personas

    Friend oPersona As ClasePersona
    Friend IdPersona As Integer
    Friend Accion As Tipo_Accion

    Private Sub AltaCmd_Click(sender As Object, e As EventArgs) Handles AltaCmd.Click
        IdPersona = -1
        Accion = Tipo_Accion.Alta
        Frm_Abm_Persona.ShowDialog()
    End Sub
    Private Sub ModificacionCmd_Click(sender As Object, e As EventArgs) Handles ModificacionCmd.Click, PersonasDGV.CellContentDoubleClick
        IdPersona = PersonasDGV.CurrentRow.Cells("Id_Persona").Value
        Accion = Tipo_Accion.Modificacion
        Frm_Abm_Persona.ShowDialog()
    End Sub

    Private Sub Frm_Inicial_Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oPersona = New ClasePersona(-1)
        CargarGrillaPersonas
    End Sub

    Private Sub BajaCmd_Click(sender As Object, e As EventArgs) Handles BajaCmd.Click
        IdPersona = PersonasDGV.CurrentRow.Cells("Id_Persona").Value
        Accion = Tipo_Accion.Baja
        Frm_Abm_Persona.ShowDialog()
    End Sub

    Friend Sub CargarGrillaPersonas()
        With PersonasDGV
            .DataSource = oPersona.ListarRegistros()
            .Columns("Id_Persona").Visible = False
            .Columns("Sexo").Visible = False
            .Columns("Sexo_Text").HeaderText = "Sexo"
            .Columns("EstadoCivil").Visible = False
            .Columns("EstadoCivil_Text").HeaderText = "Estado Civil"
            .Columns("ApellidoyNombre").HeaderText = "Apellido y Nombre"
            .Columns("FechaNacimiento").HeaderText = "Fecha de Nacimiento"
        End With
    End Sub

End Class