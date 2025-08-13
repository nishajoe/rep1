create table Customers(
customer_id int,
frist_name varchar(20))


insert into Customers values(1,'Robert')
insert into Customers values(2,'Ann')
insert into Customers values(3,'Malu')
insert into Customers values(4,'Divya')
insert into Customers values(5,'Renu')


create table Orders(
order_id int,
amount bigint,
custom_id int)

insert into Orders values(1,200,10)
insert into Orders values(1,500,3)
insert into Orders values(1,300,6)
insert into Orders values(1,800,5)
insert into Orders values(1,150,8)

select * from customers
select * from Orders
select Customers.customer_id, Customers.frist_name,orders.amount  from customers left join Orders on customers.customer_id = orders.custom_id

select * from customers
select * from Orders
select Customers.frist_name,orders.amount  from customers inner join Orders on customers.customer_id = orders.custom_id

select * from customers
select * from Orders
select Customers.customer_id, Customers.frist_name,orders.amount  from customers full outer join Orders on customers.customer_id = orders.custom_id


