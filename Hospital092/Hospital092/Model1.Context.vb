﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class HospitalDBEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=HospitalDBEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Consultas() As DbSet(Of Consulta)
    Public Overridable Property Enfermedads() As DbSet(Of Enfermedad)
    Public Overridable Property Especialidads() As DbSet(Of Especialidad)
    Public Overridable Property EspecialidadMedicoes() As DbSet(Of EspecialidadMedico)
    Public Overridable Property Medicamentoes() As DbSet(Of Medicamento)
    Public Overridable Property Medicos() As DbSet(Of Medico)
    Public Overridable Property Operacions() As DbSet(Of Operacion)
    Public Overridable Property Pacientes() As DbSet(Of Paciente)
    Public Overridable Property Proveedors() As DbSet(Of Proveedor)
    Public Overridable Property Recetas() As DbSet(Of Receta)
    Public Overridable Property TipoOperacions() As DbSet(Of TipoOperacion)

End Class
