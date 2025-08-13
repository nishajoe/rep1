create database exam
use exam

create table departments(
dept_id int primary key,
dept_name varchar(50) not null)

insert into departments values(10,'HR')
insert into departments values(20,'IT')
insert into departments values(30,'Sales')
insert into departments values(40,'Finance')

create table employees(
emp_id int primary key identity(1,1),
name varchar(50) not null,
dept_id int foreign key references departments(dept_id),
salary bigint,
hire_date date)

insert into employees(name,dept_id, salary, hire_date) values('Alice',10,50000,'2021-01-15')
insert into employees(name,dept_id, salary, hire_date) values('Bob',20,60000,'2020-04-20')
insert into employees(name,dept_id, salary, hire_date) values('Charlie',10,45000,'2019-07-10')
insert into employees(name,dept_id, salary, hire_date) values('David',30,70000,'2022-03-01')
insert into employees(name,salary, hire_date) values('Eva',55000,'2023-06-12')

select * from departments 

select * from employees


//List all employees with their department names using JOIN.//
select * from employees e left join departments d on e.dept_id=d.dept_id 

//Show the names of employees whose salary is above the average salary of all employees.//
 select name from employees group by(salary) having (salary>avg(salary))

 //Display departments that have more than 1 employee.//
 select dept_name from departments group by count(dept_id)

 //List all departments, even if they don’t have any employees//
 select * from departments d left join employees e on d.dept_id= e.dept_id


//Create the copy of the same table//
select * into employee1 from employees
select * from employee1

//Write a query to count the number of employees in each department and order the result by count in descending order.//


//Show the top 2 highest paid employees in the IT department.//
//Use a subquery to find employees whose salary is greater than the average salary of the Sales department.//
select avg(salary) from sales

//Write a query to update the salary of employees in 'HR' department by 10%.//
update salary where set salary=(salary*10)/100  in departments where(dept_name='HR')

//Find the employee who earns the highest salary in each department.//

select count(name) from employees order by count desc






