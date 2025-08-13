create database learn
use learn

create table cust(
custid int primary key,
companyname varchar(20) not null,
city varchar(20) default 'seatle')

sp_help 'cust'   //to view the structure of the table

sp_helpconstraint 'cust'	//to view the constraints of a table

alter table cust drop constraint PK__cust__973AFEFEA15FCD3D

alter table cust add constraint primary_cust primary key(custid)

create table CustOrder(
orderid varchar(10) constraint primary_order primary key,
customerid int constraint foreign_customer foreign key references cust(custid))

create table emp(
empid int constraint uniqid unique not null,


