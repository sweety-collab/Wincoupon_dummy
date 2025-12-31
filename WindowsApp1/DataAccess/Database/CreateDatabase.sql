/* ================================
  Coupon Management Database
  ================================ */
-- 1️⃣ Create Database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'CouponDB')
BEGIN
   CREATE DATABASE CouponDB;
END
GO
USE CouponDB;
GO
-- 2️⃣ Drop table if already exists (for re-run safety)
IF OBJECT_ID('Coupons', 'U') IS NOT NULL
BEGIN
   DROP TABLE Coupons;
END
GO
-- 3️⃣ Create Coupons table
CREATE TABLE Coupons
(
   Id INT IDENTITY(1,1) PRIMARY KEY,
   Code NVARCHAR(50) NOT NULL,
   Discount DECIMAL(10,2) NOT NULL,
   Status NVARCHAR(20) NOT NULL
);
GO
-- 4️⃣ Insert Dummy Data
INSERT INTO Coupons (Code, Discount, Status)
VALUES
('WELCOME10', 10.00, 'Approved'),
('NEWUSER20', 20.00, 'Pending'),
('FESTIVE30', 30.00, 'Pending');
GO
-- 5️⃣ Verify Data
SELECT * FROM Coupons;
GO


ALTER TABLE Coupons ADD
   DiscountType NVARCHAR(20),
   MinAmount DECIMAL(10,2),
   MaxDiscount DECIMAL(10,2),
   ExpiryDate DATE,
   IsActive BIT;
GO

INSERT INTO Coupons
(Code, Discount, DiscountType, MinAmount, MaxDiscount, ExpiryDate, IsActive, Status)
VALUES
('NEWYEAR25', 25, 'Percentage', 500, 200, '2025-12-31', 1, 'Pending');


CREATE TABLE CouponAuditLog
(
   Id INT IDENTITY PRIMARY KEY,
   CouponId INT,
   Action NVARCHAR(20),
   OldValue NVARCHAR(MAX),
   NewValue NVARCHAR(MAX),
   ActionDate DATETIME DEFAULT GETDATE()
);