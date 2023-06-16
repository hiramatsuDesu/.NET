CREATE OR ALTER PROCEDURE EliminarEmpleado
           @Id int   
AS
BEGIN


DELETE FROM [dbo].[Empleados]
   WHERE id = @Id;
      
       

END
GO