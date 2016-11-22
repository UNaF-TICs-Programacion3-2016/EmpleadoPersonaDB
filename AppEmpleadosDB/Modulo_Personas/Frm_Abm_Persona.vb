Imports CapaDatos
Public Class Frm_Abm_Persona

    Private oPersona As ClasePersona
    Private EsBaja As Boolean

    Private Sub Frm_Abm_Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EsBaja = (Frm_Inicial_Personas.Accion = Tipo_Accion.Baja)

        'Cargo Combo Sexo
        If CmbSexo.Items.Count = 0 Then
            CmbSexo.Items.Insert(ClasePersona.Tipo_Sexo.Femenino, ClasePersona.Tipo_Sexo.Femenino.ToString)
            CmbSexo.Items.Insert(ClasePersona.Tipo_Sexo.Masculino, ClasePersona.Tipo_Sexo.Masculino.ToString)
        End If

        'Cargo Combo Estado Civil
        If CmbEstadoCivil.Items.Count = 0 Then
            CmbEstadoCivil.Items.Insert(ClasePersona.Tipo_EstadoCivil.Soltero, ClasePersona.Tipo_EstadoCivil.Soltero.ToString)
            CmbEstadoCivil.Items.Insert(ClasePersona.Tipo_EstadoCivil.Casado, ClasePersona.Tipo_EstadoCivil.Casado.ToString)
        End If

        oPersona = New ClasePersona(Frm_Inicial_Personas.IdPersona.ToString)
        MostrarDatosEnFormulario()

    End Sub
    Private Sub AceptarPersonaCmd_Click(sender As Object, e As EventArgs) Handles AceptarPersonaCmd.Click

        TomarDatosDeFormulario()

        Select Case Frm_Inicial_Personas.Accion
            Case Tipo_Accion.Alta
                If oPersona.Insertar() Then
                    MsgBox("Se dió de Alta correctamente a la Persona " +
                               oPersona.ApellidoyNombre, MsgBoxStyle.Information)
                Else
                    Exit Sub
                End If
            Case Tipo_Accion.Baja
                If MsgBox("Seguro que desea dar de baja a la Persona?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes Then
                    If oPersona.Eliminar() Then
                        MsgBox("Se Eliminó correctamente a la Persona " +
                               oPersona.ApellidoyNombre, MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If
            Case Tipo_Accion.Modificacion
                If oPersona.Actualizar() Then
                    MsgBox("Los datos de la Persona " +
                               oPersona.ApellidoyNombre +
                               " se Actualizaron correctamente", MsgBoxStyle.Information)
                Else
                    Exit Sub
                End If
        End Select

        Frm_Inicial_Personas.CargarGrillaPersonas()
        Me.Close()

    End Sub

    Private Sub TomarDatosDeFormulario()
        With oPersona
            .ApellidoyNombre = TxtApyNombre.Text
            .Dni = TxtDni.Text
            .Cuil = TxtTipo.Text + TxtNumero.Text + TxtDigitoVerificador.Text
            .Sexo = CType(CmbSexo.SelectedIndex, ClasePersona.Tipo_Sexo)
            .EstadoCivil = CType(CmbEstadoCivil.SelectedIndex, ClasePersona.Tipo_EstadoCivil)
            .FechaNacimiento = DtpFNacimiento.Value
        End With
    End Sub

    Private Sub MostrarDatosEnFormulario()
        With oPersona
            TxtApyNombre.Text = IIf(IsDBNull(.ApellidoyNombre), "", .ApellidoyNombre)
            TxtDni.Text = IIf(IsDBNull(.Dni), "", .Dni)
            TxtTipo.Text = IIf(IsDBNull(.Cuil), "", Mid$(.Cuil, 1, 2))
            TxtNumero.Text = IIf(IsDBNull(.Cuil), "", Mid$(.Cuil, 3, 8))
            TxtDigitoVerificador.Text = IIf(IsDBNull(.Cuil), "", Mid$(.Cuil, 11, 1))
            CmbSexo.SelectedIndex = IIf(IsDBNull(.Sexo), "", .Sexo)
            CmbEstadoCivil.SelectedIndex = 0 'IIf(IsDBNull(.EstadoCivil), -1, .EstadoCivil)
            DtpFNacimiento.Value = IIf(IsDBNull(.FechaNacimiento), Date.Now, .FechaNacimiento)
        End With
        TxtApyNombre.Enabled = Not EsBaja
        TxtDni.Enabled = Not EsBaja
        TxtTipo.Enabled = Not EsBaja
        TxtNumero.Enabled = Not EsBaja
        TxtDigitoVerificador.Enabled = Not EsBaja
        CmbSexo.Enabled = Not EsBaja
        CmbEstadoCivil.Enabled = Not EsBaja
        DtpFNacimiento.Enabled = Not EsBaja
    End Sub

    Private Sub CancelarPersonaCmd_Click(sender As Object, e As EventArgs) Handles CancelarPersonaCmd.Click
        Me.Close()
    End Sub
End Class