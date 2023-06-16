CREATE PROCEDURE ListarEmpleados
    @Nombre varchar(50) = null
AS
BEGIN
	SELECT [Id]
      ,[NombreCompleto]
      ,[DNI]
      ,[Edad]
      ,[Casado]
      ,[Salario]
	FROM Empleados
	WHERE @Nombre is null OR Upper(NombreCompleto) LIKE '%' +  Upper(@Nombre) + '%';

END
GO