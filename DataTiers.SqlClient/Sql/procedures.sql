


-- Procedures for table: Categories
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Category_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Category_Get_All]
GO

CREATE PROCEDURE [sp_cw_Category_Get_All]
AS
    SELECT 
	[CategoryID],	 
	[CategoryName],	 
	[Description],	 
	[Picture]	    FROM
	
	[Categories]

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Category_Get_ByCategoryName]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Category_Get_ByCategoryName]
GO

CREATE PROCEDURE [sp_cw_Category_Get_ByCategoryName]
(
		@CategoryName NVarChar (15)	
	
)
AS
    SELECT 
	[CategoryID],	 
	[CategoryName],	 
	[Description],	 
	[Picture]		
    FROM
	[Categories]
	WHERE
		CategoryName = @CategoryName
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Category_Get_ByCategoryID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Category_Get_ByCategoryID]
GO

CREATE PROCEDURE [sp_cw_Category_Get_ByCategoryID]
(
		@CategoryID Int	
	
)
AS
    SELECT 
	[CategoryID],	 
	[CategoryName],	 
	[Description],	 
	[Picture]		
    FROM
	[Categories]
	WHERE
		CategoryID = @CategoryID
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: CustomerCustomerDemo
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_CustomerCustomerDemo_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_CustomerCustomerDemo_Get_All]
GO

CREATE PROCEDURE [sp_cw_CustomerCustomerDemo_Get_All]
AS
    SELECT 
	[CustomerID],	 
	[CustomerTypeID]	    FROM
	
	[CustomerCustomerDemo]

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_CustomerCustomerDemo_Get_ByCustomerID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_CustomerCustomerDemo_Get_ByCustomerID]
GO

CREATE PROCEDURE [sp_cw_CustomerCustomerDemo_Get_ByCustomerID]
(
	@CustomerID NChar (5)
)
AS
    SELECT 
	[CustomerID],	 
	[CustomerTypeID]		
    FROM
	[CustomerCustomerDemo]
	WHERE
	CustomerID = @CustomerID

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_CustomerCustomerDemo_Get_ByCustomerTypeID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_CustomerCustomerDemo_Get_ByCustomerTypeID]
GO

CREATE PROCEDURE [sp_cw_CustomerCustomerDemo_Get_ByCustomerTypeID]
(
	@CustomerTypeID NChar (10)
)
AS
    SELECT 
	[CustomerID],	 
	[CustomerTypeID]		
    FROM
	[CustomerCustomerDemo]
	WHERE
	CustomerTypeID = @CustomerTypeID

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_CustomerCustomerDemo_Get_ByCustomerIDCustomerTypeID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_CustomerCustomerDemo_Get_ByCustomerIDCustomerTypeID]
GO

CREATE PROCEDURE [sp_cw_CustomerCustomerDemo_Get_ByCustomerIDCustomerTypeID]
(
		@CustomerID NChar (5),	
		@CustomerTypeID NChar (10)	
	
)
AS
    SELECT 
	[CustomerID],	 
	[CustomerTypeID]		
    FROM
	[CustomerCustomerDemo]
	WHERE
		CustomerID = @CustomerID
		AND CustomerTypeID = @CustomerTypeID
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: CustomerDemographics
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_CustomerDemographic_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_CustomerDemographic_Get_All]
GO

CREATE PROCEDURE [sp_cw_CustomerDemographic_Get_All]
AS
    SELECT 
	[CustomerTypeID],	 
	[CustomerDesc]	    FROM
	
	[CustomerDemographics]

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_CustomerDemographic_Get_ByCustomerTypeID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_CustomerDemographic_Get_ByCustomerTypeID]
GO

CREATE PROCEDURE [sp_cw_CustomerDemographic_Get_ByCustomerTypeID]
(
		@CustomerTypeID NChar (10)	
	
)
AS
    SELECT 
	[CustomerTypeID],	 
	[CustomerDesc]		
    FROM
	[CustomerDemographics]
	WHERE
		CustomerTypeID = @CustomerTypeID
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Customers
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Customer_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Customer_Get_All]
GO

CREATE PROCEDURE [sp_cw_Customer_Get_All]
AS
    SELECT 
	[CustomerID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax]	    FROM
	
	[Customers]

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Customer_Get_ByCity]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Customer_Get_ByCity]
GO

CREATE PROCEDURE [sp_cw_Customer_Get_ByCity]
(
		@City NVarChar (15)	
	
)
AS
    SELECT 
	[CustomerID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax]		
    FROM
	[Customers]
	WHERE
		City = @City
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Customer_Get_ByCompanyName]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Customer_Get_ByCompanyName]
GO

