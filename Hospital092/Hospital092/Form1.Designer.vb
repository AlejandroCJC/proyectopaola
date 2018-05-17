<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeOperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarProcedimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerDoctoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminisitrarDoctoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadMedicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.UnidadMedicaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(842, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicamentosToolStripMenuItem, Me.MedicamentosToolStripMenuItem1, Me.ProveedoresToolStripMenuItem, Me.EspecialidadesToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivos"
        '
        'MedicamentosToolStripMenuItem
        '
        Me.MedicamentosToolStripMenuItem.Name = "MedicamentosToolStripMenuItem"
        Me.MedicamentosToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MedicamentosToolStripMenuItem.Text = "Enfermedades"
        '
        'MedicamentosToolStripMenuItem1
        '
        Me.MedicamentosToolStripMenuItem1.Name = "MedicamentosToolStripMenuItem1"
        Me.MedicamentosToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.MedicamentosToolStripMenuItem1.Text = "Medicamentos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'EspecialidadesToolStripMenuItem
        '
        Me.EspecialidadesToolStripMenuItem.Name = "EspecialidadesToolStripMenuItem"
        Me.EspecialidadesToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EspecialidadesToolStripMenuItem.Text = "Especialidades"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.OperacionesToolStripMenuItem})
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'InformacionToolStripMenuItem
        '
        Me.InformacionToolStripMenuItem.Name = "InformacionToolStripMenuItem"
        Me.InformacionToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.InformacionToolStripMenuItem.Text = "Informacion"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeOperacionToolStripMenuItem, Me.RealizarProcedimientoToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'TipoDeOperacionToolStripMenuItem
        '
        Me.TipoDeOperacionToolStripMenuItem.Name = "TipoDeOperacionToolStripMenuItem"
        Me.TipoDeOperacionToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.TipoDeOperacionToolStripMenuItem.Text = "Tipo de operacion"
        '
        'RealizarProcedimientoToolStripMenuItem
        '
        Me.RealizarProcedimientoToolStripMenuItem.Name = "RealizarProcedimientoToolStripMenuItem"
        Me.RealizarProcedimientoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.RealizarProcedimientoToolStripMenuItem.Text = "Realizar Procedimiento"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerDoctoresToolStripMenuItem, Me.AdminisitrarDoctoresToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.EmpleadosToolStripMenuItem.Text = "Doctores"
        '
        'VerDoctoresToolStripMenuItem
        '
        Me.VerDoctoresToolStripMenuItem.Name = "VerDoctoresToolStripMenuItem"
        Me.VerDoctoresToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.VerDoctoresToolStripMenuItem.Text = "Especilidad doctores"
        '
        'AdminisitrarDoctoresToolStripMenuItem
        '
        Me.AdminisitrarDoctoresToolStripMenuItem.Name = "AdminisitrarDoctoresToolStripMenuItem"
        Me.AdminisitrarDoctoresToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AdminisitrarDoctoresToolStripMenuItem.Text = "Adminisitrar Doctores"
        '
        'UnidadMedicaToolStripMenuItem
        '
        Me.UnidadMedicaToolStripMenuItem.Name = "UnidadMedicaToolStripMenuItem"
        Me.UnidadMedicaToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.UnidadMedicaToolStripMenuItem.Text = "Reportes"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 500)
        Me.Panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 522)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EspecialidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeOperacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarProcedimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerDoctoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminisitrarDoctoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadMedicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
