CREATE PROCEDURE [dbo].[LoginUser]
	@Email VARCHAR(358),
	@Password VARCHAR(30)
AS
	IF EXISTS(SELECT * FROM [User_] WHERE Email = @Email)
		BEGIN
			SELECT * FROM [User_] WHERE Email = @Email AND [Password] = HASHBYTES('SHA2_512', CONCAT(Salt, @Password) )
		END
RETURN 0
