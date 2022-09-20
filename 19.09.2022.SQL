create database shopping
use shopping

create table customer
(
custid int,
custname varchar(20),
city varchar(20),
state varchar(20)
)
alter table customer
drop column custid
alter table customer
add custid int primary key
create table products
(
prodid int,
prodname varchar(20),
unitprice int,
UnitOfMeasurement int,
QtyinStock int
)
alter table products
drop column prodid
alter table products
add prodid int primary key
create table sales_header
(
invno int,
invdate date,
invamt int,
disPercent int
)
alter table sales_header
drop column invno
alter table sales_header
add invno int primary key
 
create table sales_detail
(
custid int ,
prodid int ,
qtysold int 
)
alter table sales_detail
add invno int foreign key References sales_header

alter table sales_detail
drop column custid
alter table sales_detail
drop column prodid
alter table sales_detail
drop column qtysold
alter table sales_detail
add Qty int
alter table sales_detail
add custid int foreign key References customer

alter table sales_detail
add prodid int foreign key References products