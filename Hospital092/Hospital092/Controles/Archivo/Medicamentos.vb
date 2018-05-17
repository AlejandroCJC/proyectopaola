Public Class Medicamentos
    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    'End Sub
    Dim query As IQueryable(Of Medicamento)
    Dim query2 As IQueryable(Of Proveedor)

    Public Sub LoadDatos()
        ListView1.Clear()
        ListView1.Columns.Add("id", 30, HorizontalAlignment.Center)
        ListView1.Columns.Add("Nombre", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Descripcion", 300, HorizontalAlignment.Center)
        ListView1.Columns.Add("Proveedor", 150, HorizontalAlignment.Center)
        ListView1.Columns.Add("Cantidad", 150, HorizontalAlignment.Center)


        Dim db As New HospitalDBEntities
        query = (From u In db.Medicamentoes Select u)
        For Each _u In query
            Dim col As New ListViewItem
            col = ListView1.Items.Add(_u.idMedicamento)
            col.SubItems.Add(_u.nombre)
            col.SubItems.Add(_u.descripcion)
            col.SubItems.Add(_u.Proveedor.nombre)
            col.SubItems.Add(_u.cantidad)
        Next
    End Sub
    Private Sub Medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New HospitalDBEntities
        LoadDatos()
        query2 = (From u In db.Proveedors Select u)
        For Each _u In query2
            ComboBox1.Items.Add(_u.nombre)
        Next
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim db As New HospitalDBEntities
        Dim _enfermedad As New Medicamento
        Dim _name As String
        Dim _id As Integer

        _name = ComboBox1.Text
        query2 = (From u In db.Proveedors Select u)
        For Each _u In query2
            If _u.nombre.Equals(_name) Then
                _id = _u.idProveedor
            End If
        Next

        _enfermedad.nombre = TextBox1.Text
        _enfermedad.cantidad = NumericUpDown1.Value
        _enfermedad.descripcion = TextBox2.Text
        _enfermedad.idProveedor = _id


        db.Medicamentoes.Add(_enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim db As New HospitalDBEntities
        Dim id As Integer
        id = TextBox4.Text
        Dim _name As String
        Dim _id As Integer

        Dim _enfermedad As Medicamento = db.Medicamentoes.Find(id)

        _name = ComboBox1.Text
        query2 = (From u In db.Proveedors Select u)
        For Each _u In query2
            If _u.nombre.Equals(_name) Then
                _id = _u.idProveedor
            End If
        Next

        _enfermedad.nombre = TextBox1.Text
        _enfermedad.cantidad = NumericUpDown1.Value
        _enfermedad.descripcion = TextBox2.Text
        _enfermedad.idProveedor = _id


        db.SaveChanges()
        LoadDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New HospitalDBEntities
        Dim id As New Integer
        Dim enfermedad As New Medicamento

        id = TextBox3.Text

        enfermedad = db.Medicamentoes.Find(id)

        db.Medicamentoes.Remove(enfermedad)
        db.SaveChanges()
        LoadDatos()
    End Sub
End Class
