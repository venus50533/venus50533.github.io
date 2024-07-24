--1. 會員表（Members）
create table Members(
	MemberID int PRIMARY KEY IDENTITY(1,1) ,
	Username NVARCHAR(50) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	PhoneNumber NVARCHAR(15),
	Address NVARCHAR(255),
	Gender NVARCHAR(10)CHECK(Gender IN ('Male','Female','Other')),
	Birthday DATE,
	ShopeeCoins DECIMAL(10,2) DEFAULT 0
);
--2. 會員角色表(Roles)
CREATE TABLE Roles(
	RoleID INT PRIMARY KEY IDENTITY(1,1),
	MemberID INT FOREIGN KEY REFERENCES Members(MemberID),
	RoleType NVARCHAR(20) CHECK (RoleType IN ('Buyer','Saller'))
);
--3. 付款資訊表（PaymentInfo）
CREATE TABLE PaymentInfo(
	PaymentInfoID INT PRIMARY KEY IDENTITY(1,1),
	MemberID INT FOREIGN KEY REFERENCES Members(MemberID),
	PaymentType NVARCHAR(20) CHECK (PaymentType IN ('CreditCard','DebitCard','cashOnDelivery')),
	CardNumber NVARCHAR(16),
	ExpirDate DATE,
	eInvoiceCode NVARCHAR(20)
);
--3.地址表（Addresses）
CREATE TABLE Addresses(
	AddressID INT PRIMARY KEY IDENTITY(1,1),
	MemberID INT FOREIGN KEY REFERENCES Members(MemberID),
	AddressType NVARCHAR(20) CHECK (AddressType IN ('Home','ConvenienceStore')),
	Address NVARCHAR(255)
);
--4. 商品分類表（Categories）
CREATE TABLE Categories(
	CategoryID INT PRIMARY KEY IDENTITY(1,1),
	CategoryName NVARCHAR(100) NOT NULL
);
--5. 商品表（Products）
CREATE TABLE Products(
	ProductID INT PRIMARY KEY IDENTITY(1,1),
	SellerID INT FOREIGN KEY REFERENCES Members(MemberID), --可以是買家也可以是賣家
	ProductName NVARCHAR(100) NOT NULL,
	Description NVARCHAR(1000),
	Price DECIMAL(10,2) NOT NULL, --(總位數,小數後位數)
	CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
	Stock INT NOT NULL,
	CreatedAt DATETIME DEFAULT GETDATE(),
	ProductStatus NVARCHAR(20) CHECK (ProductStatus IN ('Normal','LimtedTimeOffer')),
	Discount DECIMAL(10,2) DEFAULT 0,
	Rating DECIMAL(2,1) DEFAULT 0,
	SoldQuantity INT DEFAULT 0
	);
--6. 購物車表（ShoppingCart）
CREATE TABLE ShoppingCart(
	CartID INT PRIMARY KEY IDENTITY(1,1),
	MemberID INT FOREIGN KEY REFERENCES Members(MemberID),
	ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
	Quantity INT NOT NULL,
	AddedAt DATETIME DEFAULT GETDATE()
);
--7. 訂單表（Orders）
CREATE TABLE Orders(
	OrderID INT PRIMARY KEY IDENTITY(1,1),
	MemberID INT FOREIGN KEY REFERENCES Members(MemberID),
	OrderDate DATETIME DEFAULT GETDATE(),
	TotalAmount DECIMAL(10,2) NOT NULL,
	Status NVARCHAR(20) CHECK (
	Status IN ('PendingPayment','PendingShipment',
				'Shipped','Completed','Cancelled','Returned'))
				--待付款、待出貨、待收貨、已完成、取消、退貨/退款
);
--8. 訂單詳情表（OrderDetails）
CREATE TABLE OrderDetails(
	OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
	Quantity INT NOT NULL,
	UnitPrice DECIMAL(10,2) NOT NULL,
	TotalPrice AS (Quantity*UnitPrice) PERSISTED --可以記錄自動計算結果，性能較佳
);
--9. 優惠卷表（Coupons）
CREATE TABLE Coupons(
	CouponsID INT PRIMARY KEY,
	MemberID INT FOREIGN KEY REFERENCES MeMbers(MemberID),
	CouponsCode NVARCHAR(50) NOT NULL,
	DiscountAmount DECIMAL(10,2),
	ExpiryDate DATE
);

--10. 錢包表（Wallet）
CREATE TABLE Wallet(
	WalletID INT PRIMARY KEY IDENTITY(1,1),
	MemberID int FOREIGN KEY REFERENCES Members(MemberID),
	AvailableAmount DECIMAL(10,2) DEFAULT 0,
	TransactionDate DATETIME DEFAULT GETDATE(),
	TransactionType NVARCHAR(20) CHECK (TransactionType IN('OrderIncome','Withdrawal','Refund','Adjustment','WalletPayment'))
);--????
--11. 銷售表（Sales）賣家
CREATE TABLE Sales(
	SalesID INT PRIMARY KEY IDENTITY(1,1),
	SallerID INT FOREIGN KEY REFERENCES Members(MemberID),
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	SalesAmount DECIMAL(10,2),
	SalesStatus NVARCHAR(20),
	ShippingMethod NVARCHAR(50),
	TrackingNumber NVARCHAR(50),
	SaleDate DATETIME DEFAULT GETDATE()
);
--12. 商品照片表（ProductPhotos）
CREATE TABLE ProductPhotos(
	PhotoID INT PRIMARY KEY IDENTITY(1,1),
	ProductID INT FOREIGN KEY REFERENCES Products(ProductID),
	PhotoURL NVARCHAR(255)
);