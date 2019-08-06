create database VideoVisionMS
use VideoVisionMS

create table [Login](USERID varchar(50) Primary key,
USERNAME varchar(50) not null, [PASSWORD] varchar(50) not null)
insert into Login values('a1','Sajid','1234')
Select * from Login

create table Customer_Records(CUST_ID varchar(50) Primary key,CUSTOMER_NAME varchar(50) not null,
[ADDRESS] varchar(250) not null,MOBILE_NO decimal(10,0) not null,PACKAGE_SELECTED varchar(20) not null,
AMOUNT int not null,DATE_OF_JOINING date not null)
select * from Customer_Records

create table Employee(EMP_ID varchar(10) Primary Key,EMP_NAME varchar(50) not null,
EMP_ADDRESS VARCHAR(250) NOT NULL,MOBILE_NO numeric(10,0) not null)

create table Packages(PACKAGE_ID int identity(1,1) Primary key,PACKAGE_NAME varchar(50) not null,
PACKAGE_AMOUNT int not null,NO_OF_CHANNELS int not null)
insert into Packages values('Package 1',350,90)
insert into Packages values('Package 2',300,73)
insert into Packages values('Package 3',200,38)
insert into Packages values('Package 4',250,45)
insert into Packages values('Package 5',250,55)
insert into Packages values('Package 6',250,49)

create table Customer_Bill(ID int identity(1,1) primary key,CUST_ID varchar(50) foreign key references Customer_Records(CUST_ID) not null,
CUSTOMER_NAME varchar(50) not null,PACKAGE_SELECTED varchar(50) not null,
AMOUNT int not null,[START_DATE] date not null,END_DATE date not null,AMOUNT_PAID bit not null,
TOTAL_AMOUNT int not null) 
select * from Customer_Bill
