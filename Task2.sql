
CREATE TABLE Product(
  [ID] INT IDENTITY(1,1) PRIMARY KEY,
  [Name] NVARCHAR(128)
)

CREATE TABLE Category(
  [ID] INT IDENTITY(1,1) PRIMARY KEY,
  [Name] NVARCHAR(100)
)

CREATE TABLE ProductCategoryMap(
  [ID] INT IDENTITY(1,1) PRIMARY KEY,
  [ProductID] INT NOT NULL,
  [CategoryID] INT NOT NULL
)

ALTER TABLE ProductCategoryMap ADD CONSTRAINT FK_ProductCategoryMap_Product_ProductID FOREIGN KEY (ProductID)
REFERENCES Product (ID)

ALTER TABLE ProductCategoryMap ADD CONSTRAINT FK_ProductCategoryMap_Category_CategoryID FOREIGN KEY (CategoryID)
REFERENCES Category (ID)

INSERT Product VALUES ('Name1')
INSERT Product VALUES ('Name2')
INSERT Product VALUES ('Name3')

INSERT Category VALUES ('Category1')
INSERT Category VALUES ('Category2')
INSERT Category VALUES ('Category3')
INSERT Category VALUES ('Category4')

INSERT ProductCategoryMap(ProductID, CategoryID) VALUES (1,1)

INSERT ProductCategoryMap(ProductID, CategoryID) VALUES (2,1)
INSERT ProductCategoryMap(ProductID, CategoryID) VALUES (2,2)
INSERT ProductCategoryMap(ProductID, CategoryID) VALUES (2,3)

SELECT 
  prd.Name 'ProductName', cat.Name 'CategoryName'
FROM Product prd 
  LEFT JOIN ProductCategoryMap map ON prd.ID = map.ProductID
  LEFT JOIN Category cat ON cat.ID = map.CategoryID

