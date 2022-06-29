-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SUMCOST (@Name varchar(40), @contractSum int OUTPUT)
AS
BEGIN
	
	SET NOCOUNT ON;

    SELECT @contractSum = SUM([dbo].[Product1].[Cost]) FROM [dbo].[User1]
		JOIN [dbo].[ListUP] ON [dbo].[ListUP].[userid] = [dbo].[User1].[userid]
		JOIN [dbo].[Product1] ON [dbo].[Product1].[productid] = [dbo].[ListUP].[productid]
	WHERE username = @Name
END
