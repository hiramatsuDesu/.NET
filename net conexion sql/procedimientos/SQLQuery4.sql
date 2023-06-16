CREATE OR ALTER PROCEDURE AltaEmpleado
	       @NombreCompleto varchar(100)
           ,@DNI varchar(10)
           ,@Edad int
           ,@Casado bit
           ,@Salario decimal(12, 2)
AS
BEGIN


INSERT INTO [dbo].[Empleados]
           ([NombreCompleto]
           ,[DNI]
           ,[Edad]
           ,[Casado]
           ,[Salario]
           )
     VALUES
           ( @NombreCompleto 
           ,@DNI
           ,@Edad 
           ,@Casado 
           ,@Salario 
           );

END
GO