create database activity
use activity
create table students(
id int primary key,
sname varchar(20) not null,
age int,
subject varchar(20))
select * from students
insert into students values(1,'Reena',20,'maths')
insert into students values(2,'Lena',24,'english')
insert into students values(3,'Teena',26,'maths')
insert into students values(4,'Veena',25,'maths')
select sname from students
select * from students where id =2;
select age from students where id = 2
update students set subject='physics' where subject='maths'