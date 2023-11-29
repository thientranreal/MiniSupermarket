CREATE TABLE [dbo].[Bill](
	[BillID] [varchar](10) NOT NULL,
	[Date] [datetime] NOT NULL,
	[EmployeeID] [varchar](10) NOT NULL,
	[CustomerID] [varchar](10) NOT NULL,
	[EstimatedPrice] [float] NOT NULL,
	[ReducePrice] [float] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[Point] [int] NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailBill]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailBill](
	[BillID] [varchar](10) NOT NULL,
	[ProductID] [varchar](10) NOT NULL,
	[OrderID] [varchar](10) NOT NULL,
	[SalePrice] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BillID] ASC,
	[ProductID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailPurchaseOrder]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailPurchaseOrder](
	[ProductID] [varchar](10) NOT NULL,
	[OrderID] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[PurchasePrice] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeRole]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeRole](
	[EmployeeID] [varchar](10) NOT NULL,
	[RoleID] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Functions]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Functions](
	[FunctionID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[FunctionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[ProductID] [varchar](10) NOT NULL,
	[OrderID] [varchar](10) NOT NULL,
	[CurrentQuantity] [int] NOT NULL,
	[ExpiredDate] [datetime] NOT NULL,
	[isDisplayed] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[TypeID] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[CurrentPrice] [float] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Unit] [nvarchar](20) NOT NULL,
	[Image] [varchar](50) NULL,
	[isDeleted] [tinyint] NOT NULL,
	[PromotionID] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[TypeID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[PromotionID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Discount] [float] NOT NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PromotionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrder](
	[OrderID] [varchar](10) NOT NULL,
	[EmployeeID] [varchar](10) NOT NULL,
	[SupplierID] [varchar](50) NOT NULL,
	[importDate] [datetime] NOT NULL,
	[TotalPrice] [float] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleFunction]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleFunction](
	[RoleID] [varchar](10) NOT NULL,
	[FunctionID] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FunctionID] ASC,
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[SupplierID] [varchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[isDeleted] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierProduct]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierProduct](
	[SupplierID] [varchar](50) NOT NULL,
	[ProductID] [varchar](10) NOT NULL,
	[SupplyStartDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Đếm số account
CREATE PROCEDURE [dbo].[CountAccount]
    @UserName NVARCHAR(50),
    @Password NVARCHAR(50)
AS
BEGIN
    SELECT COUNT(*)
    FROM Employee
    WHERE UserName = @UserName AND Password = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomer]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomer]
    @CustomerID VARCHAR(10)
AS
BEGIN
    -- Your query to delete a customer by CustomerID
    DELETE FROM customer WHERE CustomerID = @CustomerID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Xóa sản phẩm 
CREATE PROCEDURE [dbo].[DeleteProduct]
    @ProductID varchar(10)
AS
BEGIN
    UPDATE Product
    SET isDeleted = 0
    WHERE ProductID = @ProductID
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductType]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Delete ProductType
CREATE PROCEDURE [dbo].[DeleteProductType]
    @TypeID varchar(10)
AS
BEGIN
	UPDATE ProductType SET isDeleted = 0 WHERE TypeID = @TypeID
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllDetailBills]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllDetailBills]
AS
BEGIN
    SELECT
        [BillID],
        [ProductID],
        [OrderID],
        [SalePrice],
        [Quantity]
    FROM
        [DetailBill];
END;
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerCount]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerCount]
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CustomerCount INT;

    -- Your query to get the customer count
    SELECT @CustomerCount = COUNT(*) FROM customer WHERE isDeleted = 0;

    -- Return the result
    SELECT @CustomerCount AS CustomerCount;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomer]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCustomer]
    @CustomerID VARCHAR(10),
    @Name NVARCHAR(MAX),
    @PhoneNumber NVARCHAR(MAX),
    @Sex NVARCHAR(10),
    @Point INT = NULL,  -- Set a default value to allow NULL
    @isDeleted BIT
AS
BEGIN
    -- Your query to insert a new customer
    INSERT INTO customer (CustomerID, Name, PhoneNumber, Sex, Point, isDeleted)
    VALUES (@CustomerID, @Name, @PhoneNumber, @Sex, COALESCE(@Point, 0), @isDeleted);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomerSale]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Thêm khách hàng cho hóa đơn
