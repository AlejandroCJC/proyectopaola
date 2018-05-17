Public Class Especialidades
    Dim query As IQueryable(Of Especialidad)
    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nombre", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Descripcion", 300, HorizontalAlignment.Center)


        Dim db As New HospitalDBEntities
        query = (From u In db.Especialidads Select u)
        For Each _u In query
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idEspecialidad)
            col.SubItems.Add(_u.nombre)
            col.SubItems.Add(_u.Descripcion)
        Next
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New Especialidad

        _enfermedad.nombre = TextBox1.Text
        _enfermedad.Descripcion = TextBox2.Text

        db.Especialidads.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim db As New HospitalDBEntities
        Dim id As Integer
        id = TextBox4.Text

        Dim enfermedad As Especialidad = db.Especialidads.Find(id)

        enfermedad.nombre = TextBox1.Text
        enfermedad.Descripcion = TextBox2.Text

        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New HospitalDBEntities
        Dim id As New Integer
        Dim enfermedad As New Especialidad

        id = TextBox3.Text

        enfermedad = db.Especialidads.Find(id)

        db.Especialidads.Remove(enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Especialidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatos()
    End Sub
End Class
