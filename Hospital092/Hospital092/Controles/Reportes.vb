Imports System.Data.SqlClient

Public Class Reportes
    Dim query As IQueryable(Of Enfermedad)
    Dim query2 As IQueryable(Of TipoOperacion)
    Dim query3 As IQueryable(Of Medico)
    Dim query4 As IQueryable(Of Paciente)
    Dim query5 As IQueryable(Of Medicamento)
    Dim query6 As IQueryable(Of Operacion)
    Dim query7 As IQueryable(Of Consulta)
    Public Sub LoadEnfermedades()
        Dim db As New HospitalDBEntities
        Dim da As New SqlDataAdapter
        Dim ds As DataSet
        Dim itemcoll(100) As String
        query = (From u In db.Enfermedads Select u)

        ListView1.Clear()

        Dim sql As String = "SELECT * FROM v_TopEnfermedad"
        Dim cmd As New SqlCommand(sql, db.Database.Connection)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim i As Integer = 0
        Dim j As Integer = 0

        ListView1.Columns.Add("Enfermedad", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Veces", 100, HorizontalAlignment.Center)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                If j = 0 Then
                    For Each _u In query
                        If _u.idEnfermedad = ds.Tables(0).Rows(i)(j) Then
                            itemcoll(j) = _u.nombre
                        End If
                    Next
                Else
                    itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                End If
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView1.Items.Add(lvi)

        Next
    End Sub
    Public Sub LoadOperaciones()
        Dim db As New HospitalDBEntities
        Dim da As New SqlDataAdapter
        Dim ds As DataSet
        Dim itemcoll(100) As String
        query2 = (From u In db.TipoOperacions Select u)

        ListView2.Clear()

        Dim sql As String = "SELECT * FROM v_TopOperacion"
        Dim cmd As New SqlCommand(sql, db.Database.Connection)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim i As Integer = 0
        Dim j As Integer = 0

        ListView2.Columns.Add("Operacion", 100, HorizontalAlignment.Center)
        ListView2.Columns.Add("Veces", 100, HorizontalAlignment.Center)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                If j = 0 Then
                    For Each _u In query2
                        If _u.idTipoOperacion = ds.Tables(0).Rows(i)(j) Then
                            itemcoll(j) = _u.nombre
                        End If
                    Next
                Else
                    itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                End If
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView2.Items.Add(lvi)

        Next
    End Sub
    Public Sub LoadDoctorOperacion()
        Dim db As New HospitalDBEntities
        Dim da As New SqlDataAdapter
        Dim ds As DataSet
        Dim itemcoll(100) As String
        query3 = (From u In db.Medicos Select u)

        ListView3.Clear()

        Dim sql As String = "SELECT * FROM v_TopMedicoOperando"
        Dim cmd As New SqlCommand(sql, db.Database.Connection)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim i As Integer = 0
        Dim j As Integer = 0

        ListView3.Columns.Add("Doctor", 100, HorizontalAlignment.Center)
        ListView3.Columns.Add("Operaciones", 100, HorizontalAlignment.Center)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                If j = 0 Then
                    For Each _u In query3
                        If _u.idMedico = ds.Tables(0).Rows(i)(j) Then
                            itemcoll(j) = _u.nombre + " " + _u.apellido
                        End If
                    Next
                Else
                    itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                End If
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView3.Items.Add(lvi)

        Next
    End Sub
    Public Sub LoadPacienteVisitado()
        Dim db As New HospitalDBEntities
        Dim da As New SqlDataAdapter
        Dim ds As DataSet
        Dim itemcoll(100) As String
        query4 = (From u In db.Pacientes Select u)

        ListView4.Clear()

        Dim sql As String = "SELECT * FROM v_TopPaciente"
        Dim cmd As New SqlCommand(sql, db.Database.Connection)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim i As Integer = 0
        Dim j As Integer = 0

        ListView4.Columns.Add("Paciente", 100, HorizontalAlignment.Center)
        ListView4.Columns.Add("Consultas", 100, HorizontalAlignment.Center)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                If j = 0 Then
                    For Each _u In query4
                        If _u.idPaciente = ds.Tables(0).Rows(i)(j) Then
                            itemcoll(j) = _u.nombre + " " + _u.apellido
                        End If
                    Next
                Else
                    itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                End If
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView4.Items.Add(lvi)

        Next
    End Sub
    Public Sub LoadMedicamento()
        Dim db As New HospitalDBEntities
        Dim da As New SqlDataAdapter
        Dim ds As DataSet
        Dim itemcoll(100) As String
        query5 = (From u In db.Medicamentoes Select u)

        ListView5.Clear()

        Dim sql As String = "SELECT * FROM v_TopMedicamento"
        Dim cmd As New SqlCommand(sql, db.Database.Connection)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim i As Integer = 0
        Dim j As Integer = 0

        ListView5.Columns.Add("Medicamento", 100, HorizontalAlignment.Center)
        ListView5.Columns.Add("Veces Recetado", 100, HorizontalAlignment.Center)

        For i = 0 To ds.Tables(0).Rows.Count - 1
            For j = 0 To ds.Tables(0).Columns.Count - 1
                If j = 0 Then
                    For Each _u In query5
                        If _u.idMedicamento = ds.Tables(0).Rows(i)(j) Then
                            itemcoll(j) = _u.nombre
                        End If
                    Next
                Else
                    itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                End If
            Next
            Dim lvi As New ListViewItem(itemcoll)
            Me.ListView5.Items.Add(lvi)

        Next
    End Sub
    Public Sub LoadApendicitis()
        ListView6.Clear()
        ListView6.Columns.Add("Doctor", 150, HorizontalAlignment.Center)

        Dim db As New HospitalDBEntities
        query6 = (From u In db.Operacions Select u)
        For Each _u In query6
            Dim col As New ListViewItem
            col = ListView6.Items.Add(_u.Medico.nombre + " " + _u.Medico.apellido)
        Next
    End Sub
    Public Sub LoadExito()
        ListView7.Clear()
        ListView7.Columns.Add("Numero de operacion", 50, HorizontalAlignment.Center)
        ListView7.Columns.Add("Paciente", 150, HorizontalAlignment.Center)


        Dim db As New HospitalDBEntities
        query6 = (From u In db.Operacions Select u)
        For Each _u In query6
            If _u.estado = 1 Then
                Dim col As New ListViewItem
                col = ListView7.Items.Add(_u.idOperacion)
                col.SubItems.Add(_u.Paciente.nombre + " " + _u.Paciente.apellido)
            End If
        Next
    End Sub
    Public Sub LoadFallida()
        ListView8.Clear()
        ListView8.Columns.Add("Numero de operacion", 50, HorizontalAlignment.Center)
        ListView8.Columns.Add("Paciente", 150, HorizontalAlignment.Center)

        Dim db As New HospitalDBEntities
        query6 = (From u In db.Operacions Select u)
        For Each _u In query6
            If _u.estado = 0 Then
                Dim col As New ListViewItem
                col = ListView8.Items.Add(_u.idOperacion)
                col.SubItems.Add(_u.Paciente.nombre + " " + _u.Paciente.apellido)
            End If
        Next
    End Sub
    Public Sub LoadDolorEstomago()
        ListView9.Clear()
        ListView9.Columns.Add("Paciente", 150, HorizontalAlignment.Center)
        Dim _idDolor As Integer

        Dim db As New HospitalDBEntities
        query7 = (From u In db.Consultas Select u)
        query = (From u In db.Enfermedads Select u)
        For Each _u In query
            If _u.nombre.Equals("Dolor de estomago") Then
                _idDolor = _u.idEnfermedad
            End If
        Next
        For Each _u In query7
            If _u.descripcion.Equals("Dolor de estomago") Or _u.idEnfermedad = _idDolor Then
                Dim col As New ListViewItem
                col = ListView9.Items.Add(_u.Paciente.nombre + " " + _u.Paciente.apellido)
            End If
        Next
    End Sub
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEnfermedades()
        LoadOperaciones()
        LoadDoctorOperacion()
        LoadPacienteVisitado()
        LoadMedicamento()
        LoadApendicitis()
        LoadExito()
        LoadFallida()
        LoadDolorEstomago()
    End Sub
End Class
