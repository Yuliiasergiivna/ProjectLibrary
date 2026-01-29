CREATE PROCEDURE [dbo].[SP_Book_Get_All]
AS
BEGIN
	SELECT	[BookId], 
			[Title], 
			[Author],
			[ReleaseDate], 
			[ISBN]
		FROM [Book]
END