CREATE PROC [dbo].[InsertCustomerSale]
	@CustomerID varchar(10),
	@Name nvarchar(50),
	@PhoneNumber varchar(50),
	@Sex nvarchar(10)
AS
BEGIN
	INSERT INTO Customer(CustomerID, [Name], PhoneNumber, Sex)
	VALUES (@CustomerID, @Name, @PhoneNumber, @Sex)
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertIntoBill]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Thêm một bill mới
CREATE PROCEDURE [dbo].[InsertIntoBill]
	@BillID varchar(10),
	@Date datetime,
	@EmployeeID varchar(10),
	@CustomerID varchar(10) = NULL
AS

BEGIN
	INSERT INTO Bill(BillID, [Date], EmployeeID, CustomerID)
	VALUES (@BillID, @Date, @EmployeeID, @CustomerID)
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertIntoProduct]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thêm sản phẩm
CREATE PROCEDURE [dbo].[InsertIntoProduct]
    @ProductID varchar(10),
    @Name nvarchar(50),
    @TypeID varchar(10),
    @Quantity int,
    @CurrentPrice float(53),
    @Description nvarchar(100),
    @Unit nvarchar(20),
    @Image varchar(50),
	@PromotionID varchar(10)
    
AS
BEGIN
    INSERT INTO Product (ProductID, [Name], TypeID, Quantity, CurrentPrice, [Description], Unit, [Image],PromotionID)
    VALUES (@ProductID, @Name, @TypeID, @Quantity, @CurrentPrice, @Description, @Unit, @Image, @PromotionID )
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertIntoProductType]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert Into ProductType
CREATE PROCEDURE [dbo].[InsertIntoProductType]
    @TypeID varchar(10),
	@Name nvarchar(50)
AS
BEGIN
    INSERT INTO ProductType(TypeID, [Name])
    VALUES (@TypeID, @Name)
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertPromotion]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Thêm chương trình khuyến mãi
CREATE PROC [dbo].[InsertPromotion]
	@PromotionID nvarchar(10),
	@Name nvarchar(50),
	@StartDate datetime,
	@EndDate datetime,
	@Discount float(50)
AS
BEGIN
	INSERT INTO Promotion(PromotionID,[Name],StartDate,EndDate,Discount)
	VALUES (@PromotionID,@Name,@StartDate,@EndDate,@Discount)
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllBills]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy tất cả thông tin hóa đơn
CREATE PROCEDURE dbo.SelectAllBills
AS
BEGIN
    SELECT 
        Bill.BillID,
        Bill.[Date],
        Bill.EmployeeID,
        Employee.[Name] AS EmployeeName,
        Bill.CustomerID,
        Customer.[Name] AS CustomerName,
        Bill.EstimatedPrice,
        Bill.ReducePrice,
        Bill.TotalPrice,
        Bill.[Status],
		Bill.isDeleted
    FROM 
        Bill
        INNER JOIN Employee ON Bill.EmployeeID = Employee.EmployeeID
        LEFT JOIN Customer ON Bill.CustomerID = Customer.CustomerID
    
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllCustomer]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllCustomer]
AS
BEGIN
    SELECT * FROM Customer;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllEmployee]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllEmployee]
AS
BEGIN
    SELECT EmployeeID, Name, Address, PhoneNumber, Email, Sex, UserName, Password, isDeleted
    FROM Employee;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllFromProduct]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Công Anh 

--Lấy danh sách sản phẩm 
CREATE PROCEDURE [dbo].[SelectAllFromProduct]
AS
BEGIN
    SELECT
        ProductID,
        [Name],
        TypeID,
        Quantity,
        CurrentPrice,
        [Description],
        Unit,
        [Image],
        isDeleted,
        PromotionID
    FROM Product
    WHERE isDeleted = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllFromProductType]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Tạo các procedures
-- Select * from ProductType
CREATE PROCEDURE [dbo].[SelectAllFromProductType]
AS
BEGIN
    SELECT TypeID, [Name] FROM ProductType Where isDeleted = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllPromotions]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllPromotions]
