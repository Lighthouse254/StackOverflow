create table UserInfo (
	IDUser int identity primary key,
	Username varchar(100) not null,
	Password varchar(1000) not null,
	DisplayName nvarchar(100) not null default 'Anonymous',
	Gender int not null default 1,		-- 1: male || 0: female
	Email varchar(100) not null default 'email@stack.com',
	Avatar nvarchar(1000),
	AboutMe ntext,
	Career nvarchar(100),
	Birthday date,
)
go

create table Tags (
	IDTags int identity primary key,
	NameTag varchar(100) not null default 'Unnamed tag',
	Description ntext,
)
go

create table UserDetail (
	IDUserDetail int identity primary key,
	IDUser int not null,
	AccountFacebook varchar(100),
	AccountGoogle varchar(100),
	AccountGithub varchar(100),
	IDTags int,

	foreign key (IDUser) references dbo.UserInfo(IDUser),
	foreign key (IDTags) references dbo.Tags(IDTags)
)
go

create table Post (
	IDPost int identity primary key,
	IDUser int not null,
	Title nvarchar(1000),
	PostContent ntext not null,
	CountViews int not null default 0,
	TimeUpdated datetime not null default getdate(),
	TimeAsked datetime not null default getdate(),
	IsResolved int not null default 0		-- 1: resolved || 0: not resolved

	foreign key (IDUser) references dbo.UserInfo(IDUser)
)
go

create table PostDetail (
	IDPostDetail int identity primary key,
	IDPost int not null,
	IDTags int not null,
	UrlImage varchar(1000),
	UrlVideo varchar(1000),

	foreign key (IDPost) references dbo.Post(IDPost),
	foreign key (IDTags) references dbo.Tags(IDTags)
)
go

create table Answer (
	IDAnswer int identity primary key,
	IDPost int not null,
	IDUser int not null,
	AnswerContent ntext not null,
	UrlImage varchar(1000),
	TimeUpdated datetime not null default getdate(),
	TimeAnswer datetime not null default getdate(),
	Votes int not null default 0,
	IsResolved int not null default 0		-- 1: resolved || 0: not resolved

	foreign key (IDPost) references dbo.Post(IDPost),
	foreign key (IDUser) references dbo.UserInfo(IDUser)
)


create procedure sp_User_GetByTop
	@Top	nvarchar(10),
	@Where	nvarchar(max),
	@Order	nvarchar(200)
as
	declare @SQL as nvarchar(500)
	declare @strTop as nvarchar(100)
	select @strTop = '(' + @Top + ')'
	if len(@Top) = 0 
		begin
			Select @strTop = '100 percent'
		end
	select @SQL = 'select top ' + @strTop + ' * from UserInfo'
	if len(@Where) > 0 
		begin
			select @SQL = @SQL + ' where ' + @Where
		end
	if len(@Order) > 0
		begin
			select @SQL = @SQL + ' order by ' + @Order
		end
	exec (@SQL)
go

create procedure sp_User_Insert
	@Username varchar(100),
	@Password varchar(1000)
	--@DisplayName nvarchar(100),
	--@Gender int,
	--@Email varchar(100),
	--@Avatar nvarchar(1000),
	--@AboutMe ntext,
	--@Career nvarchar(100),
	--@Birthday date
as
begin
	insert into UserInfo values(@Username, @Password, null, null, null, null, null, null, null)
end
go

create procedure sp_User_SignUp
	@Username varchar(100),
	@Password varchar(1000),
	@Email varchar(100)
as
begin
	insert into UserInfo values(@Username, @Password, null, null, @Email, null, null, null, null)
end
go

create procedure sp_User_ForgotPassword
	@Username varchar(100),
	@Password varchar(1000)
as
begin
	update UserInfo set Password = @Password where Username = @Username
end
go

create procedure sp_User_Update
	@IDUser int,
	--@Username varchar(100),
	--@Password varchar(1000),
	@DisplayName nvarchar(100),
	@Gender int,
	@Email varchar(100),
	@Avatar nvarchar(1000),
	@AboutMe ntext,
	@Career nvarchar(100),
	@Birthday date
as
begin
	update UserInfo set DisplayName = @DisplayName,
						Gender = @Gender,
						Email = @Email,
						Avatar = @Avatar,
						AboutMe = @AboutMe,
						Career = @Career,
						Birthday = @Birthday
					where IDUser = @IDUser
end
go

create procedure sp_User_Delete
	@IDUser int
as
begin
	delete from UserInfo where IDUser = @IDUser
end
go