create database fk
use fk
create table student(
sid int identity(1,1) primary key,
sname varchar(20) not null)


drop table student

create table course(
cid int identity(1,1) primary key,
cname varchar(20) not null,
csid int foreign key references student(sid))
select * from student
select * from course