﻿CREATE PROCEDURE [dbo].[uspDeleteEmployees]
	@Ids NVARCHAR(1000),
	@IsDebug BIT = 0
AS
BEGIN
	DECLARE @SQL NVARCHAR(1000)
	SET @SQL = 'DELETE [E] FROM [Employees] AS [E] WHERE Id IN (' + @Ids + ')'
	EXEC (@SQL)
	RETURN 0
END
GO