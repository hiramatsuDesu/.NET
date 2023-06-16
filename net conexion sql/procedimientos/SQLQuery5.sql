CREATE OR ALTER PROCEDURE ModificarEmpleado
           @Id int
	       ,@NombreCompleto varchar(100)
           ,@DNI varchar(10)
           ,@Edad int
           ,@Casado bit
           ,@Salario decimal(12, 2)
           
AS
BEGIN


UPDATE [dbo].[Empleados]
   SET [NombreCompleto] = @NombreCompleto
           ,[DNI] = @DNI
           ,[Edad] = @Edad
           ,[Casado] = @Casado
           ,[Salario] = @Salario
         
WHERE id = @Id;
      
       

END
GO