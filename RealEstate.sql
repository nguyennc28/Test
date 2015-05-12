if exists (select * from sysobjects where id = object_id(N'[sproc_Advertise_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Advertise_GetCount]
GO

/* Procedure sproc_Advertise_GetCount*/
CREATE PROCEDURE sproc_Advertise_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Advertise]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Advertise_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Advertise_Get]
GO

/* Procedure sproc_Advertise_Get*/
CREATE PROCEDURE sproc_Advertise_Get
AS
SELECT
	--[AdvID],
	--[AdvName],
	--[Image],
	--[Width],
	--[Height],
	--[Link],
	--[Target],
	--[Content],
	--[Position],
	--[PageID],
	--[Click],
	--[Ord],
	--[Active],
	--[Lang]

*
FROM
	[Advertise]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Advertise_GetByAdvID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Advertise_GetByAdvID]
GO

/* Procedure sproc_Advertise_GetByAdvID*/
CREATE PROCEDURE sproc_Advertise_GetByAdvID
@AdvID int
AS
SELECT
	--[AdvID],
	--[AdvName],
	--[Image],
	--[Width],
	--[Height],
	--[Link],
	--[Target],
	--[Content],
	--[Position],
	--[PageID],
	--[Click],
	--[Ord],
	--[Active],
	--[Lang]

*
FROM
	[Advertise]
WHERE
	[AdvID] = @AdvID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Advertise_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Advertise_GetPaged]
GO

/* Procedure sproc_Advertise_GetPaged*/
CREATE PROCEDURE sproc_Advertise_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [AdvID]
FROM [Advertise]


-- query out
SELECT *
FROM [Advertise]
WHERE [AdvID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Advertise_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Advertise_Add]
GO

/* Procedure sproc_Advertise_Add*/
CREATE PROCEDURE sproc_Advertise_Add
	@AdvID int OUTPUT
	,@AdvName nvarchar(150)
	,@Image nvarchar(255)
	,@Width int
	,@Height int
	,@Link nvarchar(255)
	,@Target varchar(10)
	,@Content ntext
	,@Position smallint
	,@PageID int
	,@Click int
	,@Ord int
	,@Active bit
	,@Lang varchar(5)

AS

	INSERT INTO [Advertise]
	(
		[AdvID],
		[AdvName],
		[Image],
		[Width],
		[Height],
		[Link],
		[Target],
		[Content],
		[Position],
		[PageID],
		[Click],
		[Ord],
		[Active],
		[Lang]
	)
	VALUES
	(
		@AdvID,
		@AdvName,
		@Image,
		@Width,
		@Height,
		@Link,
		@Target,
		@Content,
		@Position,
		@PageID,
		@Click,
		@Ord,
		@Active,
		@Lang
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Advertise_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Advertise_Update]
GO

/* Procedure sproc_Advertise_Update*/
CREATE PROCEDURE sproc_Advertise_Update
	@AdvName nvarchar(150),
	@Image nvarchar(255),
	@Width int,
	@Height int,
	@Link nvarchar(255),
	@Target varchar(10),
	@Content ntext,
	@Position smallint,
	@PageID int,
	@Click int,
	@Ord int,
	@Active bit,
	@Lang varchar(5),
	@AdvID int

AS
UPDATE [Advertise]
SET
	[AdvName] = @AdvName,
	[Image] = @Image,
	[Width] = @Width,
	[Height] = @Height,
	[Link] = @Link,
	[Target] = @Target,
	[Content] = @Content,
	[Position] = @Position,
	[PageID] = @PageID,
	[Click] = @Click,
	[Ord] = @Ord,
	[Active] = @Active,
	[Lang] = @Lang
WHERE
	[AdvID] = @AdvID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Advertise_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Advertise_Delete]
GO

/* Procedure sproc_Advertise_Delete*/
CREATE PROCEDURE sproc_Advertise_Delete
	@AdvID int
AS
DELETE
FROM
	[Advertise]
WHERE
	[AdvID] = @AdvID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Apartment_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Apartment_GetCount]
GO

/* Procedure sproc_Apartment_GetCount*/
CREATE PROCEDURE sproc_Apartment_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Apartment]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Apartment_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Apartment_Get]
GO

/* Procedure sproc_Apartment_Get*/
CREATE PROCEDURE sproc_Apartment_Get
AS
SELECT
	--[ApartmentID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[FloorArea],
	--[GargenArea],
	--[HomeArea],
	--[RoomNumber],
	--[TierNumber],
	--[Image1],
	--[Image2],
	--[Image3]

*
FROM
	[Apartment]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Apartment_GetByApartmentID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Apartment_GetByApartmentID]
GO

/* Procedure sproc_Apartment_GetByApartmentID*/
CREATE PROCEDURE sproc_Apartment_GetByApartmentID
@ApartmentID int
AS
SELECT
	--[ApartmentID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[FloorArea],
	--[GargenArea],
	--[HomeArea],
	--[RoomNumber],
	--[TierNumber],
	--[Image1],
	--[Image2],
	--[Image3]

*
FROM
	[Apartment]
WHERE
	[ApartmentID] = @ApartmentID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Apartment_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Apartment_GetPaged]
GO

/* Procedure sproc_Apartment_GetPaged*/
CREATE PROCEDURE sproc_Apartment_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [ApartmentID]
FROM [Apartment]


-- query out
SELECT *
FROM [Apartment]
WHERE [ApartmentID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Apartment_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Apartment_Add]
GO

/* Procedure sproc_Apartment_Add*/
CREATE PROCEDURE sproc_Apartment_Add
	@ApartmentID int OUTPUT
	,@RealEstateOwnersID int
	,@RealEstateOwnersTypeID int
	,@RealEstateID int
	,@Description nvarchar(250)
	,@Address nvarchar(250)
	,@Price float(8)
	,@TotalArea float(8)
	,@FloorArea float(8)
	,@GargenArea float(8)
	,@HomeArea float(8)
	,@RoomNumber tinyint
	,@TierNumber tinyint
	,@Image1 nvarchar(250)
	,@Image2 nvarchar(250)
	,@Image3 nvarchar(250)

AS

	INSERT INTO [Apartment]
	(
		[RealEstateOwnersID],
		[RealEstateOwnersTypeID],
		[RealEstateID],
		[Description],
		[Address],
		[Price],
		[TotalArea],
		[FloorArea],
		[GargenArea],
		[HomeArea],
		[RoomNumber],
		[TierNumber],
		[Image1],
		[Image2],
		[Image3]
	)
	VALUES
	(
		@RealEstateOwnersID,
		@RealEstateOwnersTypeID,
		@RealEstateID,
		@Description,
		@Address,
		@Price,
		@TotalArea,
		@FloorArea,
		@GargenArea,
		@HomeArea,
		@RoomNumber,
		@TierNumber,
		@Image1,
		@Image2,
		@Image3
	)
	SELECT
		@ApartmentID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Apartment_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Apartment_Update]
GO

/* Procedure sproc_Apartment_Update*/
CREATE PROCEDURE sproc_Apartment_Update
	@RealEstateOwnersID int,
	@RealEstateOwnersTypeID int,
	@RealEstateID int,
	@Description nvarchar(250),
	@Address nvarchar(250),
	@Price float(8),
	@TotalArea float(8),
	@FloorArea float(8),
	@GargenArea float(8),
	@HomeArea float(8),
	@RoomNumber tinyint,
	@TierNumber tinyint,
	@Image1 nvarchar(250),
	@Image2 nvarchar(250),
	@Image3 nvarchar(250),
	@ApartmentID int

AS
UPDATE [Apartment]
SET
	[RealEstateOwnersID] = @RealEstateOwnersID,
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID,
	[RealEstateID] = @RealEstateID,
	[Description] = @Description,
	[Address] = @Address,
	[Price] = @Price,
	[TotalArea] = @TotalArea,
	[FloorArea] = @FloorArea,
	[GargenArea] = @GargenArea,
	[HomeArea] = @HomeArea,
	[RoomNumber] = @RoomNumber,
	[TierNumber] = @TierNumber,
	[Image1] = @Image1,
	[Image2] = @Image2,
	[Image3] = @Image3
WHERE
	[ApartmentID] = @ApartmentID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Apartment_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Apartment_Delete]
GO

/* Procedure sproc_Apartment_Delete*/
CREATE PROCEDURE sproc_Apartment_Delete
	@ApartmentID int
AS
DELETE
FROM
	[Apartment]
WHERE
	[ApartmentID] = @ApartmentID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Banner_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Banner_GetCount]
GO

/* Procedure sproc_Banner_GetCount*/
CREATE PROCEDURE sproc_Banner_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Banner]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Banner_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Banner_Get]
GO

/* Procedure sproc_Banner_Get*/
CREATE PROCEDURE sproc_Banner_Get
AS
SELECT
	--[BannerID],
	--[BannerType],
	--[Size],
	--[Description],
	--[Images]

*
FROM
	[Banner]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Banner_GetByBannerID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Banner_GetByBannerID]
GO

/* Procedure sproc_Banner_GetByBannerID*/
CREATE PROCEDURE sproc_Banner_GetByBannerID
@BannerID int
AS
SELECT
	--[BannerID],
	--[BannerType],
	--[Size],
	--[Description],
	--[Images]

*
FROM
	[Banner]
WHERE
	[BannerID] = @BannerID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Banner_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Banner_GetPaged]
GO

/* Procedure sproc_Banner_GetPaged*/
CREATE PROCEDURE sproc_Banner_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [BannerID]
FROM [Banner]


-- query out
SELECT *
FROM [Banner]
WHERE [BannerID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Banner_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Banner_Add]
GO

/* Procedure sproc_Banner_Add*/
CREATE PROCEDURE sproc_Banner_Add
	@BannerID int OUTPUT
	,@BannerType nvarchar(50)
	,@Size nchar(15)
	,@Description nvarchar(250)
	,@Images nvarchar(250)

AS

	INSERT INTO [Banner]
	(
		[BannerType],
		[Size],
		[Description],
		[Images]
	)
	VALUES
	(
		@BannerType,
		@Size,
		@Description,
		@Images
	)
	SELECT
		@BannerID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Banner_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Banner_Update]
GO

/* Procedure sproc_Banner_Update*/
CREATE PROCEDURE sproc_Banner_Update
	@BannerType nvarchar(50),
	@Size nchar(15),
	@Description nvarchar(250),
	@Images nvarchar(250),
	@BannerID int

AS
UPDATE [Banner]
SET
	[BannerType] = @BannerType,
	[Size] = @Size,
	[Description] = @Description,
	[Images] = @Images
WHERE
	[BannerID] = @BannerID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Banner_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Banner_Delete]
GO

/* Procedure sproc_Banner_Delete*/
CREATE PROCEDURE sproc_Banner_Delete
	@BannerID int
AS
DELETE
FROM
	[Banner]
WHERE
	[BannerID] = @BannerID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Categorys_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Categorys_GetCount]
GO

/* Procedure sproc_Categorys_GetCount*/
CREATE PROCEDURE sproc_Categorys_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Categorys]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Categorys_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Categorys_Get]
GO

/* Procedure sproc_Categorys_Get*/
CREATE PROCEDURE sproc_Categorys_Get
AS
SELECT
	--[CategoryID],
	--[Tag],
	--[Name],
	--[Content],
	--[Level],
	--[Priority],
	--[Index],
	--[Title],
	--[Description],
	--[Keyword],
	--[Active],
	--[Ord],
	--[Lang],
	--[Image],
	--[Image2]

*
FROM
	[Categorys]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Categorys_GetByCategoryID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Categorys_GetByCategoryID]
GO

/* Procedure sproc_Categorys_GetByCategoryID*/
CREATE PROCEDURE sproc_Categorys_GetByCategoryID
@CategoryID int
AS
SELECT
	--[CategoryID],
	--[Tag],
	--[Name],
	--[Content],
	--[Level],
	--[Priority],
	--[Index],
	--[Title],
	--[Description],
	--[Keyword],
	--[Active],
	--[Ord],
	--[Lang],
	--[Image],
	--[Image2]

*
FROM
	[Categorys]
WHERE
	[CategoryID] = @CategoryID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Categorys_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Categorys_GetPaged]
GO

/* Procedure sproc_Categorys_GetPaged*/
CREATE PROCEDURE sproc_Categorys_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [CategoryID]
FROM [Categorys]


-- query out
SELECT *
FROM [Categorys]
WHERE [CategoryID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Categorys_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Categorys_Add]
GO

/* Procedure sproc_Categorys_Add*/
CREATE PROCEDURE sproc_Categorys_Add
	@CategoryID int OUTPUT
	,@Tag nvarchar(255)
	,@Name nvarchar(255)
	,@Content ntext
	,@Level nvarchar(100)
	,@Priority smallint
	,@Index smallint
	,@Title nvarchar(255)
	,@Description nvarchar(500)
	,@Keyword nvarchar(255)
	,@Active int
	,@Ord int
	,@Lang varchar(5)
	,@Image nvarchar(255)
	,@Image2 nvarchar(255)

