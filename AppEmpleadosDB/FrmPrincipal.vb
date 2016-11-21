Public Enum Tipo_Accion
    Alta
    Baja
    Modificacion
    Consulta
    Reporte
End Enum

Public Class FrmPrincipal
    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        Frm_Inicial_Personas.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Frm_Abm_Empleado.Show()
    End Sub
End Class