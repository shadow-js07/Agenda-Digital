CREATE DATABASE AgendaDigital;
GO

USE AgendaDigital;
GO

CREATE TABLE Contactos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(50) NOT NULL,
    Apellido NVARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Direccion NVARCHAR(255),
    Genero CHAR(1) CHECK (Genero IN ('M', 'F')),
    EstadoCivil NVARCHAR(10) CHECK (EstadoCivil IN ('Soltero', 'Soltera', 'Casado', 'Casada', 'Divorciado', 'Divorciada', 'Viudo', 'Viuda')),
    Movil NVARCHAR(15),
    Telefono NVARCHAR(15),
    CorreoElectronico NVARCHAR(255)
);
GO
Select * from Contactos;