CREATE TABLE [dbo].[Employees] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100) NULL,
    [Gender]      NVARCHAR (10)  DEFAULT (N'Male') NULL,
    [DateOfBirth] DATETIME       NULL DEFAULT GETDATE(),
    CONSTRAINT [PK_Employees_Id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

