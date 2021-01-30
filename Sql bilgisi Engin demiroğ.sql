--Select (-- Yorum Satırıdır.)
SELECT ContactName Adi,CompanyName Sirketadi,City Sehir FROM Customers

Select * from Customers where City='Berlin' 

--case insensitive büyük küçük harfine duyarsız 
Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice<=15

Select * from Products order by UnitPrice asc   --ascending(artan demek)

Select * from Products where CategoryID=1 order by UnitPrice desc --descending(azalan(düşen) demek)

select COUNT(*) Adet from Products where CategoryID=2

select CategoryID,COUNT(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10 --Group by select * from olmaz

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories on  Products.CategoryID =Categories.CategoryID
where Products.UnitPrice>10

-- DTO Data Trasformation object

select * from Products p inner join [Order Details] od --solda olup sagda ollmayanlarıda getir.
on p.ProductID= od.ProductID
inner join Orders o
on o.OrderID=od.OrderID


select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null



