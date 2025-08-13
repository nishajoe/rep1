create database PetAppDB

select name from master.sys.databases order by name

use PetAppDB

create LOGIN PetUserLogin with password= 'Strong123!'

CREATE USER PetUser FOR LOGIN PetUserLogin;

create table PetCategory (Id uniqueidentifier not null  primary key ,Name nvarchar(50),Image varbinary(max) not null)

INSERT INTO PetCategory VALUES (NEWID(), 'Cow', CAST('image1.jpg' AS varbinary(max)));

exec sp_help PetCategory

SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'PetCategory'

ALTER table PetCategory alter COLUMN Image NVARCHAR(200)

create table Breed (
Id  uniqueidentifier not null primary key,
Name nvarchar(50),
PetsCategory uniqueidentifier Foreign key references PetCategory(Id))

CREATE TABLE PublicUser(
    Id UNIQUEIDENTIFIER NOT NULL primary key,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(50),
    Phone NVARCHAR(10),
    Role VARCHAR(50),
CONSTRAINT CK_Phone_Length CHECK (LEN(Phone) = 10 AND Phone NOT LIKE '%[^0-9]%'))

INSERT INTO PublicUser VALUES(NEWID(),'SOUDHA','AM','Soudhasoudhu99@gmail.com','9956858989','Admin')
INSERT INTO PublicUser VALUES(NEWID(),'Sana','AM','Sana99@gmail.com','9956858989','User')
INSERT INTO PublicUser VALUES(NEWID(),'SOUDHA','AM','Soudhasoudhu99@gmail.com','9956858989','Admin')

select * from PublicUser

Select Distinct FirstName from PublicUser


ALTER TABLE Pet ADD Rate int 

ALTER TABLE Pet DROP COLUMN Rate;

SELECT * FROM information_schema.tables WHERE TABLE_TYPE='BASE TABLE'

exec sp_rename 'PetCategory','Category'

Select * from Category 

CREATE VIEW ViewOfPets  AS  SELECT Id, Name, Age FROM Pet 

Select * from ViewOfPets  

Drop view ViewOfPets  

GRANT CREATE TABLE TO PetUser;     

UPDATE PublicUser
SET Phone = '8592093362'
WHERE Email = 'Soudhasoudhu99@gmail.com'

Delete from PublicUser where Email ='Sana99@gmail.com'

SELECT FirstName FROM PublicUser
WHERE FirstName LIKE '%A'

select p.name as petname, pu.FirstName, pu.LastName from Category p
    join PublicUser pu on p.Id=pu.Id

select pu.FirstName, pu.LastName, p.name as petname from Publicuser pu 
left join Category p on pu.id = p.id

select p.name as petname, pu.FirstName, pu.LastName from Publicuser pu  
right join Category p on p.id = pu.id

select pu.FirstName, pu.LastName, p.name as petname from Publicuser pu 
full outer join Category p on pu.id = p.id

select * from Category



SELECT pu.FirstName, pu.LastName, p.Name AS PetName
     FROM PublicUser pu
     CROSS JOIN PetCategory p
