CREATE PROCEDURE [dbo].[Insert_User]
      @Name VARCHAR(50),
      @Email VARCHAR(50),
      @Mobile VARCHAR(50),
	  @City VARCHAR(50),
	  @Location VARCHAR(50),
	  @Address VARCHAR(50),
	  @Zipcode	INT,
	  @Password VARCHAR(50),
	  @Roleid INT
AS
BEGIN
      SET NOCOUNT ON;
      IF EXISTS(SELECT Id FROM users WHERE name = @Name)
      BEGIN
            SELECT -1 -- Username exists.
      END
      ELSE IF EXISTS(SELECT Id FROM users WHERE email = @Email)
      BEGIN
            SELECT -2 -- Email exists.
      END
      ELSE
      BEGIN
            INSERT INTO [users]
                     ([name]
                     ,[email]
                     ,[mobile]
                     ,[city]
					 ,[location]
					 ,[address]
					 ,[zipcode]
					 ,[password]
					 ,[roleid])
            VALUES
                     (@Name
                     ,@Email
                     ,@Mobile
					 ,@City
					 ,@Location
					 ,@Address
					 ,@Zipcode
					 ,@Password
					 ,@Roleid
                     )
           
            SELECT SCOPE_IDENTITY() -- Id                 
     END
END