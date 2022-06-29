CREATE PROCEDURE [dbo].[Login](@username nchar(20),@password nchar(20), @userid int OUTPUT)
AS
BEGIN
SET NOCOUNT ON;
	if NOT EXISTS(select * from dbo.User1 where username=@username)
		BEGIN
			raiserror('User %s does not exist',1,1,@username);
		END
	else if NOT 1=(select count (*)from dbo.User1 where username=@username and password=@password)
		BEGIN
			raiserror('Wrong password for user %s',1,1,@username);
		END
	ELSE 
		BEGIN
			set @userid=(select top 1 userid from dbo.User1 where username=@username);
		END
END