CREATE PROCEDURE [sp_cw_Customer_Get_ByCompanyName]
(
		@CompanyName NVarChar (40)	
	
)
AS
    SELECT 
	[CustomerID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax]		
    FROM
	[Customers]
	WHERE
		CompanyName = @CompanyName
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Customer_Get_ByCustomerID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Customer_Get_ByCustomerID]
GO

CREATE PROCEDURE [sp_cw_Customer_Get_ByCustomerID]
(
		@CustomerID NChar (5)	
	
)
AS
    SELECT 
	[CustomerID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax]		
    FROM
	[Customers]
	WHERE
		CustomerID = @CustomerID
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Customer_Get_ByPostalCode]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Customer_Get_ByPostalCode]
GO

CREATE PROCEDURE [sp_cw_Customer_Get_ByPostalCode]
(
		@PostalCode NVarChar (10)	
	
)
AS
    SELECT 
	[CustomerID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax]		
    FROM
	[Customers]
	WHERE
		PostalCode = @PostalCode
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Customer_Get_ByRegion]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Customer_Get_ByRegion]
GO

CREATE PROCEDURE [sp_cw_Customer_Get_ByRegion]
(
		@Region NVarChar (15)	
	
)
AS
    SELECT 
	[CustomerID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax]		
    FROM
	[Customers]
	WHERE
		Region = @Region
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Employees
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Employee_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Employee_Get_All]
GO

CREATE PROCEDURE [sp_cw_Employee_Get_All]
AS
    SELECT 
	[EmployeeID],	 
	[LastName],	 
	[FirstName],	 
	[Title],	 
	[TitleOfCourtesy],	 
	[BirthDate],	 
	[HireDate],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[HomePhone],	 
	[Extension],	 
	[Photo],	 
	[Notes],	 
	[ReportsTo],	 
	[PhotoPath]	    FROM
	
	[Employees]

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Employee_Get_ByReportsTo]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Employee_Get_ByReportsTo]
GO

CREATE PROCEDURE [sp_cw_Employee_Get_ByReportsTo]
(
	@ReportsTo Int
)
AS
    SELECT 
	[EmployeeID],	 
	[LastName],	 
	[FirstName],	 
	[Title],	 
	[TitleOfCourtesy],	 
	[BirthDate],	 
	[HireDate],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[HomePhone],	 
	[Extension],	 
	[Photo],	 
	[Notes],	 
	[ReportsTo],	 
	[PhotoPath]		
    FROM
	[Employees]
	WHERE
	ReportsTo = @ReportsTo

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Employee_Get_ByLastName]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Employee_Get_ByLastName]
GO

CREATE PROCEDURE [sp_cw_Employee_Get_ByLastName]
(
		@LastName NVarChar (20)	
	
)
AS
    SELECT 
	[EmployeeID],	 
	[LastName],	 
	[FirstName],	 
	[Title],	 
	[TitleOfCourtesy],	 
	[BirthDate],	 
	[HireDate],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[HomePhone],	 
	[Extension],	 
	[Photo],	 
	[Notes],	 
	[ReportsTo],	 
	[PhotoPath]		
    FROM
	[Employees]
	WHERE
		LastName = @LastName
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Employee_Get_ByEmployeeID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Employee_Get_ByEmployeeID]
GO

CREATE PROCEDURE [sp_cw_Employee_Get_ByEmployeeID]
(
		@EmployeeID Int	
	
)
AS
    SELECT 
	[EmployeeID],	 
	[LastName],	 
	[FirstName],	 
	[Title],	 
	[TitleOfCourtesy],	 
	[BirthDate],	 
	[HireDate],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[HomePhone],	 
	[Extension],	 
	[Photo],	 
	[Notes],	 
	[ReportsTo],	 
	[PhotoPath]		
    FROM
	[Employees]
	WHERE
		EmployeeID = @EmployeeID
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Employee_Get_ByPostalCode]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Employee_Get_ByPostalCode]
GO

CREATE PROCEDURE [sp_cw_Employee_Get_ByPostalCode]
(
		@PostalCode NVarChar (10)	
	
)
AS
    SELECT 
	[EmployeeID],	 
	[LastName],	 
	[FirstName],	 
	[Title],	 
	[TitleOfCourtesy],	 
	[BirthDate],	 
	[HireDate],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[HomePhone],	 
	[Extension],	 
	[Photo],	 
	[Notes],	 
	[ReportsTo],	 
	[PhotoPath]		
    FROM
	[Employees]
	WHERE
		PostalCode = @PostalCode
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: EmployeeTerritories
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_EmployeeTerritory_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_EmployeeTerritory_Get_All]
GO

