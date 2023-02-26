CREATE TABLE [dbo].[UserLogs]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1,1), --일련번호
	Username NVarChar(50) Not Null,
	FailedPasswordAttemptCount Int Default(0),   --로그인 실패 카운트
	FailedPasswordAttemptWindowStart
		DateTIme Default(GetDate())				 --로그인 실패 처음 생성일
)