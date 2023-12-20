USE [Car]
CREATE TABLE Cars (
     ID INT PRIMARY KEY,
    BrandID INT,
    ColorID INT,
    Model VARCHAR(50),
    ModelYear INT,
    DailyPrice DECIMAL(10, 2),
    Description NVARCHAR(MAX)
    
);
CREATE TABLE Brands (
    BrandID INT PRIMARY KEY,
    BrandName VARCHAR(50),
   
);
CREATE TABLE Colors (
    ColorID INT PRIMARY KEY,
    ColorName VARCHAR(50),
    -- Diğer gerekli alanları buraya ekleyebilirsiniz.
);