CREATE PROCEDURE [sp_cw_EmployeeTerritory_Get_All]
AS
    SELECT 
	[EmployeeID],	 
	[TerritoryID]	    FROM
	
	[EmployeeTerritories]

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_EmployeeTerritory_Get_ByEmployeeID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_EmployeeTerritory_Get_ByEmployeeID]
GO

CREATE PROCEDURE [sp_cw_EmployeeTerritory_Get_ByEmployeeID]
(
	@EmployeeID Int
)
AS
    SELECT 
	[EmployeeID],	 
	[TerritoryID]		
    FROM
	[EmployeeTerritories]
	WHERE
	EmployeeID = @EmployeeID

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_EmployeeTerritory_Get_ByTerritoryID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_EmployeeTerritory_Get_ByTerritoryID]
GO

CREATE PROCEDURE [sp_cw_EmployeeTerritory_Get_ByTerritoryID]
(
	@TerritoryID NVarChar (20)
)
AS
    SELECT 
	[EmployeeID],	 
	[TerritoryID]		
    FROM
	[EmployeeTerritories]
	WHERE
	TerritoryID = @TerritoryID

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_EmployeeTerritory_Get_ByEmployeeIDTerritoryID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_EmployeeTerritory_Get_ByEmployeeIDTerritoryID]
GO

CREATE PROCEDURE [sp_cw_EmployeeTerritory_Get_ByEmployeeIDTerritoryID]
(
		@EmployeeID Int,	
		@TerritoryID NVarChar (20)	
	
)
AS
    SELECT 
	[EmployeeID],	 
	[TerritoryID]		
    FROM
	[EmployeeTerritories]
	WHERE
		EmployeeID = @EmployeeID
		AND TerritoryID = @TerritoryID
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Order Details
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_OrderDetail_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_OrderDetail_Get_All]
GO

CREATE PROCEDURE [sp_cw_OrderDetail_Get_All]
AS
    SELECT 
	[OrderID],	 
	[ProductID],	 
	[UnitPrice],	 
	[Quantity],	 
	[Discount]	    FROM
	
	[Order Details]

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_OrderDetail_Get_ByOrderID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_OrderDetail_Get_ByOrderID]
GO

CREATE PROCEDURE [sp_cw_OrderDetail_Get_ByOrderID]
(
	@OrderID Int
)
AS
    SELECT 
	[OrderID],	 
	[ProductID],	 
	[UnitPrice],	 
	[Quantity],	 
	[Discount]		
    FROM
	[Order Details]
	WHERE
	OrderID = @OrderID

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_OrderDetail_Get_ByProductID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_OrderDetail_Get_ByProductID]
GO

CREATE PROCEDURE [sp_cw_OrderDetail_Get_ByProductID]
(
	@ProductID Int
)
AS
    SELECT 
	[OrderID],	 
	[ProductID],	 
	[UnitPrice],	 
	[Quantity],	 
	[Discount]		
    FROM
	[Order Details]
	WHERE
	ProductID = @ProductID

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_OrderDetail_Get_ByOrderIDProductID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_OrderDetail_Get_ByOrderIDProductID]
GO

CREATE PROCEDURE [sp_cw_OrderDetail_Get_ByOrderIDProductID]
(
		@OrderID Int,	
		@ProductID Int	
	
)
AS
    SELECT 
	[OrderID],	 
	[ProductID],	 
	[UnitPrice],	 
	[Quantity],	 
	[Discount]		
    FROM
	[Order Details]
	WHERE
		OrderID = @OrderID
		AND ProductID = @ProductID
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Orders
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_All]
GO

CREATE PROCEDURE [sp_cw_Order_Get_All]
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]	    FROM
	
	[Orders]

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_ByCustomerID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_ByCustomerID]
GO

CREATE PROCEDURE [sp_cw_Order_Get_ByCustomerID]
(
	@CustomerID NChar (5)
)
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]		
    FROM
	[Orders]
	WHERE
	CustomerID = @CustomerID

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_ByEmployeeID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_ByEmployeeID]
GO

CREATE PROCEDURE [sp_cw_Order_Get_ByEmployeeID]
(
	@EmployeeID Int
)
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]		
    FROM
	[Orders]
	WHERE
	EmployeeID = @EmployeeID

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_ByShipVium]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_ByShipVium]
GO

