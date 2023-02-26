--[User][0][1] 회원관리를 위한 Users 테이블 생성

CREATE TABLE [dbo].[Users]
(
	UID Int Identity(1,1) Primary Key Not Null,
	UserID NVarChar(25) Not Null,
	--암호 필드를 20자에서 255자로 변경(암호화때문에)..
	[Password] NvarChar(255) Not Null,
	--필요한 항목이 있으면, 언제든 추가
	UserName NVarChar(20) Null --사용자 이름
)
GO
