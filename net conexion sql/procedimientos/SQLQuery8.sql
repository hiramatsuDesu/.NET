USE [EMPLEADOS_DB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MostrarEmpleado]
           @Id int   
AS
BEGIN


SELECT * FROM [dbo].[Empleados]
   WHERE id = @Id;
      
       

END