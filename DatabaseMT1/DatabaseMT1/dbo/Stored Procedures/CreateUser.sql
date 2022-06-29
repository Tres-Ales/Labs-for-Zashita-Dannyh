-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CreateUser](@username nchar(20),@password int)
AS
BEGIN
SET NOCOUNT ON;
	if exists(select * from dbo.User1 where username=@username)
		raiserror('User %s already exist',1,1,@username);
	insert into dbo.User1(username,password)
	values(@username,@password)
END
