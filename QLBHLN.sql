create database DAQLBH
use DAQLBH

create table tblCodeMaterials
(
	CodeMaterialID int primary key  IDENTITY(1,1),
	CodeMaterialName  nvarchar(30),
	sources nvarchar(30),
	Description nvarchar(250)
)

create table tblCustomers
(
	CustomerID int primary key  IDENTITY(1,1),
	FullName nvarchar(30),
	Address nvarchar(30),
	Phone nvarchar(10),
	Description nvarchar(250)
)

create table tblGoods
(
	GoodID int primary key  IDENTITY(1,1),
	GoodName nvarchar(30),
	CodeMaterialID int not null
			FOREIGN KEY (CodeMaterialID) REFERENCES tblCodeMaterials (CodeMaterialID),
	Amount int,
	priceImport nvarchar,
	priceSell nvarchar,
	-- đưa ảnh vào csdl
	Photos varbinary(max),
	Description nvarchar(200)
)

create table tblUsers
(
	UserID int primary key  IDENTITY(1,1),
	FullName nvarchar(20),
	UserName nvarchar(20),
	Password nvarchar(20),
	Gender nvarchar(5),
	Address nvarchar(30),
	Phone nvarchar(10),
	Date Datetime,
	Description nvarchar(250)
)

create table tblOrders
(
	OrderID int primary key  IDENTITY(1,1),
	UserID int not null
	 CONSTRAINT	UserID FOREIGN KEY (UserID) REFERENCES tblUsers (UserID)	
				ON DELETE CASCADE,
	date nvarchar(30),
	GoodID int not null
	FOREIGN KEY (GoodID) REFERENCES tblGoods (GoodID),
	money nvarchar(50),
	Description nvarchar(250)
)
drop table tblOrders
create table tblOrdersDetails
(
	OrderID int not null
	constraint OrderID
		FOREIGN KEY (OrderID) REFERENCES tblOrders (OrderID)
		ON DELETE CASCADE ,
	customerID int not null
	constraint CustomerID	
		FOREIGN KEY (CustomerID) REFERENCES tblCustomers (CustomerID)
		ON DELETE CASCADE ,
	Amount nvarchar,
	Price nvarchar(30),
	Discount nvarchar(30),
	money nvarchar(30),
	CONSTRAINT tblOrdersDetail PRIMARY KEY (OrderID,CustomerID),
	Description nvarchar(250)
)
insert into tblUsers values
(N'Nguyễn văn minh','M','01','Nam','','','','')
