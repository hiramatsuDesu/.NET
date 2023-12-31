USE [EMPLEADOS_DB]
GO
/****** Object:  StoredProcedure [dbo].[AltaEmpleado]    Script Date: 11/06/2023 19:25:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER   PROCEDURE [dbo].[AltaEmpleado]
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