AS

	INSERT INTO [Categorys]
	(
		[Tag],
		[Name],
		[Content],
		[Level],
		[Priority],
		[Index],
		[Title],
		[Description],
		[Keyword],
		[Active],
		[Ord],
		[Lang],
		[Image],
		[Image2]
	)
	VALUES
	(
		@Tag,
		@Name,
		@Content,
		@Level,
		@Priority,
		@Index,
		@Title,
		@Description,
		@Keyword,
		@Active,
		@Ord,
		@Lang,
		@Image,
		@Image2
	)
	SELECT
		@CategoryID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Categorys_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Categorys_Update]
GO

/* Procedure sproc_Categorys_Update*/
CREATE PROCEDURE sproc_Categorys_Update
	@Tag nvarchar(255),
	@Name nvarchar(255),
	@Content ntext,
	@Level nvarchar(100),
	@Priority smallint,
	@Index smallint,
	@Title nvarchar(255),
	@Description nvarchar(500),
	@Keyword nvarchar(255),
	@Active int,
	@Ord int,
	@Lang varchar(5),
	@Image nvarchar(255),
	@Image2 nvarchar(255),
	@CategoryID int

AS
UPDATE [Categorys]
SET
	[Tag] = @Tag,
	[Name] = @Name,
	[Content] = @Content,
	[Level] = @Level,
	[Priority] = @Priority,
	[Index] = @Index,
	[Title] = @Title,
	[Description] = @Description,
	[Keyword] = @Keyword,
	[Active] = @Active,
	[Ord] = @Ord,
	[Lang] = @Lang,
	[Image] = @Image,
	[Image2] = @Image2
WHERE
	[CategoryID] = @CategoryID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Categorys_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Categorys_Delete]
GO

/* Procedure sproc_Categorys_Delete*/
CREATE PROCEDURE sproc_Categorys_Delete
	@CategoryID int
AS
DELETE
FROM
	[Categorys]
WHERE
	[CategoryID] = @CategoryID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_City_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_City_GetCount]
GO

/* Procedure sproc_City_GetCount*/
CREATE PROCEDURE sproc_City_GetCount
AS
SELECT
	COUNT(*)
FROM
	[City]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_City_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_City_Get]
GO

/* Procedure sproc_City_Get*/
CREATE PROCEDURE sproc_City_Get
AS
SELECT
	--[CityID],
	--[CityName]

*
FROM
	[City]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_City_GetByCityID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_City_GetByCityID]
GO

/* Procedure sproc_City_GetByCityID*/
CREATE PROCEDURE sproc_City_GetByCityID
@CityID int
AS
SELECT
	--[CityID],
	--[CityName]

*
FROM
	[City]
WHERE
	[CityID] = @CityID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_City_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_City_GetPaged]
GO

/* Procedure sproc_City_GetPaged*/
CREATE PROCEDURE sproc_City_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [CityID]
FROM [City]


-- query out
SELECT *
FROM [City]
WHERE [CityID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_City_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_City_Add]
GO

/* Procedure sproc_City_Add*/
CREATE PROCEDURE sproc_City_Add
	@CityID int OUTPUT
	,@CityName nvarchar(20)

AS

	INSERT INTO [City]
	(
		[CityID],
		[CityName]
	)
	VALUES
	(
		@CityID,
		@CityName
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_City_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_City_Update]
GO

/* Procedure sproc_City_Update*/
CREATE PROCEDURE sproc_City_Update
	@CityName nvarchar(20),
	@CityID int

AS
UPDATE [City]
SET
	[CityName] = @CityName
WHERE
	[CityID] = @CityID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_City_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_City_Delete]
GO

/* Procedure sproc_City_Delete*/
CREATE PROCEDURE sproc_City_Delete
	@CityID int
AS
DELETE
FROM
	[City]
WHERE
	[CityID] = @CityID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Companys_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Companys_GetCount]
GO

/* Procedure sproc_Companys_GetCount*/
CREATE PROCEDURE sproc_Companys_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Companys]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Companys_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Companys_Get]
GO

/* Procedure sproc_Companys_Get*/
CREATE PROCEDURE sproc_Companys_Get
AS
SELECT
	--[CompanyID],
	--[CompanyName],
	--[Address],
	--[HotLine],
	--[PhoneNumber],
	--[Fax],
	--[Email],
	--[Surrogate],
	--[Chevron]

*
FROM
	[Companys]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Companys_GetByCompanyID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Companys_GetByCompanyID]
GO

/* Procedure sproc_Companys_GetByCompanyID*/
CREATE PROCEDURE sproc_Companys_GetByCompanyID
@CompanyID int
AS
SELECT
	--[CompanyID],
	--[CompanyName],
	--[Address],
	--[HotLine],
	--[PhoneNumber],
	--[Fax],
	--[Email],
	--[Surrogate],
	--[Chevron]

*
FROM
	[Companys]
WHERE
	[CompanyID] = @CompanyID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Companys_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Companys_GetPaged]
GO

/* Procedure sproc_Companys_GetPaged*/
CREATE PROCEDURE sproc_Companys_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [CompanyID]
FROM [Companys]


-- query out
SELECT *
FROM [Companys]
WHERE [CompanyID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Companys_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Companys_Add]
GO

/* Procedure sproc_Companys_Add*/
CREATE PROCEDURE sproc_Companys_Add
	@CompanyID int OUTPUT
	,@CompanyName nvarchar(100)
	,@Address nvarchar(250)
	,@HotLine nchar(15)
	,@PhoneNumber nvarchar(15)
	,@Fax nvarchar(15)
	,@Email nvarchar(50)
	,@Surrogate nvarchar(50)
	,@Chevron nvarchar(50)

AS

	INSERT INTO [Companys]
	(
		[CompanyName],
		[Address],
		[HotLine],
		[PhoneNumber],
		[Fax],
		[Email],
		[Surrogate],
		[Chevron]
	)
	VALUES
	(
		@CompanyName,
		@Address,
		@HotLine,
		@PhoneNumber,
		@Fax,
		@Email,
		@Surrogate,
		@Chevron
	)
	SELECT
		@CompanyID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Companys_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Companys_Update]
GO

/* Procedure sproc_Companys_Update*/
CREATE PROCEDURE sproc_Companys_Update
	@CompanyName nvarchar(100),
	@Address nvarchar(250),
	@HotLine nchar(15),
	@PhoneNumber nvarchar(15),
	@Fax nvarchar(15),
	@Email nvarchar(50),
	@Surrogate nvarchar(50),
	@Chevron nvarchar(50),
	@CompanyID int

AS
UPDATE [Companys]
SET
	[CompanyName] = @CompanyName,
	[Address] = @Address,
	[HotLine] = @HotLine,
	[PhoneNumber] = @PhoneNumber,
	[Fax] = @Fax,
	[Email] = @Email,
	[Surrogate] = @Surrogate,
	[Chevron] = @Chevron
WHERE
	[CompanyID] = @CompanyID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Companys_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Companys_Delete]
GO

/* Procedure sproc_Companys_Delete*/
CREATE PROCEDURE sproc_Companys_Delete
	@CompanyID int
AS
DELETE
FROM
	[Companys]
WHERE
	[CompanyID] = @CompanyID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_ContractAdvertising_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ContractAdvertising_GetCount]
GO

/* Procedure sproc_ContractAdvertising_GetCount*/
CREATE PROCEDURE sproc_ContractAdvertising_GetCount
AS
SELECT
	COUNT(*)
FROM
	[ContractAdvertising]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_ContractAdvertising_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ContractAdvertising_Get]
GO

/* Procedure sproc_ContractAdvertising_Get*/
CREATE PROCEDURE sproc_ContractAdvertising_Get
AS
SELECT
	--[ContractAdvertisingID],
	--[ContractAdvertisingName],
	--[StaffID],
	--[CompanyID],
	--[BannerID],
	--[CreateDate],
	--[Fees],
	--[EndDate],
	--[Status]

*
FROM
	[ContractAdvertising]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_ContractAdvertising_GetByContractAdvertisingID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ContractAdvertising_GetByContractAdvertisingID]
GO

/* Procedure sproc_ContractAdvertising_GetByContractAdvertisingID*/
CREATE PROCEDURE sproc_ContractAdvertising_GetByContractAdvertisingID
@ContractAdvertisingID int
AS
SELECT
	--[ContractAdvertisingID],
	--[ContractAdvertisingName],
	--[StaffID],
	--[CompanyID],
	--[BannerID],
	--[CreateDate],
	--[Fees],
	--[EndDate],
	--[Status]

*
FROM
	[ContractAdvertising]
WHERE
	[ContractAdvertisingID] = @ContractAdvertisingID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_ContractAdvertising_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ContractAdvertising_GetPaged]
GO

/* Procedure sproc_ContractAdvertising_GetPaged*/
CREATE PROCEDURE sproc_ContractAdvertising_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [ContractAdvertisingID]
FROM [ContractAdvertising]


-- query out
SELECT *
FROM [ContractAdvertising]
WHERE [ContractAdvertisingID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_ContractAdvertising_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ContractAdvertising_Add]
GO

/* Procedure sproc_ContractAdvertising_Add*/
CREATE PROCEDURE sproc_ContractAdvertising_Add
	@ContractAdvertisingID int OUTPUT
	,@ContractAdvertisingName nvarchar(50)
	,@StaffID int
	,@CompanyID int
	,@BannerID int
	,@CreateDate datetime
	,@Fees money
	,@EndDate datetime
	,@Status bit

AS

	INSERT INTO [ContractAdvertising]
	(
		[ContractAdvertisingName],
		[StaffID],
		[CompanyID],
		[BannerID],
		[CreateDate],
		[Fees],
		[EndDate],
		[Status]
	)
	VALUES
	(
		@ContractAdvertisingName,
		@StaffID,
		@CompanyID,
		@BannerID,
		@CreateDate,
		@Fees,
		@EndDate,
		@Status
	)
	SELECT
		@ContractAdvertisingID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_ContractAdvertising_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ContractAdvertising_Update]
GO

/* Procedure sproc_ContractAdvertising_Update*/
CREATE PROCEDURE sproc_ContractAdvertising_Update
	@ContractAdvertisingName nvarchar(50),
	@StaffID int,
	@CompanyID int,
	@BannerID int,
	@CreateDate datetime,
	@Fees money,
	@EndDate datetime,
	@Status bit,
	@ContractAdvertisingID int

AS
UPDATE [ContractAdvertising]
SET
	[ContractAdvertisingName] = @ContractAdvertisingName,
	[StaffID] = @StaffID,
	[CompanyID] = @CompanyID,
	[BannerID] = @BannerID,
	[CreateDate] = @CreateDate,
	[Fees] = @Fees,
	[EndDate] = @EndDate,
	[Status] = @Status
WHERE
	[ContractAdvertisingID] = @ContractAdvertisingID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_ContractAdvertising_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ContractAdvertising_Delete]
GO

/* Procedure sproc_ContractAdvertising_Delete*/
CREATE PROCEDURE sproc_ContractAdvertising_Delete
	@ContractAdvertisingID int
AS
DELETE
FROM
	[ContractAdvertising]
WHERE
	[ContractAdvertisingID] = @ContractAdvertisingID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Controls_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Controls_GetCount]
GO

/* Procedure sproc_Controls_GetCount*/
CREATE PROCEDURE sproc_Controls_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Controls]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Controls_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Controls_Get]
GO

/* Procedure sproc_Controls_Get*/
CREATE PROCEDURE sproc_Controls_Get
AS
SELECT
	--[ControlID],
	--[PageId],
	--[Name],
	--[Path],
	--[Param],
	--[Status],
	--[Priority]

*
FROM
	[Controls]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Controls_GetByControlID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Controls_GetByControlID]
GO

/* Procedure sproc_Controls_GetByControlID*/
CREATE PROCEDURE sproc_Controls_GetByControlID
@ControlID int
AS
SELECT
	--[ControlID],
	--[PageId],
	--[Name],
	--[Path],
	--[Param],
	--[Status],
	--[Priority]

*
FROM
	[Controls]
WHERE
	[ControlID] = @ControlID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Controls_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Controls_GetPaged]
GO

/* Procedure sproc_Controls_GetPaged*/
CREATE PROCEDURE sproc_Controls_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [ControlID]
FROM [Controls]


-- query out
SELECT *
FROM [Controls]
WHERE [ControlID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Controls_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Controls_Add]
GO

/* Procedure sproc_Controls_Add*/
CREATE PROCEDURE sproc_Controls_Add
	@ControlID int OUTPUT
	,@PageId int
	,@Name nvarchar(100)
	,@Path nvarchar(250)
	,@Param nvarchar(250)
	,@Status bigint
	,@Priority int

AS

	INSERT INTO [Controls]
	(
		[PageId],
		[Name],
		[Path],
		[Param],
		[Status],
		[Priority]
	)
	VALUES
	(
		@PageId,
		@Name,
		@Path,
		@Param,
		@Status,
		@Priority
	)
	SELECT
		@ControlID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Controls_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Controls_Update]