AS
BEGIN
    SELECT * FROM Promotion;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectAllSupplier]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllSupplier]
AS
BEGIN
    SELECT SupplierID, Name, Address, PhoneNumber, Email, isDeleted
    FROM Supplier;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectCustomerIdAndName]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy mã KH và tên KH
CREATE PROCEDURE [dbo].[SelectCustomerIdAndName]
AS
BEGIN
	SELECT CustomerID, [Name]
	FROM Customer
    WHERE isDeleted = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectFunctionNameFromAccount]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy các chức năng từ account
CREATE PROCEDURE [dbo].[SelectFunctionNameFromAccount]
    @UserName varchar(50),
	@Password varchar(50)
AS
BEGIN
	SELECT Functions.[Name]
	FROM Employee, EmployeeRole, [Role], RoleFunction, Functions
    Where Employee.EmployeeID = EmployeeRole.EmployeeID 
	AND EmployeeRole.RoleID = [Role].RoleID
    AND [Role].RoleID = RoleFunction.RoleID
    AND RoleFunction.FunctionID = Functions.FunctionID
    AND UserName = @UserName AND [Password] = @Password
    AND Employee.IsDeleted = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectInfoFromAccount]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy thông tin tài khoản từ username
CREATE PROCEDURE [dbo].[SelectInfoFromAccount]
    @userName varchar(50)
AS
BEGIN
	SELECT EmployeeID, [Name], [Address], PhoneNumber, Email
    FROM Employee Where UserName = @userName
    AND Employee.IsDeleted = 1
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccountInfor]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cập nhật thông tin tài khoản
CREATE PROCEDURE [dbo].[UpdateAccountInfor]
    @EmployeeId varchar(10),
	@address nvarchar(50),
	@phone varchar(50),
	@email varchar(50)
AS
BEGIN
	UPDATE Employee SET [Address] = @address, PhoneNumber = @phone, Email = @email
    WHERE EmployeeID = @EmployeeId
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateAccountPassword]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Cập nhật mật khẩu tài khoản
CREATE PROCEDURE [dbo].[UpdateAccountPassword]
    @EmployeeId varchar(10),
	@Password varchar(50)
AS
BEGIN
	UPDATE Employee SET Password = @Password
    WHERE EmployeeID = @EmployeeId
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomer]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomer]
    @CustomerID VARCHAR(10),
    @Name NVARCHAR(MAX),
    @PhoneNumber NVARCHAR(MAX),
    @Sex NVARCHAR(10),
    @Point INT = NULL,  -- Set a default value to allow NULL
    @isDeleted BIT
AS
BEGIN
    -- Your query to update customer information by CustomerID
    UPDATE customer
    SET
        Name = @Name,
        PhoneNumber = @PhoneNumber,
        Sex = @Sex,
        Point = COALESCE(@Point, 0),
        isDeleted = @isDeleted
    WHERE
        CustomerID = @CustomerID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Cập nhật sản phẩm
CREATE PROCEDURE [dbo].[UpdateProduct]
    @ProductID varchar(10),
    @Name nvarchar(50),
    @TypeID varchar(10),
    @Quantity int,
    @CurrentPrice float(53),
    @Description nvarchar(100),
    @Unit nvarchar(20),
    @Image varchar(50),
	@PromotionID varchar(10)
    
AS
BEGIN
    UPDATE Product
    SET
        [Name] = @Name,
        TypeID = @TypeID,
        Quantity = @Quantity,
        CurrentPrice = @CurrentPrice,
        [Description] = @Description,
        Unit = @Unit,
        [Image] = @Image,
		PromotionID = @PromotionID
        
    WHERE ProductID = @ProductID
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateProductType]    Script Date: 11/29/2023 5:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update ProductType
CREATE PROCEDURE [dbo].[UpdateProductType]
    @TypeID varchar(10),
	@Name nvarchar(50)
AS
BEGIN
	UPDATE ProductType SET [Name] = @Name WHERE TypeID = @TypeID
END;
GO
USE [master]
GO
ALTER DATABASE [MarketMiniManager] SET  READ_WRITE 
GO
