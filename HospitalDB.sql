CREATE DATABASE HospitalDB
GO
USE HospitalDB
GO
CREATE TABLE Enfermedad(
idEnfermedad INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre VARCHAR(50) NOT NULL,
Descripcion VARCHAR(100) NOT NULL
);
GO
CREATE TABLE Proveedor(
idProveedor INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre VARCHAR(50) NOT NULL,
descripcion VARCHAR(100) NOT NULL
);
GO
CREATE TABLE Especialidad(
idEspecialidad INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre VARCHAR(50) NOT NULL,
descripcion VARCHAR(100) NOT NULL
);
GO
CREATE TABLE Medicamento(
idMedicamento INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre VARCHAR(50) NOT NULL,
cantidad INT NOT NULL,
descripcion VARCHAR(100) NOT NULL,
idProveedor INT FOREIGN KEY REFERENCES Proveedor(idProveedor)
);
GO
CREATE TABLE Medico(
idMedico INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL,
nacimiento DATETIME NOT NULL,
direccion VARCHAR(100) NOT NULL, 
genero CHAR NOT NULL,
edad INT NOT NULL
);
GO
CREATE TABLE EspecialidadMedico(
idEspecialidadMedico INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
idMedico INT FOREIGN KEY REFERENCES Medico(idMedico),
idEspecialidad INT FOREIGN KEY REFERENCES Especialidad(idEspecialidad)
);
GO
CREATE TABLE Paciente(
idPaciente INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre VARCHAR(50) NOT NULL,
apellido VARCHAR(50) NOT NULL,
nacimiento DATETIME NOT NULL,
direccion VARCHAR(100) NOT NULL, 
genero CHAR NOT NULL,
edad INT NOT NULL
);
GO
CREATE TABLE Consulta(
idConsulta INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
idPaciente INT FOREIGN KEY REFERENCES Paciente(idPaciente),
idMedico INT FOREIGN KEY REFERENCES Medico(idMedico),
idEnfermedad INT FOREIGN KEY REFERENCES Enfermedad(idEnfermedad),
descripcion VARCHAR(100) NOT NULL
);
GO
CREATE TABLE Receta(
idReceta INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
idConsulta INT FOREIGN KEY REFERENCES Consulta(idConsulta),
idMedicamento INT FOREIGN KEY REFERENCES Medicamento(idMedicamento),
dosis VARCHAR(100) NOT NULL
);
GO
CREATE TABLE TipoOperacion(
idTipoOperacion INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
nombre VARCHAR(50) NOT NULL
);
GO
CREATE TABLE Operacion(
idOperacion INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
idTipoOperacion INT FOREIGN KEY REFERENCES TipoOperacion(idTipoOperacion),
idMedico INT FOREIGN KEY REFERENCES Medico(idMedico),
idPaciente INT FOREIGN KEY REFERENCES Paciente(idPaciente),
estado INT NOT NULL
);

CREATE VIEW v_TopEnfermedad
AS
SELECT TOP 3 idEnfermedad as idEnfermedad, COUNT(idEnfermedad) maximo
FROM Consulta
GROUP BY idEnfermedad
ORDER BY maximo DESC
GO

CREATE VIEW v_TopOperacion
AS 
SELECT TOP 3 idTipoOperacion, COUNT(idTipoOperacion) maximo
FROM Operacion
GROUP BY idTipoOperacion
ORDER BY maximo DESC
GO

CREATE VIEW v_TopMedicoOperando
AS 
SELECT TOP 3 idMedico, COUNT(idMedico) maximo
FROM Operacion
GROUP BY idMedico
ORDER BY maximo DESC
GO

CREATE VIEW v_TopPaciente
AS 
SELECT TOP 1 idPaciente, COUNT(idPaciente) maximo
FROM Consulta
GROUP BY idPaciente
ORDER BY maximo DESC
GO

CREATE VIEW v_TopMedicamento
AS 
SELECT TOP 1 idMedicamento, COUNT(idMedicamento) maximo
FROM Receta
GROUP BY idMedicamento
ORDER BY maximo DESC
GO