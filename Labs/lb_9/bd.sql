create database app1;

use app1;

create table PUBLISHER (
	id_publisher int identity(1,1) primary key,
	country nchar(20),
	Name nchar(200),
);


create table AUTHOR (
	id_author int identity(1,1) primary key,
	serial nchar(20), --фамилия автора
	-- номер и фото -
);


create table Book (
	id_book int identity(1,1) primary key,
	name nchar(100),
	age int,

	id_publisher int,CONSTRAINT FK_Book_Publisher FOREIGN KEY (id_publisher) REFERENCES PUBLISHER (id_publisher),

	id_author int, CONSTRAINT FK_Book_Author  FOREIGN KEY (id_author) REFERENCES AUTHOR (id_author)
);

Delete from Author where id_author=1;
drop table Book;
drop table PUBLISHER;
drop table AUTHOR;