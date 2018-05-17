Public Class Consulta
    Dim query1 As IQueryable(Of Consulta)
    Dim query2 As IQueryable(Of Paciente)
    Dim query3 As IQueryable(Of Enfermedad)
    Dim query4 As IQueryable(Of Medico)
    Dim query5 As IQueryable(Of Medicamento)
    Dim query6 As IQueryable(Of Receta)

    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Paciente", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Doctor", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Enfermedad", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Descripcion", 300, HorizontalAlignment.Center)

        Dim db As New HospitalDBEntities
        query1 = (From u In db.Consultas Select u)
        For Each _u In query1
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idConsulta)
            col.SubItems.Add(_u.Paciente.nombre + " " + _u.Paciente.apellido)
            col.SubItems.Add(_u.Medico.nombre + " " + _u.Medico.apellido)
            col.SubItems.Add(_u.Enfermedad.nombre)
            col.SubItems.Add(_u.descripcion)
        Next

        ListView2.Clear()
        ListView2.Columns.Add("Consulta", 150, HorizontalAlignment.Center)
        ListView2.Columns.Add("Medicamento", 150, HorizontalAlignment.Center)

        query6 = (From u In db.Recetas Select u)
        For Each _u In query6
            Dim col As New ListViewItem
            col = ListView2.Items.Add(_u.idConsulta)
            col.SubItems.Add(_u.Medicamento.nombre)
        Next
    End Sub
    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New HospitalDBEntities
        LoadDatos()
        query2 = (From u In db.Pacientes Select u)
        For Each _u In query2
            ComboBox1.Items.Add(_u.nombre + " " + _u.apellido)
        Next
        query3 = (From u In db.Enfermedads Select u)
        For Each _u In query3
            ComboBox2.Items.Add(_u.nombre)
        Next
        query4 = (From u In db.Medicos Select u)
        For Each _u In query4
            ComboBox3.Items.Add(_u.nombre + " " + _u.apellido)
        Next
        query5 = (From u In db.Medicamentoes Select u)
        For Each _u In query5
            ComboBox4.Items.Add(_u.nombre)
        Next
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New Consulta
        Dim _receta As New Receta
        Dim _namep As String
        Dim _idp As Integer
        Dim _namem As String
        Dim _idm As Integer
        Dim _ide As Integer
        Dim _idc As Integer
        Dim _idmed As Integer




        _namep = ComboBox1.Text
        query2 = (From u In db.Pacientes Select u)
        For Each _u In query2
            Dim nn = _u.nombre + " " + _u.apellido
            If nn.Equals(_namep) Then
                _idp = _u.idPaciente
            End If
        Next
        _namem = ComboBox3.Text
        query4 = (From u In db.Medicos Select u)
        For Each _u In query4
            Dim nn = _u.nombre + " " + _u.apellido
            If nn.Equals(_namem) Then
                _idm = _u.idMedico
            End If
        Next
        query3 = (From u In db.Enfermedads Select u)
        For Each _u In query3
            If _u.nombre.Equals(ComboBox2.Text) Then
                _ide = _u.idEnfermedad
            End If
        Next

        _enfermedad.idPaciente = _idp
        _enfermedad.idMedico = _idm
        _enfermedad.idEnfermedad = _ide
        _enfermedad.descripcion = TextBox5.Text

        db.Consultas.Add(_enfermedad)
        db.SaveChanges()

        query1 = (From u In db.Consultas Select u)
        For Each _u In query1
            If _u.descripcion.Equals(TextBox5.Text) Then
                _idc = _u.idConsulta
            End If
        Next
        query5 = (From u In db.Medicamentoes Select u)
        For Each _u In query5
            If _u.nombre.Equals(ComboBox4.Text) Then
                _idmed = _u.idMedicamento
            End If
        Next

        _receta.idConsulta = _idc
        _receta.idMedicamento = _idmed
        _receta.dosis = TextBox1.Text

        db.Recetas.Add(_receta)
        db.SaveChanges()
        LoadDatos()
    End Sub
End Class
