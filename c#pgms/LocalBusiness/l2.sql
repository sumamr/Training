CREATE PROCEDURE [dbo].[Validate_User]
      @Email VARCHAR(20),
      @Password VARCHAR(20)
AS
BEGIN
      SET NOCOUNT ON;
      DECLARE @Id INT, @LastLoginDate DATETIME, @Id INT
     
      SELECT @Id =Id, @LastLoginDate = LastLoginDate, @Id = Id
      FROM users WHERE Email = @email AND [Password] = @Password
     
      IF @Id IS NOT NULL
      BEGIN
            IF NOT EXISTS(SELECT Id FROM UserActivation WHERE Id = @Id)
            BEGIN
                  UPDATE users
                  SET LastLoginDate = GETDATE()
                  WHERE Id = @Id
                 
                  SELECT @Id [Id],
                              (SELECT RoleName FROM Roles
                               WHERE Id = @Id) [Roles] -- User Valid
            END
            ELSE
            BEGIN
                  SELECT -2 [Id], '' [Roles]-- User not activated.
            END
      END
      ELSE
      BEGIN
            SELECT -1 [Id], '' [Roles] -- User invalid.
      END
END