Public Class Proveedores
    Dim query As IQueryable(Of Proveedor)
    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nombre", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Descripcion", 300, HorizontalAlignment.Center)


        Dim db As New HospitalDBEntities
        query = (From u In db.Proveedors Select u)
        For Each _u In query
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idProveedor)
            col.SubItems.Add(_u.nombre)
            col.SubItems.Add(_u.descripcion)
        Next
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New Proveedor

        _enfermedad.nombre = TextBox1.Text
        _enfermedad.descripcion = TextBox2.Text

        db.Proveedors.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim db As New HospitalDBEntities
        Dim id As Integer
        id = TextBox4.Text

        Dim enfermedad As Proveedor = db.Proveedors.Find(id)

        enfermedad.nombre = TextBox1.Text
        enfermedad.descripcion = TextBox2.Text

        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New HospitalDBEntities
        Dim id As New Integer
        Dim enfermedad As New Proveedor

        id = TextBox3.Text

        enfermedad = db.Proveedors.Find(id)

        db.Proveedors.Remove(enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatos()
    End Sub
End Class
