create database NumberGame
go
use NumberGame
go
create table Logins
(
	Id int identity(1,1) primary key,
	UserName nvarchar(10) not null,
	UserPassword nvarchar(10) not null,
	Email nvarchar(80) not null,
	CreateDate smalldatetime default(getdate()),
	LastLoginDate smalldatetime default(getdate())
)
go
create proc sp_CreateUser
(
	@UserName nvarchar(10),
	@Email nvarchar(80),
	@Password nvarchar(10)
)
as
begin

	insert into Logins(UserName,UserPassword,Email)
	values(@UserName,@Password,@Email)

end

go

create proc sp_Login
(
	@UserName nvarchar(10),
	@Password nvarchar(10)
)
as
begin
	declare @count int

	select @count=Count(*) from Logins
	where UserName=@UserName and UserPassword=@Password

	if(@count=1)
		update Logins set LastLoginDate=getdate()
		where UserName=@UserName and UserPassword=@Password

	select UserName,UserPassword,Email,CreateDate,LastLoginDate
	from Logins where UserName=@UserName and UserPassword=@Password
end

go

create proc sp_UserIsInDatabase
(
	@UserName nvarchar(10),
	@Email nvarchar(10)
)
as
begin
	declare @count int

	select @count=count(*) from Logins
	where UserName=@UserName and Email=@Email
	if(@count<>0)
		return 3

	select @count=count(*) from Logins
	where Email=@Email
	if(@count<>0)
		return 2

	select @count=count(*) from Logins
	where UserName=@UserName
	if(@count<>0)
		return 1


end