GO

/* Procedure sproc_Controls_Update*/
CREATE PROCEDURE sproc_Controls_Update
	@PageId int,
	@Name nvarchar(100),
	@Path nvarchar(250),
	@Param nvarchar(250),
	@Status bigint,
	@Priority int,
	@ControlID int

AS
UPDATE [Controls]
SET
	[PageId] = @PageId,
	[Name] = @Name,
	[Path] = @Path,
	[Param] = @Param,
	[Status] = @Status,
	[Priority] = @Priority
WHERE
	[ControlID] = @ControlID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Controls_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Controls_Delete]
GO

/* Procedure sproc_Controls_Delete*/
CREATE PROCEDURE sproc_Controls_Delete
	@ControlID int
AS
DELETE
FROM
	[Controls]
WHERE
	[ControlID] = @ControlID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Customers_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Customers_GetCount]
GO

/* Procedure sproc_Customers_GetCount*/
CREATE PROCEDURE sproc_Customers_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Customers]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Customers_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Customers_Get]
GO

/* Procedure sproc_Customers_Get*/
CREATE PROCEDURE sproc_Customers_Get
AS
SELECT
	--[CustomerID],
	--[UserName],
	--[Password],
	--[FullName],
	--[Gender],
	--[Address],
	--[IdentityCard],
	--[MobileNumber],
	--[HomePhone],
	--[Email]

*
FROM
	[Customers]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Customers_GetByCustomerID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Customers_GetByCustomerID]
GO

/* Procedure sproc_Customers_GetByCustomerID*/
CREATE PROCEDURE sproc_Customers_GetByCustomerID
@CustomerID int
AS
SELECT
	--[CustomerID],
	--[UserName],
	--[Password],
	--[FullName],
	--[Gender],
	--[Address],
	--[IdentityCard],
	--[MobileNumber],
	--[HomePhone],
	--[Email]

*
FROM
	[Customers]
WHERE
	[CustomerID] = @CustomerID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Customers_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Customers_GetPaged]
GO

/* Procedure sproc_Customers_GetPaged*/
CREATE PROCEDURE sproc_Customers_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [CustomerID]
FROM [Customers]


-- query out
SELECT *
FROM [Customers]
WHERE [CustomerID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Customers_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Customers_Add]
GO

/* Procedure sproc_Customers_Add*/
CREATE PROCEDURE sproc_Customers_Add
	@CustomerID int OUTPUT
	,@UserName nvarchar(100)
	,@Password nvarchar(100)
	,@FullName nvarchar(50)
	,@Gender bit
	,@Address nvarchar(250)
	,@IdentityCard nvarchar(15)
	,@MobileNumber nvarchar(15)
	,@HomePhone nvarchar(15)
	,@Email nvarchar(100)

AS

	INSERT INTO [Customers]
	(
		[CustomerID],
		[UserName],
		[Password],
		[FullName],
		[Gender],
		[Address],
		[IdentityCard],
		[MobileNumber],
		[HomePhone],
		[Email]
	)
	VALUES
	(
		@CustomerID,
		@UserName,
		@Password,
		@FullName,
		@Gender,
		@Address,
		@IdentityCard,
		@MobileNumber,
		@HomePhone,
		@Email
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Customers_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Customers_Update]
GO

/* Procedure sproc_Customers_Update*/
CREATE PROCEDURE sproc_Customers_Update
	@UserName nvarchar(100),
	@Password nvarchar(100),
	@FullName nvarchar(50),
	@Gender bit,
	@Address nvarchar(250),
	@IdentityCard nvarchar(15),
	@MobileNumber nvarchar(15),
	@HomePhone nvarchar(15),
	@Email nvarchar(100),
	@CustomerID int

AS
UPDATE [Customers]
SET
	[UserName] = @UserName,
	[Password] = @Password,
	[FullName] = @FullName,
	[Gender] = @Gender,
	[Address] = @Address,
	[IdentityCard] = @IdentityCard,
	[MobileNumber] = @MobileNumber,
	[HomePhone] = @HomePhone,
	[Email] = @Email
WHERE
	[CustomerID] = @CustomerID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Customers_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Customers_Delete]
GO

/* Procedure sproc_Customers_Delete*/
CREATE PROCEDURE sproc_Customers_Delete
	@CustomerID int
AS
DELETE
FROM
	[Customers]
WHERE
	[CustomerID] = @CustomerID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_District_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_District_GetCount]
GO

/* Procedure sproc_District_GetCount*/
CREATE PROCEDURE sproc_District_GetCount
AS
SELECT
	COUNT(*)
FROM
	[District]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_District_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_District_Get]
GO

/* Procedure sproc_District_Get*/
CREATE PROCEDURE sproc_District_Get
AS
SELECT
	--[DistrictID],
	--[CityID],
	--[DistrictName]

*
FROM
	[District]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_District_GetByDistrictID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_District_GetByDistrictID]
GO

/* Procedure sproc_District_GetByDistrictID*/
CREATE PROCEDURE sproc_District_GetByDistrictID
@DistrictID int
AS
SELECT
	--[DistrictID],
	--[CityID],
	--[DistrictName]

*
FROM
	[District]
WHERE
	[DistrictID] = @DistrictID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_District_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_District_GetPaged]
GO

/* Procedure sproc_District_GetPaged*/
CREATE PROCEDURE sproc_District_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [DistrictID]
FROM [District]


-- query out
SELECT *
FROM [District]
WHERE [DistrictID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_District_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_District_Add]
GO

/* Procedure sproc_District_Add*/
CREATE PROCEDURE sproc_District_Add
	@DistrictID int OUTPUT
	,@CityID int
	,@DistrictName nvarchar(100)

AS

	INSERT INTO [District]
	(
		[CityID],
		[DistrictName]
	)
	VALUES
	(
		@CityID,
		@DistrictName
	)
	SELECT
		@DistrictID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_District_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_District_Update]
GO

/* Procedure sproc_District_Update*/
CREATE PROCEDURE sproc_District_Update
	@CityID int,
	@DistrictName nvarchar(100),
	@DistrictID int

AS
UPDATE [District]
SET
	[CityID] = @CityID,
	[DistrictName] = @DistrictName
WHERE
	[DistrictID] = @DistrictID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_District_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_District_Delete]
GO

/* Procedure sproc_District_Delete*/
CREATE PROCEDURE sproc_District_Delete
	@DistrictID int
AS
DELETE
FROM
	[District]
WHERE
	[DistrictID] = @DistrictID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Group_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Group_GetCount]
GO

/* Procedure sproc_Group_GetCount*/
CREATE PROCEDURE sproc_Group_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Group]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Group_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Group_Get]
GO

/* Procedure sproc_Group_Get*/
CREATE PROCEDURE sproc_Group_Get
AS
SELECT
	--[GroupID],
	--[ParentID],
	--[GroupName],
	--[Description],
	--[Status],
	--[Priority],
	--[SwitchGroup]

*
FROM
	[Group]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Group_GetByGroupID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Group_GetByGroupID]
GO

/* Procedure sproc_Group_GetByGroupID*/
CREATE PROCEDURE sproc_Group_GetByGroupID
@GroupID int
AS
SELECT
	--[GroupID],
	--[ParentID],
	--[GroupName],
	--[Description],
	--[Status],
	--[Priority],
	--[SwitchGroup]

*
FROM
	[Group]
WHERE
	[GroupID] = @GroupID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Group_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Group_GetPaged]
GO

/* Procedure sproc_Group_GetPaged*/
CREATE PROCEDURE sproc_Group_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [GroupID]
FROM [Group]


-- query out
SELECT *
FROM [Group]
WHERE [GroupID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Group_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Group_Add]
GO

/* Procedure sproc_Group_Add*/
CREATE PROCEDURE sproc_Group_Add
	@GroupID int OUTPUT
	,@ParentID int
	,@GroupName nvarchar(100)
	,@Description nvarchar(250)
	,@Status tinyint
	,@Priority int
	,@SwitchGroup nvarchar(250)

AS

	INSERT INTO [Group]
	(
		[ParentID],
		[GroupName],
		[Description],
		[Status],
		[Priority],
		[SwitchGroup]
	)
	VALUES
	(
		@ParentID,
		@GroupName,
		@Description,
		@Status,
		@Priority,
		@SwitchGroup
	)
	SELECT
		@GroupID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Group_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Group_Update]
GO

/* Procedure sproc_Group_Update*/
CREATE PROCEDURE sproc_Group_Update
	@ParentID int,
	@GroupName nvarchar(100),
	@Description nvarchar(250),
	@Status tinyint,
	@Priority int,
	@SwitchGroup nvarchar(250),
	@GroupID int

AS
UPDATE [Group]
SET
	[ParentID] = @ParentID,
	[GroupName] = @GroupName,
	[Description] = @Description,
	[Status] = @Status,
	[Priority] = @Priority,
	[SwitchGroup] = @SwitchGroup
WHERE
	[GroupID] = @GroupID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Group_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Group_Delete]
GO

/* Procedure sproc_Group_Delete*/
CREATE PROCEDURE sproc_Group_Delete
	@GroupID int
AS
DELETE
FROM
	[Group]
WHERE
	[GroupID] = @GroupID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Home_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Home_GetCount]
GO

/* Procedure sproc_Home_GetCount*/
CREATE PROCEDURE sproc_Home_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Home]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Home_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Home_Get]
GO

/* Procedure sproc_Home_Get*/
CREATE PROCEDURE sproc_Home_Get
AS
SELECT
	--[HomeID],
	--[HomeTypeID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[FloorArea],
	--[GargenArea],
	--[HomeArea],
	--[BedroomNumber],
	--[TierNumber],
	--[Image1],
	--[Image2],
	--[Image3]

*
FROM
	[Home]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Home_GetByHomeID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Home_GetByHomeID]
GO

/* Procedure sproc_Home_GetByHomeID*/
CREATE PROCEDURE sproc_Home_GetByHomeID
@HomeID int
AS
SELECT
	--[HomeID],
	--[HomeTypeID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[FloorArea],
	--[GargenArea],
	--[HomeArea],
	--[BedroomNumber],
	--[TierNumber],
	--[Image1],
	--[Image2],
	--[Image3]

*
FROM
	[Home]
WHERE
	[HomeID] = @HomeID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Home_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Home_GetPaged]
GO

/* Procedure sproc_Home_GetPaged*/
CREATE PROCEDURE sproc_Home_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [HomeID]
FROM [Home]


-- query out
SELECT *
FROM [Home]
WHERE [HomeID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Home_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Home_Add]
GO

/* Procedure sproc_Home_Add*/
CREATE PROCEDURE sproc_Home_Add
	@HomeID int OUTPUT
	,@HomeTypeID int
	,@RealEstateOwnersID int
	,@RealEstateOwnersTypeID int
	,@RealEstateID int
	,@Description nvarchar(250)
	,@Address nvarchar(250)
	,@Price float(8)
	,@TotalArea float(8)
	,@FloorArea float(8)
	,@GargenArea float(8)
	,@HomeArea float(8)
	,@BedroomNumber tinyint
	,@TierNumber tinyint
	,@Image1 nvarchar(250)
	,@Image2 nvarchar(250)
	,@Image3 nvarchar(250)

AS

	INSERT INTO [Home]
	(
		[HomeTypeID],
		[RealEstateOwnersID],
		[RealEstateOwnersTypeID],
		[RealEstateID],
		[Description],
		[Address],
		[Price],
		[TotalArea],
		[FloorArea],
		[GargenArea],
		[HomeArea],
		[BedroomNumber],
		[TierNumber],
		[Image1],
		[Image2],
		[Image3]
	)
	VALUES
	(
		@HomeTypeID,
		@RealEstateOwnersID,
		@RealEstateOwnersTypeID,
		@RealEstateID,
		@Description,
		@Address,
		@Price,
		@TotalArea,
		@FloorArea,
		@GargenArea,
		@HomeArea,
		@BedroomNumber,
		@TierNumber,
		@Image1,
		@Image2,
		@Image3
	)
	SELECT
		@HomeID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Home_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Home_Update]
GO

/* Procedure sproc_Home_Update*/
CREATE PROCEDURE sproc_Home_Update
	@HomeTypeID int,
	@RealEstateOwnersID int,
	@RealEstateOwnersTypeID int,
	@RealEstateID int,
	@Description nvarchar(250),
	@Address nvarchar(250),
	@Price float(8),
	@TotalArea float(8),
	@FloorArea float(8),
	@GargenArea float(8),
	@HomeArea float(8),
	@BedroomNumber tinyint,
	@TierNumber tinyint,
	@Image1 nvarchar(250),
	@Image2 nvarchar(250),
	@Image3 nvarchar(250),
	@HomeID int

