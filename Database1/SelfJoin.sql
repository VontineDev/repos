-- note there's no employee table, so we'll create one for this example
create table SalesLT.Employee
(EmployeeID int identity primary key,
EmployeeName nvarchar(256),
ManagerID int);
Go

-- Get salesperson from Customer table and generate managers
insert into SalesLT.Employee (EmployeeName, ManagerID)
select distinct Salesperson, nullif(cast(Right(Salesperson,1) as int), 0)
from SalesLT.Customer;
Go
update SalesLT.Employee
set ManagerID = (select min(EmployeeId) from SalesLT.Employee where ManagerID is null)
where ManagerID is null
and EmployeeId > (select min(EmployeeId) from SalesLT.Employee where ManagerID is null);
Go

select * from SalesLT.Employee;

-- Hers's the actual self-join demo
select e.EmployeeName,m.EmployeeName as ManagerName
from SalesLT.Employee as e
left join SalesLT.Employee as m
on e.ManagerID = m.EmployeeId
order by e.ManagerID;