use learn
create table employees(
emp_id int primary key,
name varchar(50) not null,
email varchar(40) unique,
age int check (age>= 18),
joindate date default getdate())

drop table employees

sp_helpconstraint 'employees'

alter table employees drop constraint [PK__employee__1299A86104506076]

alter table employees add constraint pk_empid primary key(emp_id)

insert into employees values (1,'nina','asakj@gmail.com',20,'2012-12-09')

alter table employees drop constraint [PK__employee__1299A8616F135C04]



alter table employees alter column emp_id uniqueidentifier not null

insert into employees(emp_id, name, email,age) values (2,'nima','nimaj@gmail.com',21)

delete from employees where emp_id=2

create table emp(
eid int foreign key references employees(emp_id),
ename varchar(50) not null)

select * from emp

create table dpt(
id uniqueidentifier not null,
em_id int not null,
dpt varchar(30) not null,
primary key (id),
foreign key (em_id) references employees(emp_id))

sp_helpconstraint 'dpt'
select * from dpt

insert into employees(emp_id, name, email,age) values (1,'nima','niaj@gmail.com',21)
insert into employees(emp_id, name, email,age) values (2,'reena','naj@gmail.com',21)
insert into employees(emp_id, name, email,age) values (3,'rina','maj@gmail.com',21)

insert into emp values (1,'nima')
insert into emp values (2,'veena')
insert into emp values (2,'rena')
select * from employees, emp
select * from employees where name like '___a'

select name from emp unionall select id from employees

select * from emp union select * from dpt

select name,count() from employees group by(name)

select name,count(name) from employees where name='reena' group by name