AS
UPDATE [Home]
SET
	[HomeTypeID] = @HomeTypeID,
	[RealEstateOwnersID] = @RealEstateOwnersID,
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID,
	[RealEstateID] = @RealEstateID,
	[Description] = @Description,
	[Address] = @Address,
	[Price] = @Price,
	[TotalArea] = @TotalArea,
	[FloorArea] = @FloorArea,
	[GargenArea] = @GargenArea,
	[HomeArea] = @HomeArea,
	[BedroomNumber] = @BedroomNumber,
	[TierNumber] = @TierNumber,
	[Image1] = @Image1,
	[Image2] = @Image2,
	[Image3] = @Image3
WHERE
	[HomeID] = @HomeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Home_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Home_Delete]
GO

/* Procedure sproc_Home_Delete*/
CREATE PROCEDURE sproc_Home_Delete
	@HomeID int
AS
DELETE
FROM
	[Home]
WHERE
	[HomeID] = @HomeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_HomeType_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_HomeType_GetCount]
GO

/* Procedure sproc_HomeType_GetCount*/
CREATE PROCEDURE sproc_HomeType_GetCount
AS
SELECT
	COUNT(*)
FROM
	[HomeType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_HomeType_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_HomeType_Get]
GO

/* Procedure sproc_HomeType_Get*/
CREATE PROCEDURE sproc_HomeType_Get
AS
SELECT
	--[HomeTypeID],
	--[HomeTypeName]

*
FROM
	[HomeType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_HomeType_GetByHomeTypeID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_HomeType_GetByHomeTypeID]
GO

/* Procedure sproc_HomeType_GetByHomeTypeID*/
CREATE PROCEDURE sproc_HomeType_GetByHomeTypeID
@HomeTypeID int
AS
SELECT
	--[HomeTypeID],
	--[HomeTypeName]

*
FROM
	[HomeType]
WHERE
	[HomeTypeID] = @HomeTypeID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_HomeType_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_HomeType_GetPaged]
GO

/* Procedure sproc_HomeType_GetPaged*/
CREATE PROCEDURE sproc_HomeType_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [HomeTypeID]
FROM [HomeType]


-- query out
SELECT *
FROM [HomeType]
WHERE [HomeTypeID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_HomeType_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_HomeType_Add]
GO

/* Procedure sproc_HomeType_Add*/
CREATE PROCEDURE sproc_HomeType_Add
	@HomeTypeID int OUTPUT
	,@HomeTypeName nvarchar(100)

AS

	INSERT INTO [HomeType]
	(
		[HomeTypeName]
	)
	VALUES
	(
		@HomeTypeName
	)
	SELECT
		@HomeTypeID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_HomeType_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_HomeType_Update]
GO

/* Procedure sproc_HomeType_Update*/
CREATE PROCEDURE sproc_HomeType_Update
	@HomeTypeName nvarchar(100),
	@HomeTypeID int

AS
UPDATE [HomeType]
SET
	[HomeTypeName] = @HomeTypeName
WHERE
	[HomeTypeID] = @HomeTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_HomeType_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_HomeType_Delete]
GO

/* Procedure sproc_HomeType_Delete*/
CREATE PROCEDURE sproc_HomeType_Delete
	@HomeTypeID int
AS
DELETE
FROM
	[HomeType]
WHERE
	[HomeTypeID] = @HomeTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Land_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Land_GetCount]
GO

/* Procedure sproc_Land_GetCount*/
CREATE PROCEDURE sproc_Land_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Land]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Land_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Land_Get]
GO

/* Procedure sproc_Land_Get*/
CREATE PROCEDURE sproc_Land_Get
AS
SELECT
	--[LandID],
	--[LandTypeID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[Image1],
	--[Image2]

*
FROM
	[Land]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Land_GetByLandID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Land_GetByLandID]
GO

/* Procedure sproc_Land_GetByLandID*/
CREATE PROCEDURE sproc_Land_GetByLandID
@LandID int
AS
SELECT
	--[LandID],
	--[LandTypeID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[Image1],
	--[Image2]

*
FROM
	[Land]
WHERE
	[LandID] = @LandID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Land_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Land_GetPaged]
GO

/* Procedure sproc_Land_GetPaged*/
CREATE PROCEDURE sproc_Land_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [LandID]
FROM [Land]


-- query out
SELECT *
FROM [Land]
WHERE [LandID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Land_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Land_Add]
GO

/* Procedure sproc_Land_Add*/
CREATE PROCEDURE sproc_Land_Add
	@LandID int OUTPUT
	,@LandTypeID int
	,@RealEstateOwnersID int
	,@RealEstateOwnersTypeID int
	,@RealEstateID int
	,@Description nvarchar(250)
	,@Address nvarchar(250)
	,@Price float(8)
	,@TotalArea float(8)
	,@Image1 nvarchar(250)
	,@Image2 nvarchar(250)

AS

	INSERT INTO [Land]
	(
		[LandTypeID],
		[RealEstateOwnersID],
		[RealEstateOwnersTypeID],
		[RealEstateID],
		[Description],
		[Address],
		[Price],
		[TotalArea],
		[Image1],
		[Image2]
	)
	VALUES
	(
		@LandTypeID,
		@RealEstateOwnersID,
		@RealEstateOwnersTypeID,
		@RealEstateID,
		@Description,
		@Address,
		@Price,
		@TotalArea,
		@Image1,
		@Image2
	)
	SELECT
		@LandID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Land_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Land_Update]
GO

/* Procedure sproc_Land_Update*/
CREATE PROCEDURE sproc_Land_Update
	@LandTypeID int,
	@RealEstateOwnersID int,
	@RealEstateOwnersTypeID int,
	@RealEstateID int,
	@Description nvarchar(250),
	@Address nvarchar(250),
	@Price float(8),
	@TotalArea float(8),
	@Image1 nvarchar(250),
	@Image2 nvarchar(250),
	@LandID int

AS
UPDATE [Land]
SET
	[LandTypeID] = @LandTypeID,
	[RealEstateOwnersID] = @RealEstateOwnersID,
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID,
	[RealEstateID] = @RealEstateID,
	[Description] = @Description,
	[Address] = @Address,
	[Price] = @Price,
	[TotalArea] = @TotalArea,
	[Image1] = @Image1,
	[Image2] = @Image2
WHERE
	[LandID] = @LandID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Land_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Land_Delete]
GO

/* Procedure sproc_Land_Delete*/
CREATE PROCEDURE sproc_Land_Delete
	@LandID int
AS
DELETE
FROM
	[Land]
WHERE
	[LandID] = @LandID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_LandType_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_LandType_GetCount]
GO

/* Procedure sproc_LandType_GetCount*/
CREATE PROCEDURE sproc_LandType_GetCount
AS
SELECT
	COUNT(*)
FROM
	[LandType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_LandType_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_LandType_Get]
GO

/* Procedure sproc_LandType_Get*/
CREATE PROCEDURE sproc_LandType_Get
AS
SELECT
	--[LandTypeID],
	--[LandTypeName]

*
FROM
	[LandType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_LandType_GetByLandTypeID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_LandType_GetByLandTypeID]
GO

/* Procedure sproc_LandType_GetByLandTypeID*/
CREATE PROCEDURE sproc_LandType_GetByLandTypeID
@LandTypeID int
AS
SELECT
	--[LandTypeID],
	--[LandTypeName]

*
FROM
	[LandType]
WHERE
	[LandTypeID] = @LandTypeID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_LandType_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_LandType_GetPaged]
GO

/* Procedure sproc_LandType_GetPaged*/
CREATE PROCEDURE sproc_LandType_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [LandTypeID]
FROM [LandType]


-- query out
SELECT *
FROM [LandType]
WHERE [LandTypeID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_LandType_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_LandType_Add]
GO

/* Procedure sproc_LandType_Add*/
CREATE PROCEDURE sproc_LandType_Add
	@LandTypeID int OUTPUT
	,@LandTypeName nvarchar(100)

AS

	INSERT INTO [LandType]
	(
		[LandTypeName]
	)
	VALUES
	(
		@LandTypeName
	)
	SELECT
		@LandTypeID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_LandType_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_LandType_Update]
GO

/* Procedure sproc_LandType_Update*/
CREATE PROCEDURE sproc_LandType_Update
	@LandTypeName nvarchar(100),
	@LandTypeID int

AS
UPDATE [LandType]
SET
	[LandTypeName] = @LandTypeName
WHERE
	[LandTypeID] = @LandTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_LandType_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_LandType_Delete]
GO

/* Procedure sproc_LandType_Delete*/
CREATE PROCEDURE sproc_LandType_Delete
	@LandTypeID int
AS
DELETE
FROM
	[LandType]
WHERE
	[LandTypeID] = @LandTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Language_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Language_GetCount]
GO

/* Procedure sproc_Language_GetCount*/
CREATE PROCEDURE sproc_Language_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Language]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Language_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Language_Get]
GO

/* Procedure sproc_Language_Get*/
CREATE PROCEDURE sproc_Language_Get
AS
SELECT
	--[LanguageId],
	--[Name],
	--[ResourceFile],
	--[LanguageText]

*
FROM
	[Language]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Language_GetByLanguageId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Language_GetByLanguageId]
GO

/* Procedure sproc_Language_GetByLanguageId*/
CREATE PROCEDURE sproc_Language_GetByLanguageId
@LanguageId int
AS
SELECT
	--[LanguageId],
	--[Name],
	--[ResourceFile],
	--[LanguageText]

*
FROM
	[Language]
WHERE
	[LanguageId] = @LanguageId
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Language_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Language_GetPaged]
GO

/* Procedure sproc_Language_GetPaged*/
CREATE PROCEDURE sproc_Language_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [LanguageId]
FROM [Language]


-- query out
SELECT *
FROM [Language]
WHERE [LanguageId]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Language_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Language_Add]
GO

/* Procedure sproc_Language_Add*/
CREATE PROCEDURE sproc_Language_Add
	@LanguageId int OUTPUT
	,@Name nvarchar(50)
	,@ResourceFile nvarchar(50)
	,@LanguageText nvarchar(50)

AS

	INSERT INTO [Language]
	(
		[Name],
		[ResourceFile],
		[LanguageText]
	)
	VALUES
	(
		@Name,
		@ResourceFile,
		@LanguageText
	)
	SELECT
		@LanguageId = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Language_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Language_Update]
GO

/* Procedure sproc_Language_Update*/
CREATE PROCEDURE sproc_Language_Update
	@Name nvarchar(50),
	@ResourceFile nvarchar(50),
	@LanguageText nvarchar(50),
	@LanguageId int

AS
UPDATE [Language]
SET
	[Name] = @Name,
	[ResourceFile] = @ResourceFile,
	[LanguageText] = @LanguageText
WHERE
	[LanguageId] = @LanguageId
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Language_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Language_Delete]
GO

/* Procedure sproc_Language_Delete*/
CREATE PROCEDURE sproc_Language_Delete
	@LanguageId int
AS
DELETE
FROM
	[Language]
WHERE
	[LanguageId] = @LanguageId
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Location_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Location_GetCount]
GO

/* Procedure sproc_Location_GetCount*/
CREATE PROCEDURE sproc_Location_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Location]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Location_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Location_Get]
GO

/* Procedure sproc_Location_Get*/
CREATE PROCEDURE sproc_Location_Get
AS
SELECT
	--[LocationID],
	--[xcoor],
	--[ycoor]

*
FROM
	[Location]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Location_GetByLocationID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Location_GetByLocationID]
GO

/* Procedure sproc_Location_GetByLocationID*/
CREATE PROCEDURE sproc_Location_GetByLocationID
@LocationID int
AS
SELECT
	--[LocationID],
	--[xcoor],
	--[ycoor]

*
FROM
	[Location]
WHERE
	[LocationID] = @LocationID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Location_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Location_GetPaged]
GO

/* Procedure sproc_Location_GetPaged*/
CREATE PROCEDURE sproc_Location_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [LocationID]
FROM [Location]


-- query out
SELECT *
FROM [Location]
WHERE [LocationID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Location_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Location_Add]
GO

/* Procedure sproc_Location_Add*/
CREATE PROCEDURE sproc_Location_Add
	@LocationID int OUTPUT
	,@xcoor float(8)
	,@ycoor float(8)

AS

	INSERT INTO [Location]
	(
		[xcoor],
		[ycoor]
	)
	VALUES
	(
		@xcoor,
		@ycoor
	)
	SELECT
		@LocationID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Location_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Location_Update]
GO

/* Procedure sproc_Location_Update*/
CREATE PROCEDURE sproc_Location_Update
	@xcoor float(8),
	@ycoor float(8),
	@LocationID int

AS
UPDATE [Location]
SET
	[xcoor] = @xcoor,
	[ycoor] = @ycoor
WHERE
	[LocationID] = @LocationID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Location_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Location_Delete]
GO

/* Procedure sproc_Location_Delete*/
CREATE PROCEDURE sproc_Location_Delete
	@LocationID int
AS
DELETE
FROM
	[Location]
WHERE
	[LocationID] = @LocationID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Menus_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Menus_GetCount]
GO

/* Procedure sproc_Menus_GetCount*/
CREATE PROCEDURE sproc_Menus_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Menus]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Menus_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Menus_Get]
GO

