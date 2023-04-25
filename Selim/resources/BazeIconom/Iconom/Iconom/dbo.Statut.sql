CREATE TABLE [dbo].[Statut] (
    [Status] NCHAR (10) NULL
);

INSERT INTO [dbo].[Statut]([Status])
SELECT [Status]
FROM [dbo].[BookIconom]