CREATE PROCEDURE [sp_cw_Order_Get_ByShipVium]
(
	@ShipVia Int
)
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]		
    FROM
	[Orders]
	WHERE
	ShipVia = @ShipVia

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_ByOrderDate]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_ByOrderDate]
GO

CREATE PROCEDURE [sp_cw_Order_Get_ByOrderDate]
(
		@OrderDate DateTime	
	
)
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]		
    FROM
	[Orders]
	WHERE
		OrderDate = @OrderDate
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_ByOrderID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_ByOrderID]
GO

CREATE PROCEDURE [sp_cw_Order_Get_ByOrderID]
(
		@OrderID Int	
	
)
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]		
    FROM
	[Orders]
	WHERE
		OrderID = @OrderID
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_ByShippedDate]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_ByShippedDate]
GO

CREATE PROCEDURE [sp_cw_Order_Get_ByShippedDate]
(
		@ShippedDate DateTime	
	
)
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]		
    FROM
	[Orders]
	WHERE
		ShippedDate = @ShippedDate
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Order_Get_ByShipPostalCode]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Order_Get_ByShipPostalCode]
GO

CREATE PROCEDURE [sp_cw_Order_Get_ByShipPostalCode]
(
		@ShipPostalCode NVarChar (10)	
	
)
AS
    SELECT 
	[OrderID],	 
	[CustomerID],	 
	[EmployeeID],	 
	[OrderDate],	 
	[RequiredDate],	 
	[ShippedDate],	 
	[ShipVia],	 
	[Freight],	 
	[ShipName],	 
	[ShipAddress],	 
	[ShipCity],	 
	[ShipRegion],	 
	[ShipPostalCode],	 
	[ShipCountry]		
    FROM
	[Orders]
	WHERE
		ShipPostalCode = @ShipPostalCode
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Products
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Product_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Product_Get_All]
GO

CREATE PROCEDURE [sp_cw_Product_Get_All]
AS
    SELECT 
	[ProductID],	 
	[ProductName],	 
	[SupplierID],	 
	[CategoryID],	 
	[QuantityPerUnit],	 
	[UnitPrice],	 
	[UnitsInStock],	 
	[UnitsOnOrder],	 
	[ReorderLevel],	 
	[Discontinued]	    FROM
	
	[Products]

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Product_Get_BySupplierID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Product_Get_BySupplierID]
GO

CREATE PROCEDURE [sp_cw_Product_Get_BySupplierID]
(
	@SupplierID Int
)
AS
    SELECT 
	[ProductID],	 
	[ProductName],	 
	[SupplierID],	 
	[CategoryID],	 
	[QuantityPerUnit],	 
	[UnitPrice],	 
	[UnitsInStock],	 
	[UnitsOnOrder],	 
	[ReorderLevel],	 
	[Discontinued]		
    FROM
	[Products]
	WHERE
	SupplierID = @SupplierID

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Product_Get_ByCategoryID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Product_Get_ByCategoryID]
GO

CREATE PROCEDURE [sp_cw_Product_Get_ByCategoryID]
(
	@CategoryID Int
)
AS
    SELECT 
	[ProductID],	 
	[ProductName],	 
	[SupplierID],	 
	[CategoryID],	 
	[QuantityPerUnit],	 
	[UnitPrice],	 
	[UnitsInStock],	 
	[UnitsOnOrder],	 
	[ReorderLevel],	 
	[Discontinued]		
    FROM
	[Products]
	WHERE
	CategoryID = @CategoryID

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Product_Get_ByProductID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Product_Get_ByProductID]
GO

CREATE PROCEDURE [sp_cw_Product_Get_ByProductID]
(
		@ProductID Int	
	
)
AS
    SELECT 
	[ProductID],	 
	[ProductName],	 
	[SupplierID],	 
	[CategoryID],	 
	[QuantityPerUnit],	 
	[UnitPrice],	 
	[UnitsInStock],	 
	[UnitsOnOrder],	 
	[ReorderLevel],	 
	[Discontinued]		
    FROM
	[Products]
	WHERE
		ProductID = @ProductID
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Product_Get_ByProductName]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Product_Get_ByProductName]
GO

CREATE PROCEDURE [sp_cw_Product_Get_ByProductName]
(
		@ProductName NVarChar (40)	
	
)
AS
    SELECT 
	[ProductID],	 
	[ProductName],	 
	[SupplierID],	 
	[CategoryID],	 
	[QuantityPerUnit],	 
	[UnitPrice],	 
	[UnitsInStock],	 
	[UnitsOnOrder],	 
	[ReorderLevel],	 
	[Discontinued]		
    FROM
	[Products]
	WHERE
		ProductName = @ProductName
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Region
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Region_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Region_Get_All]
GO

