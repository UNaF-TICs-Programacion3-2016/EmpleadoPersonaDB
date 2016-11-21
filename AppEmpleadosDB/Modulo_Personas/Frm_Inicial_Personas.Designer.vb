<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inicial_Personas
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
        Me.PersonasDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BajaCmd = New System.Windows.Forms.Button()
        Me.ModificacionCmd = New System.Windows.Forms.Button()
        Me.AltaCmd = New System.Windows.Forms.Button()
        CType(Me.PersonasDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersonasDGV
        '
        Me.PersonasDGV.AllowUserToAddRows = False
        Me.PersonasDGV.AllowUserToDeleteRows = False
        Me.PersonasDGV.AllowUserToOrderColumns = True
        Me.PersonasDGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PersonasDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PersonasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonasDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.PersonasDGV.Location = New System.Drawing.Point(12, 162)
        Me.PersonasDGV.Name = "PersonasDGV"
        Me.PersonasDGV.Size = New System.Drawing.Size(734, 230)
        Me.PersonasDGV.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BajaCmd)
        Me.GroupBox2.Controls.Add(Me.ModificacionCmd)
        Me.GroupBox2.Controls.Add(Me.AltaCmd)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(734, 45)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'BajaCmd
        '
        Me.BajaCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BajaCmd.ForeColor = System.Drawing.Color.Red
        Me.BajaCmd.Location = New System.Drawing.Point(653, 14)
        Me.BajaCmd.Name = "BajaCmd"
        Me.BajaCmd.Size = New System.Drawing.Size(75, 23)
        Me.BajaCmd.TabIndex = 2
        Me.BajaCmd.Text = "Eliminar"
        Me.BajaCmd.UseVisualStyleBackColor = True
        '
        'ModificacionCmd
        '
        Me.ModificacionCmd.Location = New System.Drawing.Point(126, 14)
        Me.ModificacionCmd.Name = "ModificacionCmd"
        Me.ModificacionCmd.Size = New System.Drawing.Size(86, 23)
        Me.ModificacionCmd.TabIndex = 1
        Me.ModificacionCmd.Text = "Modificar"
        Me.ModificacionCmd.UseVisualStyleBackColor = True
        '
        'AltaCmd
        '
        Me.AltaCmd.Location = New System.Drawing.Point(15, 14)
        Me.AltaCmd.Name = "AltaCmd"
        Me.AltaCmd.Size = New System.Drawing.Size(105, 23)
        Me.AltaCmd.TabIndex = 0
        Me.AltaCmd.Text = "Agregar Persona"
        Me.AltaCmd.UseVisualStyleBackColor = True
        '
        'Frm_Inicial_Personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 404)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PersonasDGV)
        Me.Name = "Frm_Inicial_Personas"
        Me.Text = "Personas"
        CType(Me.PersonasDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PersonasDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AltaCmd As Button
    Friend WithEvents BajaCmd As Button
    Friend WithEvents ModificacionCmd As Button
End Class