/* Procedure sproc_Menus_Get*/
CREATE PROCEDURE sproc_Menus_Get
AS
SELECT
	--[MenuID],
	--[ParentID],
	--[PageID],
	--[MenuName],
	--[Position],
	--[Status],
	--[Priority],
	--[Param],
	--[GroupID]

*
FROM
	[Menus]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Menus_GetByMenuID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Menus_GetByMenuID]
GO

/* Procedure sproc_Menus_GetByMenuID*/
CREATE PROCEDURE sproc_Menus_GetByMenuID
@MenuID int
AS
SELECT
	--[MenuID],
	--[ParentID],
	--[PageID],
	--[MenuName],
	--[Position],
	--[Status],
	--[Priority],
	--[Param],
	--[GroupID]

*
FROM
	[Menus]
WHERE
	[MenuID] = @MenuID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Menus_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Menus_GetPaged]
GO

/* Procedure sproc_Menus_GetPaged*/
CREATE PROCEDURE sproc_Menus_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MenuID]
FROM [Menus]


-- query out
SELECT *
FROM [Menus]
WHERE [MenuID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Menus_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Menus_Add]
GO

/* Procedure sproc_Menus_Add*/
CREATE PROCEDURE sproc_Menus_Add
	@MenuID int OUTPUT
	,@ParentID int
	,@PageID int
	,@MenuName nvarchar(200)
	,@Position int
	,@Status bigint
	,@Priority int
	,@Param nvarchar(1000)
	,@GroupID int

AS

	INSERT INTO [Menus]
	(
		[ParentID],
		[PageID],
		[MenuName],
		[Position],
		[Status],
		[Priority],
		[Param],
		[GroupID]
	)
	VALUES
	(
		@ParentID,
		@PageID,
		@MenuName,
		@Position,
		@Status,
		@Priority,
		@Param,
		@GroupID
	)
	SELECT
		@MenuID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Menus_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Menus_Update]
GO

/* Procedure sproc_Menus_Update*/
CREATE PROCEDURE sproc_Menus_Update
	@ParentID int,
	@PageID int,
	@MenuName nvarchar(200),
	@Position int,
	@Status bigint,
	@Priority int,
	@Param nvarchar(1000),
	@GroupID int,
	@MenuID int

AS
UPDATE [Menus]
SET
	[ParentID] = @ParentID,
	[PageID] = @PageID,
	[MenuName] = @MenuName,
	[Position] = @Position,
	[Status] = @Status,
	[Priority] = @Priority,
	[Param] = @Param,
	[GroupID] = @GroupID
WHERE
	[MenuID] = @MenuID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Menus_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Menus_Delete]
GO

/* Procedure sproc_Menus_Delete*/
CREATE PROCEDURE sproc_Menus_Delete
	@MenuID int
AS
DELETE
FROM
	[Menus]
WHERE
	[MenuID] = @MenuID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Motel_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Motel_GetCount]
GO

/* Procedure sproc_Motel_GetCount*/
CREATE PROCEDURE sproc_Motel_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Motel]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Motel_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Motel_Get]
GO

/* Procedure sproc_Motel_Get*/
CREATE PROCEDURE sproc_Motel_Get
AS
SELECT
	--[MotelID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[MotelTypeID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[IsClosed],
	--[IsCooker],
	--[Furniture],
	--[TierNumber],
	--[Image1],
	--[Image2],
	--[Image3]

*
FROM
	[Motel]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Motel_GetByMotelID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Motel_GetByMotelID]
GO

/* Procedure sproc_Motel_GetByMotelID*/
CREATE PROCEDURE sproc_Motel_GetByMotelID
@MotelID int
AS
SELECT
	--[MotelID],
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateID],
	--[MotelTypeID],
	--[Description],
	--[Address],
	--[Price],
	--[TotalArea],
	--[IsClosed],
	--[IsCooker],
	--[Furniture],
	--[TierNumber],
	--[Image1],
	--[Image2],
	--[Image3]

*
FROM
	[Motel]
WHERE
	[MotelID] = @MotelID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Motel_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Motel_GetPaged]
GO

/* Procedure sproc_Motel_GetPaged*/
CREATE PROCEDURE sproc_Motel_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MotelID]
FROM [Motel]


-- query out
SELECT *
FROM [Motel]
WHERE [MotelID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Motel_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Motel_Add]
GO

/* Procedure sproc_Motel_Add*/
CREATE PROCEDURE sproc_Motel_Add
	@MotelID int OUTPUT
	,@RealEstateOwnersID int
	,@RealEstateOwnersTypeID int
	,@RealEstateID int
	,@MotelTypeID int
	,@Description nvarchar(250)
	,@Address nvarchar(250)
	,@Price float(8)
	,@TotalArea float(8)
	,@IsClosed bit
	,@IsCooker bit
	,@Furniture nvarchar(50)
	,@TierNumber tinyint
	,@Image1 nvarchar(250)
	,@Image2 nvarchar(250)
	,@Image3 nvarchar(250)

AS

	INSERT INTO [Motel]
	(
		[RealEstateOwnersID],
		[RealEstateOwnersTypeID],
		[RealEstateID],
		[MotelTypeID],
		[Description],
		[Address],
		[Price],
		[TotalArea],
		[IsClosed],
		[IsCooker],
		[Furniture],
		[TierNumber],
		[Image1],
		[Image2],
		[Image3]
	)
	VALUES
	(
		@RealEstateOwnersID,
		@RealEstateOwnersTypeID,
		@RealEstateID,
		@MotelTypeID,
		@Description,
		@Address,
		@Price,
		@TotalArea,
		@IsClosed,
		@IsCooker,
		@Furniture,
		@TierNumber,
		@Image1,
		@Image2,
		@Image3
	)
	SELECT
		@MotelID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Motel_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Motel_Update]
GO

/* Procedure sproc_Motel_Update*/
CREATE PROCEDURE sproc_Motel_Update
	@RealEstateOwnersID int,
	@RealEstateOwnersTypeID int,
	@RealEstateID int,
	@MotelTypeID int,
	@Description nvarchar(250),
	@Address nvarchar(250),
	@Price float(8),
	@TotalArea float(8),
	@IsClosed bit,
	@IsCooker bit,
	@Furniture nvarchar(50),
	@TierNumber tinyint,
	@Image1 nvarchar(250),
	@Image2 nvarchar(250),
	@Image3 nvarchar(250),
	@MotelID int

AS
UPDATE [Motel]
SET
	[RealEstateOwnersID] = @RealEstateOwnersID,
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID,
	[RealEstateID] = @RealEstateID,
	[MotelTypeID] = @MotelTypeID,
	[Description] = @Description,
	[Address] = @Address,
	[Price] = @Price,
	[TotalArea] = @TotalArea,
	[IsClosed] = @IsClosed,
	[IsCooker] = @IsCooker,
	[Furniture] = @Furniture,
	[TierNumber] = @TierNumber,
	[Image1] = @Image1,
	[Image2] = @Image2,
	[Image3] = @Image3
WHERE
	[MotelID] = @MotelID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Motel_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Motel_Delete]
GO

/* Procedure sproc_Motel_Delete*/
CREATE PROCEDURE sproc_Motel_Delete
	@MotelID int
AS
DELETE
FROM
	[Motel]
WHERE
	[MotelID] = @MotelID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_MotelType_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_MotelType_GetCount]
GO

/* Procedure sproc_MotelType_GetCount*/
CREATE PROCEDURE sproc_MotelType_GetCount
AS
SELECT
	COUNT(*)
FROM
	[MotelType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_MotelType_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_MotelType_Get]
GO

/* Procedure sproc_MotelType_Get*/
CREATE PROCEDURE sproc_MotelType_Get
AS
SELECT
	--[MotelTypeID],
	--[MotelTypeName]

*
FROM
	[MotelType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_MotelType_GetByMotelTypeID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_MotelType_GetByMotelTypeID]
GO

/* Procedure sproc_MotelType_GetByMotelTypeID*/
CREATE PROCEDURE sproc_MotelType_GetByMotelTypeID
@MotelTypeID int
AS
SELECT
	--[MotelTypeID],
	--[MotelTypeName]

*
FROM
	[MotelType]
WHERE
	[MotelTypeID] = @MotelTypeID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_MotelType_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_MotelType_GetPaged]
GO

/* Procedure sproc_MotelType_GetPaged*/
CREATE PROCEDURE sproc_MotelType_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MotelTypeID]
FROM [MotelType]


-- query out
SELECT *
FROM [MotelType]
WHERE [MotelTypeID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_MotelType_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_MotelType_Add]
GO

/* Procedure sproc_MotelType_Add*/
CREATE PROCEDURE sproc_MotelType_Add
	@MotelTypeID int OUTPUT
	,@MotelTypeName nvarchar(50)

AS

	INSERT INTO [MotelType]
	(
		[MotelTypeName]
	)
	VALUES
	(
		@MotelTypeName
	)
	SELECT
		@MotelTypeID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_MotelType_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_MotelType_Update]
GO

/* Procedure sproc_MotelType_Update*/
CREATE PROCEDURE sproc_MotelType_Update
	@MotelTypeName nvarchar(50),
	@MotelTypeID int

AS
UPDATE [MotelType]
SET
	[MotelTypeName] = @MotelTypeName
WHERE
	[MotelTypeID] = @MotelTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_MotelType_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_MotelType_Delete]
GO

/* Procedure sproc_MotelType_Delete*/
CREATE PROCEDURE sproc_MotelType_Delete
	@MotelTypeID int
AS
DELETE
FROM
	[MotelType]
WHERE
	[MotelTypeID] = @MotelTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Pages_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Pages_GetCount]
GO

/* Procedure sproc_Pages_GetCount*/
CREATE PROCEDURE sproc_Pages_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Pages]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Pages_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Pages_Get]
GO

/* Procedure sproc_Pages_Get*/
CREATE PROCEDURE sproc_Pages_Get
AS
SELECT
	--[PageID],
	--[Name],
	--[Tag],
	--[Conntent],
	--[Detail],
	--[Level],
	--[Title],
	--[Description],
	--[Keyword],
	--[Type],
	--[Link],
	--[Taget],
	--[Position],
	--[Index],
	--[Active],
	--[Lang],
	--[Ord]

*
FROM
	[Pages]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Pages_GetByPageID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Pages_GetByPageID]
GO

/* Procedure sproc_Pages_GetByPageID*/
CREATE PROCEDURE sproc_Pages_GetByPageID
@PageID int
AS
SELECT
	--[PageID],
	--[Name],
	--[Tag],
	--[Conntent],
	--[Detail],
	--[Level],
	--[Title],
	--[Description],
	--[Keyword],
	--[Type],
	--[Link],
	--[Taget],
	--[Position],
	--[Index],
	--[Active],
	--[Lang],
	--[Ord]

*
FROM
	[Pages]
WHERE
	[PageID] = @PageID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Pages_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Pages_GetPaged]
GO

/* Procedure sproc_Pages_GetPaged*/
CREATE PROCEDURE sproc_Pages_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [PageID]
FROM [Pages]


-- query out
SELECT *
FROM [Pages]
WHERE [PageID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Pages_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Pages_Add]
GO

/* Procedure sproc_Pages_Add*/
CREATE PROCEDURE sproc_Pages_Add
	@PageID int OUTPUT
	,@Name nvarchar(100)
	,@Tag nvarchar(255)
	,@Conntent ntext
	,@Detail nvarchar(250)
	,@Level int
	,@Title nvarchar(100)
	,@Description nvarchar(500)
	,@Keyword nvarchar(500)
	,@Type nvarchar(50)
	,@Link nvarchar(200)
	,@Taget nvarchar(100)
	,@Position int
	,@Index int
	,@Active int
	,@Lang nvarchar(50)
	,@Ord int

AS

	INSERT INTO [Pages]
	(
		[Name],
		[Tag],
		[Conntent],
		[Detail],
		[Level],
		[Title],
		[Description],
		[Keyword],
		[Type],
		[Link],
		[Taget],
		[Position],
		[Index],
		[Active],
		[Lang],
		[Ord]
	)
	VALUES
	(
		@Name,
		@Tag,
		@Conntent,
		@Detail,
		@Level,
		@Title,
		@Description,
		@Keyword,
		@Type,
		@Link,
		@Taget,
		@Position,
		@Index,
		@Active,
		@Lang,
		@Ord
	)
	SELECT
		@PageID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Pages_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Pages_Update]
GO

/* Procedure sproc_Pages_Update*/
CREATE PROCEDURE sproc_Pages_Update
	@Name nvarchar(100),
	@Tag nvarchar(255),
	@Conntent ntext,
	@Detail nvarchar(250),
	@Level int,
	@Title nvarchar(100),
	@Description nvarchar(500),
	@Keyword nvarchar(500),
	@Type nvarchar(50),
	@Link nvarchar(200),
	@Taget nvarchar(100),
	@Position int,
	@Index int,
	@Active int,
	@Lang nvarchar(50),
	@Ord int,
	@PageID int

