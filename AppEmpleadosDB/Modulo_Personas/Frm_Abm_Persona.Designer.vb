<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Abm_Persona
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
        Me.FrmPersona = New System.Windows.Forms.GroupBox()
        Me.CancelarPersonaCmd = New System.Windows.Forms.Button()
        Me.AceptarPersonaCmd = New System.Windows.Forms.Button()
        Me.LblFNacimiento = New System.Windows.Forms.Label()
        Me.DtpFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblEstadoCivil = New System.Windows.Forms.Label()
        Me.CmbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtDigitoVerificador = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.LblCuil = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.LblApyNombre = New System.Windows.Forms.Label()
        Me.TxtApyNombre = New System.Windows.Forms.TextBox()
        Me.FrmPersona.SuspendLayout()
        Me.SuspendLayout()
        '
        'FrmPersona
        '
        Me.FrmPersona.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrmPersona.Controls.Add(Me.CancelarPersonaCmd)
        Me.FrmPersona.Controls.Add(Me.AceptarPersonaCmd)
        Me.FrmPersona.Controls.Add(Me.LblFNacimiento)
        Me.FrmPersona.Controls.Add(Me.DtpFNacimiento)
        Me.FrmPersona.Controls.Add(Me.LblEstadoCivil)
        Me.FrmPersona.Controls.Add(Me.CmbEstadoCivil)
        Me.FrmPersona.Controls.Add(Me.TxtNumero)
        Me.FrmPersona.Controls.Add(Me.TxtDigitoVerificador)
        Me.FrmPersona.Controls.Add(Me.TxtTipo)
        Me.FrmPersona.Controls.Add(Me.LblCuil)
        Me.FrmPersona.Controls.Add(Me.TxtDni)
        Me.FrmPersona.Controls.Add(Me.LblSexo)
        Me.FrmPersona.Controls.Add(Me.LblDni)
        Me.FrmPersona.Controls.Add(Me.CmbSexo)
        Me.FrmPersona.Controls.Add(Me.LblApyNombre)
        Me.FrmPersona.Controls.Add(Me.TxtApyNombre)
        Me.FrmPersona.Location = New System.Drawing.Point(12, 12)
        Me.FrmPersona.Name = "FrmPersona"
        Me.FrmPersona.Size = New System.Drawing.Size(467, 220)
        Me.FrmPersona.TabIndex = 24
        Me.FrmPersona.TabStop = False
        '
        'CancelarPersonaCmd
        '
        Me.CancelarPersonaCmd.Location = New System.Drawing.Point(377, 182)
        Me.CancelarPersonaCmd.Name = "CancelarPersonaCmd"
        Me.CancelarPersonaCmd.Size = New System.Drawing.Size(75, 23)
        Me.CancelarPersonaCmd.TabIndex = 13
        Me.CancelarPersonaCmd.Text = "Cancelar"
        Me.CancelarPersonaCmd.UseVisualStyleBackColor = True
        '
        'AceptarPersonaCmd
        '
        Me.AceptarPersonaCmd.Location = New System.Drawing.Point(296, 182)
        Me.AceptarPersonaCmd.Name = "AceptarPersonaCmd"
        Me.AceptarPersonaCmd.Size = New System.Drawing.Size(75, 23)
        Me.AceptarPersonaCmd.TabIndex = 12
        Me.AceptarPersonaCmd.Text = "Aceptar"
        Me.AceptarPersonaCmd.UseVisualStyleBackColor = True
        '
        'LblFNacimiento
        '
        Me.LblFNacimiento.AutoSize = True
        Me.LblFNacimiento.Location = New System.Drawing.Point(22, 156)
        Me.LblFNacimiento.Name = "LblFNacimiento"
        Me.LblFNacimiento.Size = New System.Drawing.Size(108, 13)
        Me.LblFNacimiento.TabIndex = 11
        Me.LblFNacimiento.Text = "Fecha de Nacimiento"
        '
        'DtpFNacimiento
        '
        Me.DtpFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFNacimiento.Location = New System.Drawing.Point(136, 153)
        Me.DtpFNacimiento.Name = "DtpFNacimiento"
        Me.DtpFNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.DtpFNacimiento.TabIndex = 7
        '
        'LblEstadoCivil
        '
        Me.LblEstadoCivil.AutoSize = True
        Me.LblEstadoCivil.Location = New System.Drawing.Point(68, 129)
        Me.LblEstadoCivil.Name = "LblEstadoCivil"
        Me.LblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.LblEstadoCivil.TabIndex = 9
        Me.LblEstadoCivil.Text = "Estado Civil"
        '
        'CmbEstadoCivil
        '
        Me.CmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstadoCivil.FormattingEnabled = True
        Me.CmbEstadoCivil.Location = New System.Drawing.Point(136, 126)
        Me.CmbEstadoCivil.Name = "CmbEstadoCivil"
        Me.CmbEstadoCivil.Size = New System.Drawing.Size(146, 21)
        Me.CmbEstadoCivil.TabIndex = 6
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(172, 100)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumero.TabIndex = 4
        '
        'TxtDigitoVerificador
        '
        Me.TxtDigitoVerificador.Location = New System.Drawing.Point(278, 100)
        Me.TxtDigitoVerificador.Name = "TxtDigitoVerificador"
        Me.TxtDigitoVerificador.Size = New System.Drawing.Size(21, 20)
        Me.TxtDigitoVerificador.TabIndex = 5
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(136, 100)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(30, 20)
        Me.TxtTipo.TabIndex = 3
        '
        'LblCuil
        '
        Me.LblCuil.AutoSize = True
        Me.LblCuil.Location = New System.Drawing.Point(99, 103)
        Me.LblCuil.Name = "LblCuil"
        Me.LblCuil.Size = New System.Drawing.Size(31, 13)
        Me.LblCuil.TabIndex = 5
        Me.LblCuil.Text = "CUIL"
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(136, 47)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 1
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(99, 76)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 3
        Me.LblSexo.Text = "Sexo"
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.Location = New System.Drawing.Point(104, 50)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(26, 13)
        Me.LblDni.TabIndex = 3
        Me.LblDni.Text = "DNI"
        '
        'CmbSexo
        '
        Me.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(136, 73)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.CmbSexo.TabIndex = 2
        '
        'LblApyNombre
        '
        Me.LblApyNombre.AutoSize = True
        Me.LblApyNombre.Location = New System.Drawing.Point(38, 21)
        Me.LblApyNombre.Name = "LblApyNombre"
        Me.LblApyNombre.Size = New System.Drawing.Size(92, 13)
        Me.LblApyNombre.TabIndex = 1
        Me.LblApyNombre.Text = "Apellido y Nombre"
        '
        'TxtApyNombre
        '
        Me.TxtApyNombre.Location = New System.Drawing.Point(136, 18)
        Me.TxtApyNombre.Name = "TxtApyNombre"
        Me.TxtApyNombre.Size = New System.Drawing.Size(321, 20)
        Me.TxtApyNombre.TabIndex = 0
        '
        'Frm_Abm_Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 240)
        Me.Controls.Add(Me.FrmPersona)
        Me.Name = "Frm_Abm_Persona"
        Me.Text = "Persona"
        Me.FrmPersona.ResumeLayout(False)
        Me.FrmPersona.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrmPersona As GroupBox
    Friend WithEvents CancelarPersonaCmd As Button
    Friend WithEvents AceptarPersonaCmd As Button
    Friend WithEvents LblFNacimiento As Label
    Friend WithEvents DtpFNacimiento As DateTimePicker
    Friend WithEvents LblEstadoCivil As Label
    Friend WithEvents CmbEstadoCivil As ComboBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtDigitoVerificador As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents LblCuil As Label
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblDni As Label
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents LblApyNombre As Label
    Friend WithEvents TxtApyNombre As TextBox
End Class
