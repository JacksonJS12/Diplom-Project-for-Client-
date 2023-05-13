CREATE TABLE [dbo].[BookIconom] (
    [Id] INT PRIMARY KEY IDENTITY,
	[Appartement]        INT        NOT NULL,
    [FullName] NCHAR (60) NOT NULL,
    [Status]     NCHAR (10) NOT NULL,
    [DateInput]  DATE       NOT NULL,
    [DateOutput] NCHAR (10) NULL,
    [YearBorn]   INT        NULL
);

