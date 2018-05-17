Public Class TipoOperacion
    Dim query As IQueryable(Of TipoOperacion)
    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nombre", 150, HorizontalAlignment.Center)

        Dim db As New HospitalDBEntities
        query = (From u In db.TipoOperacions Select u)
        For Each _u In query
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idTipoOperacion)
            col.SubItems.Add(_u.nombre)
        Next
    End Sub
    Private Sub TipoOperacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatos()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New TipoOperacion

        _enfermedad.nombre = TextBox1.Text

        db.TipoOperacions.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim db As New HospitalDBEntities
        Dim id As Integer
        id = TextBox3.Text

        Dim enfermedad As TipoOperacion = db.TipoOperacions.Find(id)

        enfermedad.nombre = TextBox1.Text

        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New HospitalDBEntities
        Dim id As New Integer
        Dim enfermedad As New TipoOperacion

        id = TextBox3.Text

        enfermedad = db.TipoOperacions.Find(id)

        db.TipoOperacions.Remove(enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub


End Class
