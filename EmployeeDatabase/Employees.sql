CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] nvarchar(50) not null,
	[Email] nvarchar(50) not null,
	[Company] int references [Companies](Id) null
)
