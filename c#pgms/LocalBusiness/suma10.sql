CREATE PROCEDURE [dbo].[validate_User]
      @Email VARCHAR(20),
      @Password VARCHAR(20)
AS
BEGIN
      SET NOCOUNT ON;
      DECLARE @Id INT, @RoleId INT
     
      SELECT @Id = Id, @Id = Id
      FROM users WHERE Email = @Email AND [Password] = @Password
     
      IF @Id IS NOT NULL
      BEGIN
            IF NOT EXISTS(SELECT Id FROM users WHERE Id = @Id)
            BEGIN
                
                 
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