AS
UPDATE [Pages]
SET
	[Name] = @Name,
	[Tag] = @Tag,
	[Conntent] = @Conntent,
	[Detail] = @Detail,
	[Level] = @Level,
	[Title] = @Title,
	[Description] = @Description,
	[Keyword] = @Keyword,
	[Type] = @Type,
	[Link] = @Link,
	[Taget] = @Taget,
	[Position] = @Position,
	[Index] = @Index,
	[Active] = @Active,
	[Lang] = @Lang,
	[Ord] = @Ord
WHERE
	[PageID] = @PageID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Pages_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Pages_Delete]
GO

/* Procedure sproc_Pages_Delete*/
CREATE PROCEDURE sproc_Pages_Delete
	@PageID int
AS
DELETE
FROM
	[Pages]
WHERE
	[PageID] = @PageID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_PostContract_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PostContract_GetCount]
GO

/* Procedure sproc_PostContract_GetCount*/
CREATE PROCEDURE sproc_PostContract_GetCount
AS
SELECT
	COUNT(*)
FROM
	[PostContract]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_PostContract_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PostContract_Get]
GO

/* Procedure sproc_PostContract_Get*/
CREATE PROCEDURE sproc_PostContract_Get
AS
SELECT
	--[PostContractID],
	--[PostContractName],
	--[StaffD],
	--[UserName],
	--[RealEstateID],
	--[Fees],
	--[CreateDate],
	--[EndDate],
	--[Status]

*
FROM
	[PostContract]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_PostContract_GetByPostContractID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PostContract_GetByPostContractID]
GO

/* Procedure sproc_PostContract_GetByPostContractID*/
CREATE PROCEDURE sproc_PostContract_GetByPostContractID
@PostContractID int
AS
SELECT
	--[PostContractID],
	--[PostContractName],
	--[StaffD],
	--[UserName],
	--[RealEstateID],
	--[Fees],
	--[CreateDate],
	--[EndDate],
	--[Status]

*
FROM
	[PostContract]
WHERE
	[PostContractID] = @PostContractID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_PostContract_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PostContract_GetPaged]
GO

/* Procedure sproc_PostContract_GetPaged*/
CREATE PROCEDURE sproc_PostContract_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [PostContractID]
FROM [PostContract]


-- query out
SELECT *
FROM [PostContract]
WHERE [PostContractID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_PostContract_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PostContract_Add]
GO

/* Procedure sproc_PostContract_Add*/
CREATE PROCEDURE sproc_PostContract_Add
	@PostContractID int OUTPUT
	,@PostContractName nvarchar(50)
	,@StaffD int
	,@UserName nvarchar(50)
	,@RealEstateID int
	,@Fees money
	,@CreateDate datetime
	,@EndDate datetime
	,@Status bit

AS

	INSERT INTO [PostContract]
	(
		[PostContractName],
		[StaffD],
		[UserName],
		[RealEstateID],
		[Fees],
		[CreateDate],
		[EndDate],
		[Status]
	)
	VALUES
	(
		@PostContractName,
		@StaffD,
		@UserName,
		@RealEstateID,
		@Fees,
		@CreateDate,
		@EndDate,
		@Status
	)
	SELECT
		@PostContractID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_PostContract_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PostContract_Update]
GO

/* Procedure sproc_PostContract_Update*/
CREATE PROCEDURE sproc_PostContract_Update
	@PostContractName nvarchar(50),
	@StaffD int,
	@UserName nvarchar(50),
	@RealEstateID int,
	@Fees money,
	@CreateDate datetime,
	@EndDate datetime,
	@Status bit,
	@PostContractID int

AS
UPDATE [PostContract]
SET
	[PostContractName] = @PostContractName,
	[StaffD] = @StaffD,
	[UserName] = @UserName,
	[RealEstateID] = @RealEstateID,
	[Fees] = @Fees,
	[CreateDate] = @CreateDate,
	[EndDate] = @EndDate,
	[Status] = @Status
WHERE
	[PostContractID] = @PostContractID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_PostContract_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PostContract_Delete]
GO

/* Procedure sproc_PostContract_Delete*/
CREATE PROCEDURE sproc_PostContract_Delete
	@PostContractID int
AS
DELETE
FROM
	[PostContract]
WHERE
	[PostContractID] = @PostContractID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_ProductType_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ProductType_GetCount]
GO

/* Procedure sproc_ProductType_GetCount*/
CREATE PROCEDURE sproc_ProductType_GetCount
AS
SELECT
	COUNT(*)
FROM
	[ProductType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_ProductType_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ProductType_Get]
GO

/* Procedure sproc_ProductType_Get*/
CREATE PROCEDURE sproc_ProductType_Get
AS
SELECT
	--[ProductTypeId],
	--[ProductTypeName],
	--[ProductTypeDescription],
	--[ProductTypeNameTranslationId],
	--[ProductTypeDescriptionNameTranslationId]

*
FROM
	[ProductType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_ProductType_GetByProductTypeId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ProductType_GetByProductTypeId]
GO

/* Procedure sproc_ProductType_GetByProductTypeId*/
CREATE PROCEDURE sproc_ProductType_GetByProductTypeId
@ProductTypeId int
AS
SELECT
	--[ProductTypeId],
	--[ProductTypeName],
	--[ProductTypeDescription],
	--[ProductTypeNameTranslationId],
	--[ProductTypeDescriptionNameTranslationId]

*
FROM
	[ProductType]
WHERE
	[ProductTypeId] = @ProductTypeId
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_ProductType_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ProductType_GetPaged]
GO

/* Procedure sproc_ProductType_GetPaged*/
CREATE PROCEDURE sproc_ProductType_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [ProductTypeId]
FROM [ProductType]


-- query out
SELECT *
FROM [ProductType]
WHERE [ProductTypeId]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_ProductType_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ProductType_Add]
GO

/* Procedure sproc_ProductType_Add*/
CREATE PROCEDURE sproc_ProductType_Add
	@ProductTypeId int OUTPUT
	,@ProductTypeName nvarchar(50)
	,@ProductTypeDescription nvarchar(1000)
	,@ProductTypeNameTranslationId int
	,@ProductTypeDescriptionNameTranslationId int

AS

	INSERT INTO [ProductType]
	(
		[ProductTypeId],
		[ProductTypeName],
		[ProductTypeDescription],
		[ProductTypeNameTranslationId],
		[ProductTypeDescriptionNameTranslationId]
	)
	VALUES
	(
		@ProductTypeId,
		@ProductTypeName,
		@ProductTypeDescription,
		@ProductTypeNameTranslationId,
		@ProductTypeDescriptionNameTranslationId
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_ProductType_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ProductType_Update]
GO

/* Procedure sproc_ProductType_Update*/
CREATE PROCEDURE sproc_ProductType_Update
	@ProductTypeName nvarchar(50),
	@ProductTypeDescription nvarchar(1000),
	@ProductTypeNameTranslationId int,
	@ProductTypeDescriptionNameTranslationId int,
	@ProductTypeId int

AS
UPDATE [ProductType]
SET
	[ProductTypeName] = @ProductTypeName,
	[ProductTypeDescription] = @ProductTypeDescription,
	[ProductTypeNameTranslationId] = @ProductTypeNameTranslationId,
	[ProductTypeDescriptionNameTranslationId] = @ProductTypeDescriptionNameTranslationId
WHERE
	[ProductTypeId] = @ProductTypeId
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_ProductType_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ProductType_Delete]
GO

/* Procedure sproc_ProductType_Delete*/
CREATE PROCEDURE sproc_ProductType_Delete
	@ProductTypeId int
AS
DELETE
FROM
	[ProductType]
WHERE
	[ProductTypeId] = @ProductTypeId
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateNews_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateNews_GetCount]
GO

/* Procedure sproc_RealEstateNews_GetCount*/
CREATE PROCEDURE sproc_RealEstateNews_GetCount
AS
SELECT
	COUNT(*)
FROM
	[RealEstateNews]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateNews_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateNews_Get]
GO

/* Procedure sproc_RealEstateNews_Get*/
CREATE PROCEDURE sproc_RealEstateNews_Get
AS
SELECT
	--[RealEstateNewsID],
	--[RealEstateID],
	--[Title],
	--[Content],
	--[CategoryID],
	--[Images],
	--[CreateDate],
	--[CreateBy],
	--[Source]

*
FROM
	[RealEstateNews]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateNews_GetByRealEstateNewsID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateNews_GetByRealEstateNewsID]
GO

/* Procedure sproc_RealEstateNews_GetByRealEstateNewsID*/
CREATE PROCEDURE sproc_RealEstateNews_GetByRealEstateNewsID
@RealEstateNewsID int
AS
SELECT
	--[RealEstateNewsID],
	--[RealEstateID],
	--[Title],
	--[Content],
	--[CategoryID],
	--[Images],
	--[CreateDate],
	--[CreateBy],
	--[Source]

*
FROM
	[RealEstateNews]
WHERE
	[RealEstateNewsID] = @RealEstateNewsID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateNews_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateNews_GetPaged]
GO

/* Procedure sproc_RealEstateNews_GetPaged*/
CREATE PROCEDURE sproc_RealEstateNews_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [RealEstateNewsID]
FROM [RealEstateNews]


-- query out
SELECT *
FROM [RealEstateNews]
WHERE [RealEstateNewsID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateNews_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateNews_Add]
GO

/* Procedure sproc_RealEstateNews_Add*/
CREATE PROCEDURE sproc_RealEstateNews_Add
	@RealEstateNewsID int OUTPUT
	,@RealEstateID int
	,@Title nvarchar(200)
	,@Content ntext
	,@CategoryID int
	,@Images nvarchar(250)
	,@CreateDate datetime
	,@CreateBy datetime
	,@Source nvarchar(200)

AS

	INSERT INTO [RealEstateNews]
	(
		[RealEstateNewsID],
		[RealEstateID],
		[Title],
		[Content],
		[CategoryID],
		[Images],
		[CreateDate],
		[CreateBy],
		[Source]
	)
	VALUES
	(
		@RealEstateNewsID,
		@RealEstateID,
		@Title,
		@Content,
		@CategoryID,
		@Images,
		@CreateDate,
		@CreateBy,
		@Source
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateNews_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateNews_Update]
GO

/* Procedure sproc_RealEstateNews_Update*/
CREATE PROCEDURE sproc_RealEstateNews_Update
	@RealEstateID int,
	@Title nvarchar(200),
	@Content ntext,
	@CategoryID int,
	@Images nvarchar(250),
	@CreateDate datetime,
	@CreateBy datetime,
	@Source nvarchar(200),
	@RealEstateNewsID int

AS
UPDATE [RealEstateNews]
SET
	[RealEstateID] = @RealEstateID,
	[Title] = @Title,
	[Content] = @Content,
	[CategoryID] = @CategoryID,
	[Images] = @Images,
	[CreateDate] = @CreateDate,
	[CreateBy] = @CreateBy,
	[Source] = @Source
WHERE
	[RealEstateNewsID] = @RealEstateNewsID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateNews_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateNews_Delete]
GO

/* Procedure sproc_RealEstateNews_Delete*/
CREATE PROCEDURE sproc_RealEstateNews_Delete
	@RealEstateNewsID int
AS
DELETE
FROM
	[RealEstateNews]
WHERE
	[RealEstateNewsID] = @RealEstateNewsID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwners_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwners_GetCount]
GO

/* Procedure sproc_RealEstateOwners_GetCount*/
CREATE PROCEDURE sproc_RealEstateOwners_GetCount
AS
SELECT
	COUNT(*)
FROM
	[RealEstateOwners]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwners_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwners_Get]
GO

/* Procedure sproc_RealEstateOwners_Get*/
CREATE PROCEDURE sproc_RealEstateOwners_Get
AS
SELECT
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateOwnersName],
	--[CLUR],
	--[Address],
	--[MobileNumber],
	--[Email],
	--[Gender],
	--[IdentityCard]

*
FROM
	[RealEstateOwners]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwners_GetByRealEstateOwnersID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwners_GetByRealEstateOwnersID]
GO

/* Procedure sproc_RealEstateOwners_GetByRealEstateOwnersID*/
CREATE PROCEDURE sproc_RealEstateOwners_GetByRealEstateOwnersID
@RealEstateOwnersID int
AS
SELECT
	--[RealEstateOwnersID],
	--[RealEstateOwnersTypeID],
	--[RealEstateOwnersName],
	--[CLUR],
	--[Address],
	--[MobileNumber],
	--[Email],
	--[Gender],
	--[IdentityCard]

*
FROM
	[RealEstateOwners]
WHERE
	[RealEstateOwnersID] = @RealEstateOwnersID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwners_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwners_GetPaged]
GO

/* Procedure sproc_RealEstateOwners_GetPaged*/
CREATE PROCEDURE sproc_RealEstateOwners_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [RealEstateOwnersID]
FROM [RealEstateOwners]


-- query out
SELECT *
FROM [RealEstateOwners]
WHERE [RealEstateOwnersID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwners_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwners_Add]
GO

