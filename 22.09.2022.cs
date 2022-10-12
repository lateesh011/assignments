use library
create table member_c(
member_id numeric(5) not null constraint pk_member_c primary key,
member_name char(25),
Acc_open_date date,
maxbooksallowed numeric constraint pk_maxbooks check(maxbooksallowed<=100),
penaltyamount numeric(7,2) constraint pk_penalty check(penaltyamount<=1000)
)

create table Book_c(Book_No numeric(6) constraint pk_book1 primary key,
Book_Name varchar(30) not null,
Category Char(10))

create table Issue_c(Lib_Issue_Id	numeric(10) constraint pk_issue1 primary key,
Book_No numeric(6) constraint pk_bk1 foreign key references Book_c(Book_No),
Member_Id numeric(5) constraint pk_mem1 foreign key references member_c(member_id),
Issue_Date Date,
Return_date Date,
constraint pk_check1 check(Return_date>Issue_date))

Alter table Book_c
add Cost int constraint pk_price check(Cost<=2500)

SELECT CONSTRAINT_NAME, CONSTRAINT_TYPE
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME='Issue_c';

insert into member_c values(1,'Richa sharma','2005-12-10',15,50)
insert into member_c values(2,'Nupur sharma',cast(GETDATE()as date),13,null)
insert into member_c values(3,'Garima Sen','2006-8-10',17,30)
insert into member_c values(4,'Kareena Kapoor','2007-9-20',18,20)
insert into member_c values(5,'Anjali','2008-10-25',31,50)

Alter table Book_c
add author nvarchar(20)
insert into Book_c(Book_No,Book_Name,author,Cost,Category) values(101,'Let us C','Denis Ritchie',450,'System')
insert into Book_c(Book_No,Book_Name,author,Cost,Category) values(102,'Oracle – Complete Ref','Loni',550,'Database')
insert into Book_c(Book_No,Book_Name,author,Cost,Category) values(103,'Mastering SQL','Loni',250,'Database')
insert into Book_c(Book_No,Book_Name,author,Cost,Category) values(104,'PL SQL-Ref','Scott Urman',750,'Database')

Select * from Book_c
Insert into issue_c(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values(7001,101,1,'2006-12-10')
Insert into issue_c(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values(7002,102,2,'2006-12-25')
Insert into issue_c(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values(7003,104,1,	'2006-01-06')
Insert into issue_c(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values(7004,101,1,'2006-07-04')
Insert into issue_c(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values(7005,104,2,'2006-11-15')
Insert into issue_c(Lib_Issue_Id,Book_No,Member_Id,Issue_Date) values(7006,101,3,'2006-02-18')
update issue_c set Return_date=DATEADD(DAY,15,Issue_Date) where Lib_Issue_Id in (7004,7005)
update issue_c set Return_date='2006-12-31' where Lib_Issue_Id not in (7004,7005)
select * from issue_c
create view v_issue as 
select i.Lib_Issue_Id,j.Book_Name,k.Member_Name,j.Author,i.Issue_date from issue_c i inner join Book_c j on i.Book_No=j.Book_No inner join member_c k on i.member_id=k.member_id where j.Cost between 500 and 750 and j.Category in('Database','RDBMS')

select * from v_issue

create view v_issue01 as
select * from Book where Cost>500

select * from v_issue01

insert into v_issue01 values(107,'Programming with C#','Layman',3000,'Data')

create nonclustered index  pk_Book11 on Book_c(Book_name)

select Book_name from Book_c where Book_Name='PL SQL-Ref'
 select * from Book_c

create unique index  pk_issue12 on issue_c(member_id,Book_No)
Delete from issue_c where Lib_Issue_Id=7004
Select * from issue_c

--values in column in which unique index can be applied needs to be unique..others could be implemented on any column

--member_id in member_c is a primary key.so a clustered index could be created automatically..so we don't need to create it explicitly
