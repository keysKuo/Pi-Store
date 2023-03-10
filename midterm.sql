create database dotnet_midterm

use dotnet_midterm

create table __Employee(
    emp_id varchar(10) Primary key,
    name varchar(255),
    email varchar(255),
    phone char(10),
    address varchar(255),
    salary int, 
    hireDate date

)

create table __Client (
    client_id varchar(10) Primary Key,
    name varchar(255),
    email varchar(255),
    phone char(10),
    address varchar(255)
)   

create Table __Product (
    pid varchar(10) Primary Key,
    name varchar(255),
    description varchar(1000),
    price int, 
    quantity int

)

create table __Order (
    order_id varchar(10) Primary Key,
    client_id varchar(10),
    emp_id varchar(10),
    orderDate date, 
    total int

    Constraint FK_Order_Client Foreign key (client_id) References __Client (client_id),
    Constraint FK_Order_Employee Foreign key (emp_id) References __Employee (emp_id)
)

create table __OrderItem (
    OI_id varchar(10) Primary Key,
    order_id varchar(10),
    pid varchar(10),
    quantity int, 

    Constraint FK_OrderItem_Order Foreign Key (order_id) References __Order(order_id),
    Constraint FK_OrderItem_Product Foreign Key (pid) References __Product (pid)
)

create table __Bill ( 
    bill_id varchar(10) Primary Key,
    order_id varchar(10),
    client_id varchar(10),
    emp_id varchar(10),
    billDate date,
    total int

    Constraint FK_Bill_Order Foreign Key (order_id) References __Order (order_id),
    Constraint FK_Bill_Client Foreign Key (client_id) References __Client (client_id),
    Constraint FK_Bill_Employee Foreign Key (emp_id) References __Employee (emp_id)
)

create table __Account (
	acc_id varchar(10) Primary Key, 
	password varchar(255),
	emp_id varchar(10),
	Constraint FK_Account_Employee Foreign Key (emp_id) References __Employee (emp_id)
)

Insert into __Account values ('admin', '9952811', 'EMP001')

Insert into __Employee values ('EMP001', 'Sheldon Kuo', 'sheldon1247@gmail.com', '0767916592', '94/20 TL 16', 16000000, '2022-12-02')
Insert into __Employee values ('EMP002', 'Thong Nguyen', 'ntttt33@gmail.com', '0953838532', '...', 24000000, '2022-04-22')