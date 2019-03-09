DECLARE @values TABLE([Id] INT, [Name] NVARCHAR(50))

INSERT INTO @values
([Id], [Name])
VALUES
(1, 'Admin'),
(2, 'User')

MERGE [nom].[Role] as T_Base
USING @values as T_Source
ON ([T_Base].[Id] = [T_Source].[Id])
WHEN MATCHED THEN
	UPDATE 
	SET [Name] = [T_Source].[Name]
WHEN NOT MATCHED THEN 
	INSERT([Name])
	VALUES ([T_Source].[Name]);
