Create Procedure spAuthenticateUser
@email nvarchar(100),
@Password nvarchar(100)
as
Begin
 Declare @Count int
 
 Select @Count = COUNT(email) from users
 where [email] = @email and [Password] = @Password
 
 if(@Count = 1)
 Begin
  Select 1 as ReturnCode
 End
 Else
 Begin
  Select -1 as ReturnCode
 End
End