/* Procedure sproc_RealEstateOwners_Add*/
CREATE PROCEDURE sproc_RealEstateOwners_Add
	@RealEstateOwnersID int OUTPUT
	,@RealEstateOwnersTypeID int
	,@RealEstateOwnersName nvarchar(100)
	,@CLUR tinyint
	,@Address nvarchar(200)
	,@MobileNumber nchar(15)
	,@Email nvarchar(100)
	,@Gender bit
	,@IdentityCard nchar(15)

AS

	INSERT INTO [RealEstateOwners]
	(
		[RealEstateOwnersTypeID],
		[RealEstateOwnersName],
		[CLUR],
		[Address],
		[MobileNumber],
		[Email],
		[Gender],
		[IdentityCard]
	)
	VALUES
	(
		@RealEstateOwnersTypeID,
		@RealEstateOwnersName,
		@CLUR,
		@Address,
		@MobileNumber,
		@Email,
		@Gender,
		@IdentityCard
	)
	SELECT
		@RealEstateOwnersID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwners_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwners_Update]
GO

/* Procedure sproc_RealEstateOwners_Update*/
CREATE PROCEDURE sproc_RealEstateOwners_Update
	@RealEstateOwnersTypeID int,
	@RealEstateOwnersName nvarchar(100),
	@CLUR tinyint,
	@Address nvarchar(200),
	@MobileNumber nchar(15),
	@Email nvarchar(100),
	@Gender bit,
	@IdentityCard nchar(15),
	@RealEstateOwnersID int

AS
UPDATE [RealEstateOwners]
SET
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID,
	[RealEstateOwnersName] = @RealEstateOwnersName,
	[CLUR] = @CLUR,
	[Address] = @Address,
	[MobileNumber] = @MobileNumber,
	[Email] = @Email,
	[Gender] = @Gender,
	[IdentityCard] = @IdentityCard
WHERE
	[RealEstateOwnersID] = @RealEstateOwnersID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwners_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwners_Delete]
GO

/* Procedure sproc_RealEstateOwners_Delete*/
CREATE PROCEDURE sproc_RealEstateOwners_Delete
	@RealEstateOwnersID int
AS
DELETE
FROM
	[RealEstateOwners]
WHERE
	[RealEstateOwnersID] = @RealEstateOwnersID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwnersType_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwnersType_GetCount]
GO

/* Procedure sproc_RealEstateOwnersType_GetCount*/
CREATE PROCEDURE sproc_RealEstateOwnersType_GetCount
AS
SELECT
	COUNT(*)
FROM
	[RealEstateOwnersType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwnersType_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwnersType_Get]
GO

/* Procedure sproc_RealEstateOwnersType_Get*/
CREATE PROCEDURE sproc_RealEstateOwnersType_Get
AS
SELECT
	--[RealEstateOwnersTypeID],
	--[RealEstateOwnersTypeName]

*
FROM
	[RealEstateOwnersType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwnersType_GetByRealEstateOwnersTypeID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwnersType_GetByRealEstateOwnersTypeID]
GO

/* Procedure sproc_RealEstateOwnersType_GetByRealEstateOwnersTypeID*/
CREATE PROCEDURE sproc_RealEstateOwnersType_GetByRealEstateOwnersTypeID
@RealEstateOwnersTypeID int
AS
SELECT
	--[RealEstateOwnersTypeID],
	--[RealEstateOwnersTypeName]

*
FROM
	[RealEstateOwnersType]
WHERE
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwnersType_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwnersType_GetPaged]
GO

/* Procedure sproc_RealEstateOwnersType_GetPaged*/
CREATE PROCEDURE sproc_RealEstateOwnersType_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [RealEstateOwnersTypeID]
FROM [RealEstateOwnersType]


-- query out
SELECT *
FROM [RealEstateOwnersType]
WHERE [RealEstateOwnersTypeID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwnersType_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwnersType_Add]
GO

/* Procedure sproc_RealEstateOwnersType_Add*/
CREATE PROCEDURE sproc_RealEstateOwnersType_Add
	@RealEstateOwnersTypeID int OUTPUT
	,@RealEstateOwnersTypeName nchar(10)

AS

	INSERT INTO [RealEstateOwnersType]
	(
		[RealEstateOwnersTypeName]
	)
	VALUES
	(
		@RealEstateOwnersTypeName
	)
	SELECT
		@RealEstateOwnersTypeID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwnersType_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwnersType_Update]
GO

/* Procedure sproc_RealEstateOwnersType_Update*/
CREATE PROCEDURE sproc_RealEstateOwnersType_Update
	@RealEstateOwnersTypeName nchar(10),
	@RealEstateOwnersTypeID int

AS
UPDATE [RealEstateOwnersType]
SET
	[RealEstateOwnersTypeName] = @RealEstateOwnersTypeName
WHERE
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateOwnersType_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateOwnersType_Delete]
GO

/* Procedure sproc_RealEstateOwnersType_Delete*/
CREATE PROCEDURE sproc_RealEstateOwnersType_Delete
	@RealEstateOwnersTypeID int
AS
DELETE
FROM
	[RealEstateOwnersType]
WHERE
	[RealEstateOwnersTypeID] = @RealEstateOwnersTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstates_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstates_GetCount]
GO

/* Procedure sproc_RealEstates_GetCount*/
CREATE PROCEDURE sproc_RealEstates_GetCount
AS
SELECT
	COUNT(*)
FROM
	[RealEstates]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstates_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstates_Get]
GO

/* Procedure sproc_RealEstates_Get*/
CREATE PROCEDURE sproc_RealEstates_Get
AS
SELECT
	--[RealEstateID],
	--[RealEstateName],
	--[RealEstateTypeID],
	--[LocationID],
	--[CityID],
	--[RegionID],
	--[DistrictID],
	--[RealEstateOwnersID],
	--[Address],
	--[Price],
	--[Description],
	--[CreateBy],
	--[CreateDate],
	--[Area],
	--[Lengh],
	--[Width],
	--[Height],
	--[Images],
	--[Status],
	--[IsVip],
	--[Period]

*
FROM
	[RealEstates]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstates_GetByRealEstateID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstates_GetByRealEstateID]
GO

/* Procedure sproc_RealEstates_GetByRealEstateID*/
CREATE PROCEDURE sproc_RealEstates_GetByRealEstateID
@RealEstateID int
AS
SELECT
	--[RealEstateID],
	--[RealEstateName],
	--[RealEstateTypeID],
	--[LocationID],
	--[CityID],
	--[RegionID],
	--[DistrictID],
	--[RealEstateOwnersID],
	--[Address],
	--[Price],
	--[Description],
	--[CreateBy],
	--[CreateDate],
	--[Area],
	--[Lengh],
	--[Width],
	--[Height],
	--[Images],
	--[Status],
	--[IsVip],
	--[Period]

*
FROM
	[RealEstates]
WHERE
	[RealEstateID] = @RealEstateID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstates_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstates_GetPaged]
GO

/* Procedure sproc_RealEstates_GetPaged*/
CREATE PROCEDURE sproc_RealEstates_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [RealEstateID]
FROM [RealEstates]


-- query out
SELECT *
FROM [RealEstates]
WHERE [RealEstateID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstates_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstates_Add]
GO

/* Procedure sproc_RealEstates_Add*/
CREATE PROCEDURE sproc_RealEstates_Add
	@RealEstateID int OUTPUT
	,@RealEstateName nvarchar(100)
	,@RealEstateTypeID int
	,@LocationID int
	,@CityID int
	,@RegionID int
	,@DistrictID int
	,@RealEstateOwnersID int
	,@Address int
	,@Price float(8)
	,@Description nvarchar(250)
	,@CreateBy nvarchar(50)
	,@CreateDate datetime
	,@Area float(8)
	,@Lengh float(8)
	,@Width float(8)
	,@Height float(8)
	,@Images nvarchar(250)
	,@Status tinyint
	,@IsVip tinyint
	,@Period datetime

AS

	INSERT INTO [RealEstates]
	(
		[RealEstateName],
		[RealEstateTypeID],
		[LocationID],
		[CityID],
		[RegionID],
		[DistrictID],
		[RealEstateOwnersID],
		[Address],
		[Price],
		[Description],
		[CreateBy],
		[CreateDate],
		[Area],
		[Lengh],
		[Width],
		[Height],
		[Images],
		[Status],
		[IsVip],
		[Period]
	)
	VALUES
	(
		@RealEstateName,
		@RealEstateTypeID,
		@LocationID,
		@CityID,
		@RegionID,
		@DistrictID,
		@RealEstateOwnersID,
		@Address,
		@Price,
		@Description,
		@CreateBy,
		@CreateDate,
		@Area,
		@Lengh,
		@Width,
		@Height,
		@Images,
		@Status,
		@IsVip,
		@Period
	)
	SELECT
		@RealEstateID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstates_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstates_Update]
GO

/* Procedure sproc_RealEstates_Update*/
CREATE PROCEDURE sproc_RealEstates_Update
	@RealEstateName nvarchar(100),
	@RealEstateTypeID int,
	@LocationID int,
	@CityID int,
	@RegionID int,
	@DistrictID int,
	@RealEstateOwnersID int,
	@Address int,
	@Price float(8),
	@Description nvarchar(250),
	@CreateBy nvarchar(50),
	@CreateDate datetime,
	@Area float(8),
	@Lengh float(8),
	@Width float(8),
	@Height float(8),
	@Images nvarchar(250),
	@Status tinyint,
	@IsVip tinyint,
	@Period datetime,
	@RealEstateID int

AS
UPDATE [RealEstates]
SET
	[RealEstateName] = @RealEstateName,
	[RealEstateTypeID] = @RealEstateTypeID,
	[LocationID] = @LocationID,
	[CityID] = @CityID,
	[RegionID] = @RegionID,
	[DistrictID] = @DistrictID,
	[RealEstateOwnersID] = @RealEstateOwnersID,
	[Address] = @Address,
	[Price] = @Price,
	[Description] = @Description,
	[CreateBy] = @CreateBy,
	[CreateDate] = @CreateDate,
	[Area] = @Area,
	[Lengh] = @Lengh,
	[Width] = @Width,
	[Height] = @Height,
	[Images] = @Images,
	[Status] = @Status,
	[IsVip] = @IsVip,
	[Period] = @Period
WHERE
	[RealEstateID] = @RealEstateID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstates_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstates_Delete]
GO

/* Procedure sproc_RealEstates_Delete*/
CREATE PROCEDURE sproc_RealEstates_Delete
	@RealEstateID int
AS
DELETE
FROM
	[RealEstates]
WHERE
	[RealEstateID] = @RealEstateID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateType_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateType_GetCount]
GO

/* Procedure sproc_RealEstateType_GetCount*/
CREATE PROCEDURE sproc_RealEstateType_GetCount
AS
SELECT
	COUNT(*)
FROM
	[RealEstateType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateType_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateType_Get]
GO

/* Procedure sproc_RealEstateType_Get*/
CREATE PROCEDURE sproc_RealEstateType_Get
AS
SELECT
	--[RealEstateTypeID],
	--[NameRealEstateType],
	--[Description]

*
FROM
	[RealEstateType]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateType_GetByRealEstateTypeID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateType_GetByRealEstateTypeID]
GO

/* Procedure sproc_RealEstateType_GetByRealEstateTypeID*/
CREATE PROCEDURE sproc_RealEstateType_GetByRealEstateTypeID
@RealEstateTypeID int
AS
SELECT
	--[RealEstateTypeID],
	--[NameRealEstateType],
	--[Description]

*
FROM
	[RealEstateType]
WHERE
	[RealEstateTypeID] = @RealEstateTypeID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateType_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateType_GetPaged]
GO

/* Procedure sproc_RealEstateType_GetPaged*/
CREATE PROCEDURE sproc_RealEstateType_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [RealEstateTypeID]
FROM [RealEstateType]


-- query out
SELECT *
FROM [RealEstateType]
WHERE [RealEstateTypeID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateType_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateType_Add]
GO

/* Procedure sproc_RealEstateType_Add*/
CREATE PROCEDURE sproc_RealEstateType_Add
	@RealEstateTypeID int OUTPUT
	,@NameRealEstateType nvarchar(100)
	,@Description nvarchar(250)

AS

	INSERT INTO [RealEstateType]
	(
		[NameRealEstateType],
		[Description]
	)
	VALUES
	(
		@NameRealEstateType,
		@Description
	)
	SELECT
		@RealEstateTypeID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateType_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateType_Update]
GO

/* Procedure sproc_RealEstateType_Update*/
CREATE PROCEDURE sproc_RealEstateType_Update
	@NameRealEstateType nvarchar(100),
	@Description nvarchar(250),
	@RealEstateTypeID int

AS
UPDATE [RealEstateType]
SET
	[NameRealEstateType] = @NameRealEstateType,
	[Description] = @Description
WHERE
	[RealEstateTypeID] = @RealEstateTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_RealEstateType_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_RealEstateType_Delete]
GO

/* Procedure sproc_RealEstateType_Delete*/
CREATE PROCEDURE sproc_RealEstateType_Delete
	@RealEstateTypeID int
