CREATE PROCEDURE [dbo].[SP_Book_Get_ById]
	@bookId UNIQUEIDENTIFIER
AS
BEGIN
	SELECT	[BookId], 
			[Title],
			[Author],
			[ReleaseDate], 
			[ISBN]
		FROM [Book]
		WHERE [BookId] = @bookId
END