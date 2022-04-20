CREATE PROC Login_Select
@user nvarchar(50),
@pass nvarchar(50)
as

SELECT [username]
      ,[password]
      ,[permision]
  FROM [dbo].[Login]
  WHERE @user = [username]
  AND   @pass = [password]

