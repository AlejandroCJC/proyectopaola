Public Class Form1
    Private Sub MedicamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MedicamentosToolStripMenuItem1.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Medicamentos())
    End Sub

    Private Sub MedicamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicamentosToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Enfermedades())
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Proveedores())
    End Sub

    Private Sub EspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadesToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Especialidades())
    End Sub

    Private Sub InformacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Informacion())
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Consulta())
    End Sub

    Private Sub TipoDeOperacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeOperacionToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New TipoOperacion())
    End Sub

    Private Sub RealizarProcedimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarProcedimientoToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Procedimientos())
    End Sub

    Private Sub VerDoctoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerDoctoresToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New VerDoctores())
    End Sub

    Private Sub AdminisitrarDoctoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminisitrarDoctoresToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New AdministrarDoctores())
    End Sub

    Private Sub UnidadMedicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadMedicaToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(New Reportes())
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Me.Panel1.Controls.Add(New index())
    End Sub

    'Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click

    'End Sub
End Class
