--[User][0][2] Users 관련 저장 프로시저 생성'

--[1] 입력 저장 프로시저
Create Proc dbo.WriteUsers
	@UserID NVarChar(25),
	@Password NVarChar(255)
As
	Insert Into Users(UserID, Password) Values(@UserID, @Password)
GO

--WriteUsers 'redpluse', '1234'

--[2] 출력 저장 프로시저
--Create Proc dbo.ListUsers
--As
--	Select * From Users Order by UID Desc
--GO

Create Proc dbo.ListUsers
AS	
	Select [UID], [UserID], [Password] From Users Order By UID Desc
GO

--[3] 상세 저장 프로시저
Create Proc dbo.ViewUsers
	@UID Int
AS 
	Select [UID], [UserID], [Password] from Users Where UID = @UID
GO

--[4] 수정 저장 프로시저
Create Proc dbo.ModifyUsers
	@UserID NvarChar(25),
	@Password NvarChar(255),
	@UID Int
AS
	Begin Tran
		Update Users
		Set 
			UserID = @UserID,
			[Password] = @Password
		Where UID = @UID
	Commit Tran
GO

--ModifyUsers 'master', '1234', 2

--[5] Create Proc dbo.DeleteUsers

Create Proc dbo.DeleteUsers
	@UID Int
AS	
	Delete Users Where UID = @UID
GO
-- DeleteUsers 2

Create Proc dbo.SearchUsers
	@SearchField NVarChar(25),
	@SearchQuery NVarChar(25)
AS
	Declare @strSql NVarChar(255)
	Set @strSql = '
		Select * From Users
		Where
			' + @SearchField + ' Like ''%' + @SearchQuery + '%''
		'
		--Print @strSql
		Exec(@strSql)
GO
--SearchUsers 'UserID, 'admin'	



