Public Class Enfermedades
    Dim query As IQueryable(Of Enfermedad)
    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nombre", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Descripcion", 300, HorizontalAlignment.Center)


        Dim db As New HospitalDBEntities
        query = (From u In db.Enfermedads Select u)
        For Each _u In query
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idEnfermedad)
            col.SubItems.Add(_u.nombre)
            col.SubItems.Add(_u.Descripcion)
        Next
    End Sub
    Private Sub Enfermedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatos()
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New Enfermedad

        _enfermedad.nombre = TextBox1.Text
        _enfermedad.Descripcion = TextBox2.Text

        db.Enfermedads.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim db As New HospitalDBEntities
        Dim id As Integer
        id = TextBox4.Text

        Dim enfermedad As Enfermedad = db.Enfermedads.Find(id)

        enfermedad.nombre = TextBox1.Text
        enfermedad.Descripcion = TextBox2.Text

        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New HospitalDBEntities
        Dim id As New Integer
        Dim enfermedad As New Enfermedad

        id = TextBox3.Text

        enfermedad = db.Enfermedads.Find(id)

        db.Enfermedads.Remove(enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub
End Class
