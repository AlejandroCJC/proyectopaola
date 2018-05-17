Public Class VerDoctores
    Dim query As IQueryable(Of EspecialidadMedico)
    Dim query2 As IQueryable(Of Especialidad)
    Dim query3 As IQueryable(Of Medico)
    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("Doctor", 300, HorizontalAlignment.Center)
        ListView1.Columns.Add("Especialidad", 300, HorizontalAlignment.Center)


        Dim db As New HospitalDBEntities
        query = (From u In db.EspecialidadMedicoes Select u)
        For Each _u In query
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.Medico.nombre + " " + _u.Medico.apellido)
            col.SubItems.Add(_u.Especialidad.nombre)

        Next
    End Sub

    Private Sub VerDoctores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New HospitalDBEntities
        LoadDatos()
        query2 = (From u In db.Especialidads Select u)
        For Each _u In query2
            ComboBox2.Items.Add(_u.nombre)
        Next
        query3 = (From u In db.Medicos Select u)
        For Each _u In query3
            ComboBox1.Items.Add(_u.nombre + " " + _u.apellido)
        Next
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New EspecialidadMedico
        Dim _named As String
        Dim _idd As Integer
        Dim _namee As String
        Dim _ide As Integer

        _named = ComboBox1.Text
        query3 = (From u In db.Medicos Select u)
        For Each _u In query3
            Dim nn = _u.nombre + " " + _u.apellido
            If nn.Equals(_named) Then
                _idd = _u.idMedico
            End If
        Next
        _namee = ComboBox2.Text
        query2 = (From u In db.Especialidads Select u)
        For Each _u In query2
            If _u.nombre.Equals(_namee) Then
                _ide = _u.idEspecialidad
            End If
        Next

        _enfermedad.idMedico = _idd
        _enfermedad.idEspecialidad = _ide

        db.EspecialidadMedicoes.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub
End Class
