Imports CapaDatos
Public Class Frm_Abm_Empleado

    Private oEmpleado As ClaseEmpleado
    Private EsBaja As Boolean
    Private Accion As Tipo_Accion

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        EsBaja = False
        Accion = Tipo_Accion.Alta
        'Instancio la Clase Empleado
        oEmpleado = New ClaseEmpleado()
        'Muestro los datos obtenidos
        MostrarDatosEnFormulario()
        GBoxHeader.Enabled = False
    End Sub

    Private Sub TomarDatosDeFormulario()
        With oEmpleado
            .FechaIngreso = DtpFechaIngreso.Value
            .Departamento = CType(CmbDepartamento.SelectedIndex, ClaseEmpleado.Tipo_Departamento)
            .Categoria = CType(CmbCategoria.SelectedIndex, ClaseEmpleado.Tipo_Categoria)
            .Estado = CType(CmbEstadoDelPuesto.SelectedIndex, ClaseEmpleado.Tipo_Estado)
            .SueldoBruto = TxtSueldoBruto.Text
            .Rela_Persona = CmbPersona.SelectedValue
        End With
    End Sub

    Private Sub MostrarDatosEnFormulario()
        With oEmpleado
            DtpFechaIngreso.Value = IIf(IsDBNull(.FechaIngreso), Date.Now, .FechaIngreso)
            CmbDepartamento.SelectedIndex = IIf(IsDBNull(.Departamento), "", .Departamento)
            CmbCategoria.SelectedIndex = IIf(IsDBNull(.Categoria), "", .Categoria)
            CmbEstadoDelPuesto.SelectedIndex = IIf(IsDBNull(.Estado), "", .Estado)
            TxtSueldoBruto.Text = FormatCurrency(IIf(IsDBNull(.SueldoBruto), 0, .SueldoBruto))
            CargarComboPersona(.Rela_Persona)
        End With
        DtpFechaIngreso.Enabled = Not EsBaja
        CmbDepartamento.Enabled = Not EsBaja
        CmbCategoria.Enabled = Not EsBaja
        CmbEstadoDelPuesto.Enabled = Not EsBaja
        CmbPersona.Enabled = Accion = Tipo_Accion.Alta
        TxtSueldoBruto.Enabled = Not EsBaja
        FrmEmpleado.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        oEmpleado = New ClaseEmpleado()

        CargarComboEmpleado()

        'Cargo Combo Departamento
        If CmbDepartamento.Items.Count = 0 Then
            CmbDepartamento.Items.Insert(ClaseEmpleado.Tipo_Departamento.Personal, ClaseEmpleado.Tipo_Departamento.Personal.ToString)
            CmbDepartamento.Items.Insert(ClaseEmpleado.Tipo_Departamento.Contable, ClaseEmpleado.Tipo_Departamento.Contable.ToString)
            CmbDepartamento.Items.Insert(ClaseEmpleado.Tipo_Departamento.Tesoreria, ClaseEmpleado.Tipo_Departamento.Tesoreria.ToString)
            CmbDepartamento.Items.Insert(ClaseEmpleado.Tipo_Departamento.Administracion, ClaseEmpleado.Tipo_Departamento.Administracion.ToString)
        End If

        'Cargo Combo Categoria        
        If CmbCategoria.Items.Count = 0 Then
            CmbCategoria.Items.Insert(ClaseEmpleado.Tipo_Categoria.Cadete, ClaseEmpleado.Tipo_Categoria.Cadete.ToString)
            CmbCategoria.Items.Insert(ClaseEmpleado.Tipo_Categoria.Adminitrativo, ClaseEmpleado.Tipo_Categoria.Adminitrativo.ToString)
            CmbCategoria.Items.Insert(ClaseEmpleado.Tipo_Categoria.Ordenanza, ClaseEmpleado.Tipo_Categoria.Ordenanza.ToString)
            CmbCategoria.Items.Insert(ClaseEmpleado.Tipo_Categoria.Profesional, ClaseEmpleado.Tipo_Categoria.Profesional.ToString)
            CmbCategoria.Items.Insert(ClaseEmpleado.Tipo_Categoria.Gerente, ClaseEmpleado.Tipo_Categoria.Gerente.ToString)
            CmbCategoria.Items.Insert(ClaseEmpleado.Tipo_Categoria.JefeDeDepartamento, ClaseEmpleado.Tipo_Categoria.JefeDeDepartamento.ToString)
            CmbCategoria.Items.Insert(ClaseEmpleado.Tipo_Categoria.JefeDeArea, ClaseEmpleado.Tipo_Categoria.JefeDeArea.ToString)
        End If

        'Cargo Combo Estado
        If CmbEstadoDelPuesto.Items.Count = 0 Then
            CmbEstadoDelPuesto.Items.Insert(ClaseEmpleado.Tipo_Estado.Activo, ClaseEmpleado.Tipo_Estado.Activo.ToString)
            CmbEstadoDelPuesto.Items.Insert(ClaseEmpleado.Tipo_Estado.Licencia, ClaseEmpleado.Tipo_Estado.Licencia.ToString)
            CmbEstadoDelPuesto.Items.Insert(ClaseEmpleado.Tipo_Estado.Suspendido, ClaseEmpleado.Tipo_Estado.Suspendido.ToString)
            CmbEstadoDelPuesto.Items.Insert(ClaseEmpleado.Tipo_Estado.Baja, ClaseEmpleado.Tipo_Estado.Baja.ToString)
        End If

        FrmEmpleado.Visible = False

    End Sub

    Friend Sub CargarComboEmpleado()
        With CmbEmpleado
            .DataSource = oEmpleado.ListarRegistros()
            .DisplayMember = "ApellidoyNombre"
            .ValueMember = "Id_Empleado"
        End With
    End Sub

    Private Sub CargarComboPersona(Optional pRela_Persona As Integer = -1)
        With CmbPersona
            If pRela_Persona > 0 Then
                .DataSource = New ClasePersona().ListarRegistros(
                    "Id_Persona = " + pRela_Persona.ToString)
            Else
                .DataSource = New ClasePersona().ListarRegistros()
            End If
            .DisplayMember = "ApellidoyNombre"
            .ValueMember = "Id_Persona"
        End With
    End Sub

    Private Sub AceptarEmpleadoCmd_Click(sender As Object, e As EventArgs) Handles AceptarEmpleadoCmd.Click
        Try
            TomarDatosDeFormulario()

            Select Case Accion
                Case Tipo_Accion.Alta
                    If oEmpleado.Insertar() Then
                        MsgBox("Se dió de Alta correctamente al Empleado " +
                               CmbPersona.SelectedItem.ApellidoyNombre, MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                Case Tipo_Accion.Baja
                    If MsgBox("Seguro que desea dar de baja al Empleado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes Then
                        If oEmpleado.Eliminar() Then
                            MsgBox("Se Eliminó correctamente al Empleado " +
                               oEmpleado.ApellidoyNombre, MsgBoxStyle.Information)
                        Else
                            Exit Sub
                        End If
                    End If
                Case Tipo_Accion.Modificacion
                    If oEmpleado.Actualizar() Then
                        MsgBox("Los datos del Empleado " +
                               oEmpleado.ApellidoyNombre +
                               " se Actualizaron correctamente", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
            End Select

            GBoxHeader.Enabled = True
            FrmEmpleado.Visible = False
            CargarComboEmpleado()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CancelarEmpleadoCmd_Click(sender As Object, e As EventArgs) Handles CancelarEmpleadoCmd.Click
        FrmEmpleado.Visible = False
        GBoxHeader.Enabled = True
    End Sub

    Private Sub BtnModificacion_Click(sender As Object, e As EventArgs) Handles BtnModificacion.Click
        Try
            EsBaja = False
            Accion = Tipo_Accion.Modificacion
            If CmbEmpleado.SelectedIndex < 0 Then
                Err.Raise(-5,, "Debe seleccionar un Empleado.")
            End If
            'Instancio la Clase Empleado
            oEmpleado = New ClaseEmpleado(CmbEmpleado.SelectedItem("Rela_Persona"), CmbEmpleado.SelectedValue)
            'Muestro los datos obtenidos
            MostrarDatosEnFormulario()
            GBoxHeader.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        Try
            EsBaja = True
            Accion = Tipo_Accion.Baja
            If CmbEmpleado.SelectedIndex < 0 Then
                Err.Raise(-5,, "Debe seleccionar un Empleado.")
            End If
            'Instancio la Clase Empleado
            oEmpleado = New ClaseEmpleado(CmbEmpleado.SelectedItem("Rela_Persona"), CmbEmpleado.SelectedValue)
            'Muestro los datos obtenidos
            MostrarDatosEnFormulario()
            GBoxHeader.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
