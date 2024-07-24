USE [Northwind]

--1 列出各產品的供應商名稱
select CompanyName from Suppliers
--2 列出各產品的種類名稱
select CategoryName from Categories
--3 列出各訂單的顧客名字
select distinct c.ContactName from Orders o
inner join Customers c on c.CustomerID = o.CustomerID
--4 列出各訂單的所負責的物流商名字以及員工名字
select 
FirstName+' '+LastName as EmpName,
ShipName
from Orders o
inner join Employees e on o.EmployeeID = e.EmployeeID
inner join Shippers s on s.ShipperID = o.ShipVia
--5 列出1998年的訂單 **已修正

SELECT * FROM Orders
WHERE YEAR(OrderDate) = '1998';

--6 各產品，UnitsInStock < UnitsOnOrder 顯示'供不應求'，否則顯示'正常'
select 
ProductName,UnitsInStock,UnitsOnOrder,
	case
		when UnitsInStock < UnitsOnOrder then '供不應求'
		else '正常'
	end as status
from Products
--7 取得訂單日期最新的9筆訂單
select top 9 with ties * from Orders order by OrderDate desc
--8 產品單價最便宜的第4~8名
SELECT ProductID, UnitPrice FROM Products ORDER BY UnitPrice
OFFSET 3 ROWS FETCH NEXT 5 ROWS only
--9 列出每種類別中最高單價的商品
--檢查 select CategoryID,max(UnitPrice) from Products group by CategoryID
select 
CategoryID,ProductName,UnitPrice 
from Products 
where UnitPrice in(
	select max(UnitPrice) from Products group by CategoryID
) order by CategoryID

--10 列出每個訂單的總金額
select OrderID,sum(UnitPrice*(1-Discount)*Quantity) as Total 
from [Order Details] group by OrderID
--11 列出每個物流商送過的訂單筆數  ***id v 
select ShipName,count(*)as OrderCount from Orders group by ShipName
--12 列出被下訂次數小於9次的產品
select ProductID,count(OrderID) as Total
from [Order Details] group by ProductID
having count(OrderID) < 9
-- (13、14、15請一起寫)
--13 新增物流商(Shippers)：
-- 公司名稱: 青杉人才，電話: (02)66057606
-- 公司名稱: 青群科技，電話: (02)14055374
insert into Shippers values ('青杉人才','(02)66057606')
insert into Shippers values ('青群科技','(02)14055374')
--14 方才新增的兩筆資料，電話都改成(02)66057606，公司名稱結尾加'有限公司'
select * from Shippers
update Shippers set CompanyName ='青杉人才有限公司',Phone ='(02)66057606' where CompanyName ='青杉人才'
update Shippers set CompanyName ='青群科技有限公司',Phone ='(02)66057606' where CompanyName ='青群科技'
--15 刪除剛才兩筆資料
delete from Shippers where CompanyName in ('青杉人才有限公司','青群科技有限公司')

