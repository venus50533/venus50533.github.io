USE [Northwind]

--1 �C�X�U���~�������ӦW��
select CompanyName from Suppliers
--2 �C�X�U���~�������W��
select CategoryName from Categories
--3 �C�X�U�q�檺�U�ȦW�r
select distinct c.ContactName from Orders o
inner join Customers c on c.CustomerID = o.CustomerID
--4 �C�X�U�q�檺�ҭt�d�����y�ӦW�r�H�έ��u�W�r
select 
FirstName+' '+LastName as EmpName,
ShipName
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
inner join Shippers s on s.ShipperID = o.ShipVia
--5 �C�X1998�~���q�� **�w�ץ�

SELECT * FROM Orders
WHERE YEAR(OrderDate) = '1998';

--6 �U���~�AUnitsInStock < UnitsOnOrder ���'�Ѥ����D'�A�_�h���'���`'
select 
ProductName,UnitsInStock,UnitsOnOrder,
	case
		when UnitsInStock < UnitsOnOrder then '�Ѥ����D'
		else '���`'
	end as status
from Products
--7 ���o�q�����̷s��9���q��
select top 9 with ties * from Orders order by OrderDate desc
--8 ���~����̫K�y����4~8�W
SELECT ProductID, UnitPrice FROM Products ORDER BY UnitPrice
OFFSET 3 ROWS FETCH NEXT 5 ROWS only
--9 �C�X�C�����O���̰�������ӫ~
--�ˬd select CategoryID,max(UnitPrice) from Products group by CategoryID
select 
CategoryID,ProductName,UnitPrice 
from Products 
where UnitPrice in(
	select max(UnitPrice) from Products group by CategoryID
) order by CategoryID

--10 �C�X�C�ӭq�檺�`���B
select OrderID,sum(UnitPrice*(1-Discount)*Quantity) as Total 
from [Order Details] group by OrderID
--11 �C�X�C�Ӫ��y�Ӱe�L���q�浧��  ***id v 
select ShipName,count(*)as OrderCount from Orders group by ShipName
--12 �C�X�Q�U�q���Ƥp��9�������~
select ProductID,count(OrderID) as Total
from [Order Details] group by ProductID
having count(OrderID) < 9
-- (13�B14�B15�Ф@�_�g)
--13 �s�W���y��(Shippers)�G
-- ���q�W��: �C���H�~�A�q��: (02)66057606
-- ���q�W��: �C�s��ޡA�q��: (02)14055374
insert into Shippers values ('�C���H�~','(02)66057606')
insert into Shippers values ('�C�s���','(02)14055374')
--14 ��~�s�W���ⵧ��ơA�q�ܳ��令(02)66057606�A���q�W�ٵ����['�������q'
select * from Shippers
update Shippers set CompanyName ='�C���H�~�������q',Phone ='(02)66057606' where CompanyName ='�C���H�~'
update Shippers set CompanyName ='�C�s��ަ������q',Phone ='(02)66057606' where CompanyName ='�C�s���'
--15 �R����~�ⵧ���
delete from Shippers where CompanyName in ('�C���H�~�������q','�C�s��ަ������q')

