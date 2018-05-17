Public Class Procedimientos
    Dim query1 As IQueryable(Of Paciente)
    Dim query2 As IQueryable(Of TipoOperacion)
    Dim query3 As IQueryable(Of Medico)
    Dim query4 As IQueryable(Of Operacion)
    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Paciente", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Doctor", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tipo de Operacion", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Estado", 30, HorizontalAlignment.Center)

        Dim db As New HospitalDBEntities
        query4 = (From u In db.Operacions Select u)
        For Each _u In query4
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idOperacion)
            col.SubItems.Add(_u.Paciente.nombre + " " + _u.Paciente.apellido)
            col.SubItems.Add(_u.Medico.nombre + " " + _u.Medico.apellido)
            col.SubItems.Add(_u.TipoOperacion.nombre)
            col.SubItems.Add(_u.estado)
        Next
    End Sub
    Private Sub Procedimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New HospitalDBEntities
        LoadDatos()
        query1 = (From u In db.Pacientes Select u)
        For Each _u In query1
            ComboBox1.Items.Add(_u.nombre + " " + _u.apellido)
        Next
        query2 = (From u In db.TipoOperacions Select u)
        For Each _u In query2
            ComboBox2.Items.Add(_u.nombre)
        Next
        query3 = (From u In db.Medicos Select u)
        For Each _u In query3
            ComboBox3.Items.Add(_u.nombre + " " + _u.apellido)
        Next
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New Operacion
        Dim _namep As String
        Dim _idp As Integer
        Dim _namem As String
        Dim _idm As Integer
        Dim _ide As Integer

        _namep = ComboBox1.Text
        query1 = (From u In db.Pacientes Select u)
        For Each _u In query1
            Dim nn = _u.nombre + " " + _u.apellido
            If nn.Equals(_namep) Then
                _idp = _u.idPaciente
            End If
        Next
        _namem = ComboBox3.Text
        query3 = (From u In db.Medicos Select u)
        For Each _u In query3
            Dim nn = _u.nombre + " " + _u.apellido
            If nn.Equals(_namem) Then
                _idm = _u.idMedico
            End If
        Next
        query2 = (From u In db.TipoOperacions Select u)
        For Each _u In query2
            If _u.nombre.Equals(ComboBox2.Text) Then
                _ide = _u.idTipoOperacion
            End If
        Next

        _enfermedad.idTipoOperacion = _ide
        _enfermedad.idMedico = _idm
        _enfermedad.idPaciente = _idp
        _enfermedad.estado = ComboBox4.SelectedIndex


        db.Operacions.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub
End Class
