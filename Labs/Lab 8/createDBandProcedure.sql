use University;
CREATE LOGIN univer WITH PASSWORD='123'

select suser_sname(owner_sid) as 'Owner', state_desc, *
from sys.databases;

select * from master.sys.server_principals;
CREATE LOGIN univertst WITH PASSWORD='123'


IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'University')
                begin
                 create database University
                end 


CREATE PROCEDURE [dbo].[sp_InsertAuthor]
                    @NAME nvarchar(100),
                    @AGE int, 
					@BIRTHDAY date,
                    @SEX nchar(1) 
                AS insert
                into Authors(NAME, AGE, BIRTHDAY, SEX)
                VALUES(@NAME, @AGE, @BIRTHDAY, @SEX)
                SELECT SCOPE_IDENTITY()
                GO 

CREATE PROCEDURE [dbo].[sp_InsertBook]
                    @AuthorId int,
                    @NameBook nvarchar(20),
                    @Index int
                AS insert
                into Books(AuthorId, NameBook, [Index])
                VALUES(@AuthorId, @NameBook, @Index)
                SELECT SCOPE_IDENTITY()
                GO

select * from Authors;
select * from Books;
drop table Books;
drop table Authors;


begin
	use University
	create table Authors(
		ID int primary key identity(100, 1), 
		NAME nvarchar(100) not null,
		AGE int check(AGE between 17 and 40) not null,
		BIRTHDAY date not null,
		SEX nchar(1) check(SEX in ('м', 'ж')) not null,
		FOTO varbinary(max) default null
	)
end;










insert Into Authors ( NAME, AGE, BIRTHDAY, SEX)values ('Булгаков', 20, '1988-7-10', 'м');
insert into Authors(NAME, AGE, BIRTHDAY, SEX) values 
                  ('Картузов Данила Александрович',  23, '04-06-2000', 'м'),
             ('Седенкова Анастасия Максимовна', 20, '10-07-1998',  'ж'),  
               ('Богословский Артем Михайлович', 19, '12-07-1997',  'м'), 
                ('Пименов Максим Евгеньевич', 18, '12-02-2000', 'ж') ;

          insert into Books(AuthorId, NameBook, [Index]) values
                    (101, 'first book', 220026),
                    (102, 'second book', 220306),
                    (103, 'third book', 220072),
                 (104, 'fourth book', 220306);
