<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Abm_Empleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FrmEmpleado = New System.Windows.Forms.GroupBox()
        Me.CancelarEmpleadoCmd = New System.Windows.Forms.Button()
        Me.AceptarEmpleadoCmd = New System.Windows.Forms.Button()
        Me.LblFechaBaja = New System.Windows.Forms.Label()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CmbEstadoDelPuesto = New System.Windows.Forms.ComboBox()
        Me.LblSueldoBruto = New System.Windows.Forms.Label()
        Me.TxtSueldoBruto = New System.Windows.Forms.TextBox()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.LblDepartamento = New System.Windows.Forms.Label()
        Me.CmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.LblPersona = New System.Windows.Forms.Label()
        Me.CmbPersona = New System.Windows.Forms.ComboBox()
        Me.LblFechaIngreso = New System.Windows.Forms.Label()
        Me.DtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.GBoxHeader = New System.Windows.Forms.GroupBox()
        Me.BtnModificacion = New System.Windows.Forms.Button()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.BtnAlta = New System.Windows.Forms.Button()
        Me.CmbEmpleado = New System.Windows.Forms.ComboBox()
        Me.FrmEmpleado.SuspendLayout()
        Me.GBoxHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrmEmpleado
        '
        Me.FrmEmpleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrmEmpleado.Controls.Add(Me.CancelarEmpleadoCmd)
        Me.FrmEmpleado.Controls.Add(Me.AceptarEmpleadoCmd)
        Me.FrmEmpleado.Controls.Add(Me.LblFechaBaja)
        Me.FrmEmpleado.Controls.Add(Me.LblEstado)
        Me.FrmEmpleado.Controls.Add(Me.CmbEstadoDelPuesto)
        Me.FrmEmpleado.Controls.Add(Me.LblSueldoBruto)
        Me.FrmEmpleado.Controls.Add(Me.TxtSueldoBruto)
        Me.FrmEmpleado.Controls.Add(Me.LblCategoria)
        Me.FrmEmpleado.Controls.Add(Me.CmbCategoria)
        Me.FrmEmpleado.Controls.Add(Me.LblDepartamento)
        Me.FrmEmpleado.Controls.Add(Me.CmbDepartamento)
        Me.FrmEmpleado.Controls.Add(Me.LblPersona)
        Me.FrmEmpleado.Controls.Add(Me.CmbPersona)
        Me.FrmEmpleado.Controls.Add(Me.LblFechaIngreso)
        Me.FrmEmpleado.Controls.Add(Me.DtpFechaIngreso)
        Me.FrmEmpleado.Location = New System.Drawing.Point(12, 79)
        Me.FrmEmpleado.Name = "FrmEmpleado"
        Me.FrmEmpleado.Size = New System.Drawing.Size(594, 310)
        Me.FrmEmpleado.TabIndex = 3
        Me.FrmEmpleado.TabStop = False
        '
        'CancelarEmpleadoCmd
        '
        Me.CancelarEmpleadoCmd.Location = New System.Drawing.Point(499, 272)
        Me.CancelarEmpleadoCmd.Name = "CancelarEmpleadoCmd"
        Me.CancelarEmpleadoCmd.Size = New System.Drawing.Size(75, 23)
        Me.CancelarEmpleadoCmd.TabIndex = 26
        Me.CancelarEmpleadoCmd.Text = "Cancelar"
        Me.CancelarEmpleadoCmd.UseVisualStyleBackColor = True
        '
        'AceptarEmpleadoCmd
        '
        Me.AceptarEmpleadoCmd.Location = New System.Drawing.Point(418, 272)
        Me.AceptarEmpleadoCmd.Name = "AceptarEmpleadoCmd"
        Me.AceptarEmpleadoCmd.Size = New System.Drawing.Size(75, 23)
        Me.AceptarEmpleadoCmd.TabIndex = 25
        Me.AceptarEmpleadoCmd.Text = "Aceptar"
        Me.AceptarEmpleadoCmd.UseVisualStyleBackColor = True
        '
        'LblFechaBaja
        '
        Me.LblFechaBaja.AutoSize = True
        Me.LblFechaBaja.ForeColor = System.Drawing.Color.Red
        Me.LblFechaBaja.Location = New System.Drawing.Point(442, 53)
        Me.LblFechaBaja.Name = "LblFechaBaja"
        Me.LblFechaBaja.Size = New System.Drawing.Size(133, 13)
        Me.LblFechaBaja.TabIndex = 22
        Me.LblFechaBaja.Text = "15/02/2015 16:02:59 p.m."
        Me.LblFechaBaja.Visible = False
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(72, 129)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 21
        Me.LblEstado.Text = "Estado"
        '
        'CmbEstadoDelPuesto
        '
        Me.CmbEstadoDelPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstadoDelPuesto.FormattingEnabled = True
        Me.CmbEstadoDelPuesto.Location = New System.Drawing.Point(117, 126)
        Me.CmbEstadoDelPuesto.Name = "CmbEstadoDelPuesto"
        Me.CmbEstadoDelPuesto.Size = New System.Drawing.Size(121, 21)
        Me.CmbEstadoDelPuesto.TabIndex = 20
        '
        'LblSueldoBruto
        '
        Me.LblSueldoBruto.AutoSize = True
        Me.LblSueldoBruto.Location = New System.Drawing.Point(43, 156)
        Me.LblSueldoBruto.Name = "LblSueldoBruto"
        Me.LblSueldoBruto.Size = New System.Drawing.Size(68, 13)
        Me.LblSueldoBruto.TabIndex = 19
        Me.LblSueldoBruto.Text = "Sueldo Bruto"
        '
        'TxtSueldoBruto
        '
        Me.TxtSueldoBruto.Location = New System.Drawing.Point(117, 153)
        Me.TxtSueldoBruto.Name = "TxtSueldoBruto"
        Me.TxtSueldoBruto.Size = New System.Drawing.Size(100, 20)
        Me.TxtSueldoBruto.TabIndex = 18
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(59, 102)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(52, 13)
        Me.LblCategoria.TabIndex = 17
        Me.LblCategoria.Text = "Categoria"
        '
        'CmbCategoria
        '
        Me.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(117, 99)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(169, 21)
        Me.CmbCategoria.TabIndex = 16
        '
        'LblDepartamento
        '
        Me.LblDepartamento.AutoSize = True
        Me.LblDepartamento.Location = New System.Drawing.Point(37, 76)
        Me.LblDepartamento.Name = "LblDepartamento"
        Me.LblDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.LblDepartamento.TabIndex = 15
        Me.LblDepartamento.Text = "Departamento"
        '
        'CmbDepartamento
        '
        Me.CmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDepartamento.FormattingEnabled = True
        Me.CmbDepartamento.Location = New System.Drawing.Point(117, 72)
        Me.CmbDepartamento.Name = "CmbDepartamento"
        Me.CmbDepartamento.Size = New System.Drawing.Size(169, 21)
        Me.CmbDepartamento.TabIndex = 14
        '
        'LblPersona
        '
        Me.LblPersona.AutoSize = True
        Me.LblPersona.Location = New System.Drawing.Point(65, 22)
        Me.LblPersona.Name = "LblPersona"
        Me.LblPersona.Size = New System.Drawing.Size(46, 13)
        Me.LblPersona.TabIndex = 13
        Me.LblPersona.Text = "Persona"
        '
        'CmbPersona
        '
        Me.CmbPersona.FormattingEnabled = True
        Me.CmbPersona.Location = New System.Drawing.Point(117, 19)
        Me.CmbPersona.Name = "CmbPersona"
        Me.CmbPersona.Size = New System.Drawing.Size(333, 21)
        Me.CmbPersona.TabIndex = 12
        '
        'LblFechaIngreso
        '
        Me.LblFechaIngreso.AutoSize = True
        Me.LblFechaIngreso.Location = New System.Drawing.Point(21, 49)
        Me.LblFechaIngreso.Name = "LblFechaIngreso"
        Me.LblFechaIngreso.Size = New System.Drawing.Size(90, 13)
        Me.LblFechaIngreso.TabIndex = 11
        Me.LblFechaIngreso.Text = "Fecha de Ingreso"
        '
        'DtpFechaIngreso
        '
        Me.DtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIngreso.Location = New System.Drawing.Point(117, 46)
        Me.DtpFechaIngreso.Name = "DtpFechaIngreso"
        Me.DtpFechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaIngreso.TabIndex = 7
        Me.DtpFechaIngreso.Value = New Date(2015, 10, 13, 0, 0, 0, 0)
        '
        'GBoxHeader
        '
        Me.GBoxHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBoxHeader.Controls.Add(Me.BtnModificacion)
        Me.GBoxHeader.Controls.Add(Me.BtnBaja)
        Me.GBoxHeader.Controls.Add(Me.BtnAlta)
        Me.GBoxHeader.Controls.Add(Me.CmbEmpleado)
        Me.GBoxHeader.Location = New System.Drawing.Point(12, 12)
        Me.GBoxHeader.Name = "GBoxHeader"
        Me.GBoxHeader.Size = New System.Drawing.Size(594, 61)
        Me.GBoxHeader.TabIndex = 4
        Me.GBoxHeader.TabStop = False
        '
        'BtnModificacion
        '
        Me.BtnModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModificacion.Location = New System.Drawing.Point(445, 14)
        Me.BtnModificacion.Name = "BtnModificacion"
        Me.BtnModificacion.Size = New System.Drawing.Size(77, 38)
        Me.BtnModificacion.TabIndex = 2
        Me.BtnModificacion.Text = "Modificacion"
        Me.BtnModificacion.UseVisualStyleBackColor = True
        '
        'BtnBaja
        '
        Me.BtnBaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBaja.ForeColor = System.Drawing.Color.Red
        Me.BtnBaja.Location = New System.Drawing.Point(528, 14)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(60, 38)
        Me.BtnBaja.TabIndex = 3
        Me.BtnBaja.Text = "Baja"
        Me.BtnBaja.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAlta.Location = New System.Drawing.Point(379, 14)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(60, 38)
        Me.BtnAlta.TabIndex = 1
        Me.BtnAlta.Text = "Alta"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'CmbEmpleado
        '
        Me.CmbEmpleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbEmpleado.FormattingEnabled = True
        Me.CmbEmpleado.Location = New System.Drawing.Point(10, 22)
        Me.CmbEmpleado.Name = "CmbEmpleado"
        Me.CmbEmpleado.Size = New System.Drawing.Size(362, 21)
        Me.CmbEmpleado.TabIndex = 0
        '
        'Frm_Abm_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 407)
        Me.Controls.Add(Me.GBoxHeader)
        Me.Controls.Add(Me.FrmEmpleado)
        Me.Name = "Frm_Abm_Empleado"
        Me.Text = "Empleados"
        Me.FrmEmpleado.ResumeLayout(False)
        Me.FrmEmpleado.PerformLayout()
        Me.GBoxHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrmEmpleado As GroupBox
    Friend WithEvents LblFechaBaja As Label
    Friend WithEvents LblEstado As Label
    Friend WithEvents CmbEstadoDelPuesto As ComboBox
    Friend WithEvents LblSueldoBruto As Label
    Friend WithEvents TxtSueldoBruto As TextBox
    Friend WithEvents LblCategoria As Label
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents LblDepartamento As Label
    Friend WithEvents CmbDepartamento As ComboBox
    Friend WithEvents LblPersona As Label
    Friend WithEvents CmbPersona As ComboBox
    Friend WithEvents LblFechaIngreso As Label
    Friend WithEvents DtpFechaIngreso As DateTimePicker
    Friend WithEvents GBoxHeader As GroupBox
    Friend WithEvents BtnModificacion As Button
    Friend WithEvents BtnBaja As Button
    Friend WithEvents BtnAlta As Button
    Friend WithEvents CmbEmpleado As ComboBox
    Friend WithEvents CancelarEmpleadoCmd As Button
    Friend WithEvents AceptarEmpleadoCmd As Button
End Class
