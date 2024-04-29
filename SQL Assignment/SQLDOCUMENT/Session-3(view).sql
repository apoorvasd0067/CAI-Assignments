create table Department(Department varchar(20), DepartmentHead varchar(20));


Alter table Department 
alter Column DepartmentHead varchar(50);

Insert into Department values('IT','John Doe Smith'),
('Sales', 'Emma Rose Wilson'),
('Marketing', 'Emily Grace Davis'),
('HR', 'Jane Lee Johnson'),
('Finance', 'Michael James Brown');

create view ViewByDepartment as 
select D.Department, T.EmployeeNumber, T.TransactionDate, T.Amount as TotalAmount
from Department as D
left join tblEmployee as E
on D.Department = E.Department
left join tblTransaction as T
on E.EmployeeNumber = T.EmployeeNumber
where T.EmployeeNumber between 120 and 139

create view VByDepartment as 
select D.Department, T.EmployeeNumber, T.TransactionDate, T.Amount as TotalAmount
from Department as D
left join tblEmployee as E
on D.Department = E.Department
left join tblTransaction as T
on E.EmployeeNumber = T.EmployeeNumber
where T.EmployeeNumber between 530 and 534

if exists(select * from INFORMATION_SCHEMA.VIEWS
where [TABLE_NAME] = 'ViewByDepartment' and [TABLE_SCHEMA] = 'dbo')
   drop view dbo.ViewByDepartment
go

insert into tblTransaction values
(6, 130, 100.00, '2024-04-25'),
(7, 135, 200.00, '2024-04-25'),
(8, 131, 400.00, '2024-04-25'),
(9, 132, 500.00, '2024-04-25'),
(10, 124, 300.00, '2024-04-25'),
(11, 133, 200.00, '2024-04-25'),
(12, 126, 300.00, '2024-04-25'),
(13, 137, 500.00, '2024-04-25'),
(14, 138, 200.00, '2024-04-25'),
(15, 134, 400.00, '2024-04-25');



CREATE view [dbo].[ViewByDepartment] as 
select D.Department, T.EmployeeNumber, T.TransactionDate, T.Amount as TotalAmount
from Department as D
left join tblEmployee as E
on D.Department = E.Department
left join tblTransaction as T
on E.EmployeeNumber = T.EmployeeNumber
where T.EmployeeNumber between 120 and 139
--order by D.Department, T.EmployeeNumber
GO

begin tran

insert into ViewByDepartment(EmployeeNumber,TransactionDate,TotalAmount)
values (132,'2015-07-07', 999.99);

select * from ViewByDepartment order by Department, EmployeeNumber

rollback tran


SELECT * FROM ViewByDepartment
delete from ViewByDepartment
where TotalAmount = 999.99 and EmployeeNumber = 132
GO
CREATE VIEW ViewSimple
as
SELECT * FROM tblTransaction
GO
BEGIN TRAN
delete from ViewSimple
where EmployeeNumber = 132
select * from ViewSimple
ROLLBACK TRAN

if exists(select * from INFORMATION_SCHEMA.VIEWS
where [TABLE_NAME] = 'ViewByDepartment' and [TABLE_SCHEMA] = 'dbo')
   drop view dbo.ViewByDepartment
go

CREATE view [dbo].[ViewByDepartment] with schemabinding as 
select D.Department, T.EmployeeNumber, T.TransactionDate, T.Amount as TotalAmount
from dbo.Department as D
inner join dbo.tblEmployee as E
on D.Department = E.Department
inner join dbo.tblTransaction as T
on E.EmployeeNumber = T.EmployeeNumber
where T.EmployeeNumber between 120 and 139
GO

CREATE UNIQUE CLUSTERED INDEX inx_ViewByDepartment on dbo.ViewByDepartment(EmployeeNumber, Department)

begin tran
drop table tblEmployee
rollback tran


begin tran
--SELECT * FROM ViewByDepartment where TotalAmount = -2.77 and EmployeeNumber = 132
delete from ViewByDepartment
where TotalAmount = -2.77 and EmployeeNumber = 132
SELECT * FROM ViewByDepartment where TotalAmount = -2.77 and EmployeeNumber = 132
rollback tran
