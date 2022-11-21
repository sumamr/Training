Create Procedure AuthenticateUser1
@UserName varchar(100),
@Password nvarchar(100)
as
Begin
 Declare @Count int
 
 Select @Count = COUNT(email) from users
 where email = @UserName 
 
 if(@Count = 1)
 Begin
  Select 1 as ReturnCode
 End
 Else
 Begin
  Select -1 as ReturnCode
 End
End