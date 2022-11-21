SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudent]
AS
BEGIN
      SET NOCOUNT ON;
 
      SELECT Id,
            name,
            gender,
            class
      FROM student
END