AS
DELETE
FROM
	[RealEstateType]
WHERE
	[RealEstateTypeID] = @RealEstateTypeID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Region_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Region_GetCount]
GO

/* Procedure sproc_Region_GetCount*/
CREATE PROCEDURE sproc_Region_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Region]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Region_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Region_Get]
GO

/* Procedure sproc_Region_Get*/
CREATE PROCEDURE sproc_Region_Get
AS
SELECT
	--[RegionID],
	--[RegionName]

*
FROM
	[Region]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Region_GetByRegionID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Region_GetByRegionID]
GO

/* Procedure sproc_Region_GetByRegionID*/
CREATE PROCEDURE sproc_Region_GetByRegionID
@RegionID int
AS
SELECT
	--[RegionID],
	--[RegionName]

*
FROM
	[Region]
WHERE
	[RegionID] = @RegionID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Region_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Region_GetPaged]
GO

/* Procedure sproc_Region_GetPaged*/
CREATE PROCEDURE sproc_Region_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [RegionID]
FROM [Region]


-- query out
SELECT *
FROM [Region]
WHERE [RegionID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Region_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Region_Add]
GO

/* Procedure sproc_Region_Add*/
CREATE PROCEDURE sproc_Region_Add
	@RegionID int OUTPUT
	,@RegionName nvarchar(100)

AS

	INSERT INTO [Region]
	(
		[RegionName]
	)
	VALUES
	(
		@RegionName
	)
	SELECT
		@RegionID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Region_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Region_Update]
GO

/* Procedure sproc_Region_Update*/
CREATE PROCEDURE sproc_Region_Update
	@RegionName nvarchar(100),
	@RegionID int

AS
UPDATE [Region]
SET
	[RegionName] = @RegionName
WHERE
	[RegionID] = @RegionID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Region_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Region_Delete]
GO

/* Procedure sproc_Region_Delete*/
CREATE PROCEDURE sproc_Region_Delete
	@RegionID int
AS
DELETE
FROM
	[Region]
WHERE
	[RegionID] = @RegionID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Staff_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Staff_GetCount]
GO

/* Procedure sproc_Staff_GetCount*/
CREATE PROCEDURE sproc_Staff_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Staff]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Staff_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Staff_Get]
GO

/* Procedure sproc_Staff_Get*/
CREATE PROCEDURE sproc_Staff_Get
AS
SELECT
	--[StaffID],
	--[Fullname],
	--[Gender],
	--[Address],
	--[IdNumber],
	--[PhoneNumber],
	--[HomePhone],
	--[Email]

*
FROM
	[Staff]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Staff_GetByStaffID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Staff_GetByStaffID]
GO

/* Procedure sproc_Staff_GetByStaffID*/
CREATE PROCEDURE sproc_Staff_GetByStaffID
@StaffID int
AS
SELECT
	--[StaffID],
	--[Fullname],
	--[Gender],
	--[Address],
	--[IdNumber],
	--[PhoneNumber],
	--[HomePhone],
	--[Email]

*
FROM
	[Staff]
WHERE
	[StaffID] = @StaffID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Staff_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Staff_GetPaged]
GO

/* Procedure sproc_Staff_GetPaged*/
CREATE PROCEDURE sproc_Staff_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [StaffID]
FROM [Staff]


-- query out
SELECT *
FROM [Staff]
WHERE [StaffID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Staff_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Staff_Add]
GO

/* Procedure sproc_Staff_Add*/
CREATE PROCEDURE sproc_Staff_Add
	@StaffID int OUTPUT
	,@Fullname nvarchar(20)
	,@Gender bit
	,@Address nvarchar(100)
	,@IdNumber nvarchar(15)
	,@PhoneNumber nvarchar(15)
	,@HomePhone nvarchar(15)
	,@Email nvarchar(50)

AS

	INSERT INTO [Staff]
	(
		[Fullname],
		[Gender],
		[Address],
		[IdNumber],
		[PhoneNumber],
		[HomePhone],
		[Email]
	)
	VALUES
	(
		@Fullname,
		@Gender,
		@Address,
		@IdNumber,
		@PhoneNumber,
		@HomePhone,
		@Email
	)
	SELECT
		@StaffID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Staff_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Staff_Update]
GO

/* Procedure sproc_Staff_Update*/
CREATE PROCEDURE sproc_Staff_Update
	@Fullname nvarchar(20),
	@Gender bit,
	@Address nvarchar(100),
	@IdNumber nvarchar(15),
	@PhoneNumber nvarchar(15),
	@HomePhone nvarchar(15),
	@Email nvarchar(50),
	@StaffID int

AS
UPDATE [Staff]
SET
	[Fullname] = @Fullname,
	[Gender] = @Gender,
	[Address] = @Address,
	[IdNumber] = @IdNumber,
	[PhoneNumber] = @PhoneNumber,
	[HomePhone] = @HomePhone,
	[Email] = @Email
WHERE
	[StaffID] = @StaffID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Staff_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Staff_Delete]
GO

/* Procedure sproc_Staff_Delete*/
CREATE PROCEDURE sproc_Staff_Delete
	@StaffID int
AS
DELETE
FROM
	[Staff]
WHERE
	[StaffID] = @StaffID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Users_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Users_GetCount]
GO

/* Procedure sproc_Users_GetCount*/
CREATE PROCEDURE sproc_Users_GetCount
AS
SELECT
	COUNT(*)
FROM
	[Users]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Users_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Users_Get]
GO

/* Procedure sproc_Users_Get*/
CREATE PROCEDURE sproc_Users_Get
AS
SELECT
	--[UserID],
	--[UserName],
	--[Password],
	--[FullName],
	--[Role],
	--[Gender],
	--[Avatar],
	--[CompanyName],
	--[Birthday],
	--[Email],
	--[Address],
	--[MobilePhone],
	--[HomePhone],
	--[IdentityCard],
	--[Status],
	--[LastLoggedOn],
	--[CreatedDate],
	--[CreatedBy],
	--[IsFirstLogin],
	--[GroupID],
	--[Active],
	--[Ord]

*
FROM
	[Users]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_Users_GetByUserID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Users_GetByUserID]
GO

/* Procedure sproc_Users_GetByUserID*/
CREATE PROCEDURE sproc_Users_GetByUserID
@UserID int
AS
SELECT
	--[UserID],
	--[UserName],
	--[Password],
	--[FullName],
	--[Role],
	--[Gender],
	--[Avatar],
	--[CompanyName],
	--[Birthday],
	--[Email],
	--[Address],
	--[MobilePhone],
	--[HomePhone],
	--[IdentityCard],
	--[Status],
	--[LastLoggedOn],
	--[CreatedDate],
	--[CreatedBy],
	--[IsFirstLogin],
	--[GroupID],
	--[Active],
	--[Ord]

*
FROM
	[Users]
WHERE
	[UserID] = @UserID
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Users_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Users_GetPaged]
GO

/* Procedure sproc_Users_GetPaged*/
CREATE PROCEDURE sproc_Users_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [UserID]
FROM [Users]


-- query out
SELECT *
FROM [Users]
WHERE [UserID]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_Users_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Users_Add]
GO

/* Procedure sproc_Users_Add*/
CREATE PROCEDURE sproc_Users_Add
	@UserID int OUTPUT
	,@UserName nvarchar(250)
	,@Password nvarchar(250)
	,@FullName nvarchar(50)
	,@Role int
	,@Gender bit
	,@Avatar nvarchar(200)
	,@CompanyName nvarchar(100)
	,@Birthday datetime
	,@Email nvarchar(100)
	,@Address nvarchar(250)
	,@MobilePhone nvarchar(50)
	,@HomePhone nvarchar(50)
	,@IdentityCard nvarchar(100)
	,@Status tinyint
	,@LastLoggedOn datetime
	,@CreatedDate datetime
	,@CreatedBy int
	,@IsFirstLogin bit
	,@GroupID int
	,@Active int
	,@Ord int

AS

	INSERT INTO [Users]
	(
		[UserName],
		[Password],
		[FullName],
		[Role],
		[Gender],
		[Avatar],
		[CompanyName],
		[Birthday],
		[Email],
		[Address],
		[MobilePhone],
		[HomePhone],
		[IdentityCard],
		[Status],
		[LastLoggedOn],
		[CreatedDate],
		[CreatedBy],
		[IsFirstLogin],
		[GroupID],
		[Active],
		[Ord]
	)
	VALUES
	(
		@UserName,
		@Password,
		@FullName,
		@Role,
		@Gender,
		@Avatar,
		@CompanyName,
		@Birthday,
		@Email,
		@Address,
		@MobilePhone,
		@HomePhone,
		@IdentityCard,
		@Status,
		@LastLoggedOn,
		@CreatedDate,
		@CreatedBy,
		@IsFirstLogin,
		@GroupID,
		@Active,
		@Ord
	)
	SELECT
		@UserID = @@Identity

GO
if exists (select * from sysobjects where id = object_id(N'[sproc_Users_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Users_Update]
GO

/* Procedure sproc_Users_Update*/
CREATE PROCEDURE sproc_Users_Update
	@UserName nvarchar(250),
	@Password nvarchar(250),
	@FullName nvarchar(50),
	@Role int,
	@Gender bit,
	@Avatar nvarchar(200),
	@CompanyName nvarchar(100),
	@Birthday datetime,
	@Email nvarchar(100),
	@Address nvarchar(250),
	@MobilePhone nvarchar(50),
	@HomePhone nvarchar(50),
	@IdentityCard nvarchar(100),
	@Status tinyint,
	@LastLoggedOn datetime,
	@CreatedDate datetime,
	@CreatedBy int,
	@IsFirstLogin bit,
	@GroupID int,
	@Active int,
	@Ord int,
	@UserID int

AS
UPDATE [Users]
SET
	[UserName] = @UserName,
	[Password] = @Password,
	[FullName] = @FullName,
	[Role] = @Role,
	[Gender] = @Gender,
	[Avatar] = @Avatar,
	[CompanyName] = @CompanyName,
	[Birthday] = @Birthday,
	[Email] = @Email,
	[Address] = @Address,
	[MobilePhone] = @MobilePhone,
	[HomePhone] = @HomePhone,
	[IdentityCard] = @IdentityCard,
	[Status] = @Status,
	[LastLoggedOn] = @LastLoggedOn,
	[CreatedDate] = @CreatedDate,
	[CreatedBy] = @CreatedBy,
	[IsFirstLogin] = @IsFirstLogin,
	[GroupID] = @GroupID,
	[Active] = @Active,
	[Ord] = @Ord
WHERE
	[UserID] = @UserID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_Users_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_Users_Delete]
GO

/* Procedure sproc_Users_Delete*/
CREATE PROCEDURE sproc_Users_Delete
	@UserID int
AS
DELETE
FROM
	[Users]
WHERE
	[UserID] = @UserID
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_action_map_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_action_map_GetCount]
GO

/* Procedure sproc_trace_xe_action_map_GetCount*/
CREATE PROCEDURE sproc_trace_xe_action_map_GetCount
AS
SELECT
	COUNT(*)
FROM
	[trace_xe_action_map]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_action_map_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_action_map_Get]
GO

/* Procedure sproc_trace_xe_action_map_Get*/
CREATE PROCEDURE sproc_trace_xe_action_map_Get
AS
SELECT
	--[trace_column_id],
	--[package_name],
	--[xe_action_name]

*
FROM
	[trace_xe_action_map]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_action_map_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_action_map_Add]
GO

/* Procedure sproc_trace_xe_action_map_Add*/
CREATE PROCEDURE sproc_trace_xe_action_map_Add
	@trace_column_id smallint,
	@package_name nvarchar(60),
	@xe_action_name nvarchar(60)
AS

	INSERT INTO [trace_xe_action_map]
	(
		[trace_column_id],
		[package_name],
		[xe_action_name]
	)
	VALUES
	(
		@trace_column_id,
		@package_name,
		@xe_action_name
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_event_map_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_event_map_GetCount]
GO

/* Procedure sproc_trace_xe_event_map_GetCount*/
CREATE PROCEDURE sproc_trace_xe_event_map_GetCount
AS
SELECT
	COUNT(*)
FROM
	[trace_xe_event_map]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_event_map_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_event_map_Get]
GO

/* Procedure sproc_trace_xe_event_map_Get*/
CREATE PROCEDURE sproc_trace_xe_event_map_Get
AS
SELECT
	--[trace_event_id],
	--[package_name],
	--[xe_event_name]

*
FROM
	[trace_xe_event_map]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_event_map_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_event_map_Add]
GO

/* Procedure sproc_trace_xe_event_map_Add*/
CREATE PROCEDURE sproc_trace_xe_event_map_Add
	@trace_event_id smallint,
	@package_name nvarchar(60),
	@xe_event_name nvarchar(60)
AS

	INSERT INTO [trace_xe_event_map]
	(
		[trace_event_id],
		[package_name],
		[xe_event_name]
	)
	VALUES
	(
		@trace_event_id,
		@package_name,
		@xe_event_name
	)
GO
