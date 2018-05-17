Public Class Informacion
    Dim query As IQueryable(Of Paciente)
    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nombre", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Apellido", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Direccion", 300, HorizontalAlignment.Center)
        ListView1.Columns.Add("Fecha de nacimiento", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("genero", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("edad", 50, HorizontalAlignment.Center)



        Dim db As New HospitalDBEntities
        query = (From u In db.Pacientes Select u)
        For Each _u In query
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idPaciente)
            col.SubItems.Add(_u.nombre)
            col.SubItems.Add(_u.apellido)
            col.SubItems.Add(_u.direccion)
            col.SubItems.Add(_u.nacimiento)
            col.SubItems.Add(_u.genero)
            col.SubItems.Add(_u.edad)
        Next
    End Sub
    Private Sub Informacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatos()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New Paciente
        Dim _year = DateTimePicker1.Value.Year.ToString
        Dim _month = DateTimePicker1.Value.Month.ToString
        Dim _day = DateTimePicker1.Value.Day.ToString
        Dim _sexo As String

        If ComboBox1.Text.Equals("Masculino") Then
            _sexo = "M"
        ElseIf ComboBox1.Text.Equals("Femenino")
            _sexo = "F"
        End If

        _enfermedad.nombre = TextBox1.Text
        _enfermedad.apellido = TextBox2.Text
        _enfermedad.nacimiento = _year + "-" + _month + "-" + _day
        _enfermedad.direccion = TextBox5.Text
        _enfermedad.genero = _sexo
        _enfermedad.edad = NumericUpDown1.Value

        db.Pacientes.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim db As New HospitalDBEntities
        Dim id As Integer
        id = TextBox4.Text

        Dim _enfermedad As Paciente = db.Pacientes.Find(id)

        Dim _year = DateTimePicker1.Value.Year.ToString
        Dim _month = DateTimePicker1.Value.Month.ToString
        Dim _day = DateTimePicker1.Value.Day.ToString
        Dim _sexo As String

        If ComboBox1.Text.Equals("Masculino") Then
            _sexo = "M"
        ElseIf ComboBox1.Text.Equals("Femenino") Then
            _sexo = "F"
        End If

        _enfermedad.nombre = TextBox1.Text
        _enfermedad.apellido = TextBox2.Text
        _enfermedad.nacimiento = _year + "-" + _month + "-" + _day
        _enfermedad.direccion = TextBox5.Text
        _enfermedad.genero = _sexo
        _enfermedad.edad = NumericUpDown1.Value

        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New HospitalDBEntities
        Dim id As New Integer
        Dim enfermedad As New Paciente

        id = TextBox3.Text

        enfermedad = db.Pacientes.Find(id)

        db.Pacientes.Remove(enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub
End Class
