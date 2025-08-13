create database book 
use book
create table Books(
Book_Id int primary key,
Book_Title varchar(20) not null,
Book_Author varchar(10) not null,
Book_Price int not null)

select * from books