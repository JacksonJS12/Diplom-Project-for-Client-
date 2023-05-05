CREATE TABLE [dbo].[Inhabitant](
	[Id] INT PRIMARY KEY IDENTITY,
	[FullName] NVARCHAR(100) NOT NULL,
	[AppartementNumber] INT NOT NULL,
	[Status] NVARCHAR(30) NOT NULL,
	[BirthYear] INT NOT NULL,
	[EnterDate] DATE NOT NULL,
	[LeavingDate] DATE 
);


INSERT INTO [dbo].[Inhabitant]([FullName], [AppartementNumber], [Status], [BirthYear], [EnterDate])
VALUES ('Иван Иванов Иванов', 12, 'наемател', 1980, '2000-02-02');

SELECT * 
FROM [dbo].[Inhabitant]