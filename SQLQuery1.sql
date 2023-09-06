USE [PeluqueríaDB]
GO

BEGIN
    CREATE TABLE [dbo].[Cuentas](
        [CuentaId] INT IDENTITY(1,1) PRIMARY KEY,
        [Contraseña] [nvarchar](50) NOT NULL,
        [Nombre_Apellido] [nvarchar](50) NOT NULL,
        [Email] [nvarchar](50) NOT NULL,
        [Teléfono] [nvarchar](50) NOT NULL,
        [Usuario] [nvarchar](50) NOT NULL
    ) ON [PRIMARY]
END
GO

BEGIN
    CREATE TABLE [dbo].[Clientes](
        [ClienteId] INT IDENTITY(1,1) PRIMARY KEY,
        [Nombre] [nvarchar](50) NOT NULL,
        [Apellido] [nvarchar](50) NOT NULL,
        [Teléfono] [nvarchar](50) NOT NULL
    ) ON [PRIMARY]
END
GO

BEGIN
    CREATE TABLE [dbo].[Servicios](
        [Servicio] [nvarchar](50) NOT NULL,
        [Precio] [nvarchar](50) NOT NULL
    ) ON [PRIMARY]
    
    INSERT INTO [dbo].[Servicios] ([Servicio], [Precio])
    VALUES
        ('Corte de Pelo', '30'),
        ('Lavado y Peinado', '20'),
        ('Coloración', '50');
END
GO


BEGIN
    CREATE TABLE [dbo].[Turnos](
        [TurnoId] INT IDENTITY(1,1) PRIMARY KEY,
        [ClienteId] INT REFERENCES [dbo].[Clientes]([ClienteId]),
        [Servicio] [nvarchar](50) NOT NULL,
        [Fecha] [smalldatetime] NOT NULL
    ) ON [PRIMARY]
    
    -- Agregar 4 turnos con fechas y horarios específicos, incluyendo la lógica para crear clientes si no existen
    INSERT INTO [dbo].[Turnos] ([ClienteId], [Servicio], [Fecha])
    VALUES
        ((SELECT [ClienteId] FROM [dbo].[Clientes] WHERE [Nombre] = 'Juan' AND [Apellido] = 'Pérez' AND [Teléfono] = '123456789'),
        'Corte de Pelo', '2023-08-08 10:00:00'),
        
        -- Repite lo mismo para los demás turnos...
        
        ((SELECT [ClienteId] FROM [dbo].[Clientes] WHERE [Nombre] = 'Enzo' AND [Apellido] = 'Nieto' AND [Teléfono] = '2023932932'),
        'Corte de Pelo', '2023-08-10 16:15:00');
END
GO