CREATE PROCEDURE [sp_cw_Region_Get_All]
AS
    SELECT 
	[RegionID],	 
	[RegionDescription]	    FROM
	
	[Region]

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Region_Get_ByRegionID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Region_Get_ByRegionID]
GO

CREATE PROCEDURE [sp_cw_Region_Get_ByRegionID]
(
		@RegionID Int	
	
)
AS
    SELECT 
	[RegionID],	 
	[RegionDescription]		
    FROM
	[Region]
	WHERE
		RegionID = @RegionID
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Shippers
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Shipper_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Shipper_Get_All]
GO

CREATE PROCEDURE [sp_cw_Shipper_Get_All]
AS
    SELECT 
	[ShipperID],	 
	[CompanyName],	 
	[Phone]	    FROM
	
	[Shippers]

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Shipper_Get_ByShipperID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Shipper_Get_ByShipperID]
GO

CREATE PROCEDURE [sp_cw_Shipper_Get_ByShipperID]
(
		@ShipperID Int	
	
)
AS
    SELECT 
	[ShipperID],	 
	[CompanyName],	 
	[Phone]		
    FROM
	[Shippers]
	WHERE
		ShipperID = @ShipperID
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Suppliers
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Supplier_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Supplier_Get_All]
GO

CREATE PROCEDURE [sp_cw_Supplier_Get_All]
AS
    SELECT 
	[SupplierID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax],	 
	[HomePage]	    FROM
	
	[Suppliers]

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Supplier_Get_ByCompanyName]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Supplier_Get_ByCompanyName]
GO

CREATE PROCEDURE [sp_cw_Supplier_Get_ByCompanyName]
(
		@CompanyName NVarChar (40)	
	
)
AS
    SELECT 
	[SupplierID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax],	 
	[HomePage]		
    FROM
	[Suppliers]
	WHERE
		CompanyName = @CompanyName
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Supplier_Get_BySupplierID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Supplier_Get_BySupplierID]
GO

CREATE PROCEDURE [sp_cw_Supplier_Get_BySupplierID]
(
		@SupplierID Int	
	
)
AS
    SELECT 
	[SupplierID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax],	 
	[HomePage]		
    FROM
	[Suppliers]
	WHERE
		SupplierID = @SupplierID
	
    SELECT @@ROWCOUNT
GO
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Supplier_Get_ByPostalCode]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Supplier_Get_ByPostalCode]
GO

CREATE PROCEDURE [sp_cw_Supplier_Get_ByPostalCode]
(
		@PostalCode NVarChar (10)	
	
)
AS
    SELECT 
	[SupplierID],	 
	[CompanyName],	 
	[ContactName],	 
	[ContactTitle],	 
	[Address],	 
	[City],	 
	[Region],	 
	[PostalCode],	 
	[Country],	 
	[Phone],	 
	[Fax],	 
	[HomePage]		
    FROM
	[Suppliers]
	WHERE
		PostalCode = @PostalCode
	
    SELECT @@ROWCOUNT
GO
	

-- Procedures for table: Territories
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Territory_Get_All]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Territory_Get_All]
GO

CREATE PROCEDURE [sp_cw_Territory_Get_All]
AS
    SELECT 
	[TerritoryID],	 
	[TerritoryDescription],	 
	[RegionID]	    FROM
	
	[Territories]

    SELECT @@ROWCOUNT
GO

	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Territory_Get_ByRegionID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Territory_Get_ByRegionID]
GO

CREATE PROCEDURE [sp_cw_Territory_Get_ByRegionID]
(
	@RegionID Int
)
AS
    SELECT 
	[TerritoryID],	 
	[TerritoryDescription],	 
	[RegionID]		
    FROM
	[Territories]
	WHERE
	RegionID = @RegionID

    SELECT @@ROWCOUNT
GO

	
	
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[sp_cw_Territory_Get_ByTerritoryID]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [sp_cw_Territory_Get_ByTerritoryID]
GO

CREATE PROCEDURE [sp_cw_Territory_Get_ByTerritoryID]
(
		@TerritoryID NVarChar (20)	
	
)
AS
    SELECT 
	[TerritoryID],	 
	[TerritoryDescription],	 
	[RegionID]		
    FROM
	[Territories]
	WHERE
		TerritoryID = @TerritoryID
	
    SELECT @@ROWCOUNT
GO
	
