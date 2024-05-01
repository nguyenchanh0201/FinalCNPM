-- Xóa cơ sở dữ liệu hiện tại nếu tồn tại
USE MASTER
DROP DATABASE IF EXISTS CafeteriaManagement;

-- Tạo cơ sở dữ liệu mới
CREATE DATABASE CafeteriaManagement;
GO
USE CafeteriaManagement;
GO

-- Bảng lưu thông tin về danh mục sản phẩm
CREATE TABLE ProductCategory
(
    CategoryID INT IDENTITY PRIMARY KEY,        -- ID của danh mục
    CategoryName NVARCHAR (100) NOT NULL        -- Tên của danh mục
)
GO

-- Bảng lưu thông tin về sản phẩm
CREATE TABLE Product
(
    ProductID INT IDENTITY PRIMARY KEY,          -- ID của sản phẩm
    ProductName NVARCHAR (100) NOT NULL,        -- Tên của sản phẩm
    CategoryID INT NOT NULL,                     -- ID của danh mục sản phẩm
    Price FLOAT NOT NULL,                        -- Giá của sản phẩm
    Status NVARCHAR(100) NOT NULL DEFAULT N'Available', -- Trạng thái của sản phẩm
    FOREIGN KEY (CategoryID) REFERENCES dbo.ProductCategory(CategoryID) -- Khóa ngoại liên kết với bảng ProductCategory
)
GO

-- Bảng lưu thông tin về mã giảm giá
CREATE TABLE Discount
(
    DiscountID INT IDENTITY PRIMARY KEY,         -- ID của mã giảm giá
    DiscountCode NVARCHAR (100) NOT NULL,        -- Mã giảm giá
    Percentage FLOAT NOT NULL                    -- Phần trăm giảm giá
)
GO

-- Bảng lưu thông tin về khách hàng
CREATE TABLE Customer
(
    CustomerID INT IDENTITY PRIMARY KEY,         -- ID của khách hàng
    CustomerName NVARCHAR(100) NOT NULL,         -- Tên của khách hàng
    PhoneNumber NVARCHAR(20) NOT NULL            -- Số điện thoại của khách hàng
)
GO

-- Bảng lưu thông tin về đơn hàng
CREATE TABLE OrderData
(
    OrderID INT IDENTITY PRIMARY KEY,            -- ID của đơn hàng
    OrderDate DATE NOT NULL,                     -- Ngày đặt hàng
    TotalAmount FLOAT NOT NULL,                  -- Tổng tiền
    PaymentMethod NVARCHAR(100) NOT NULL,        -- Phương thức thanh toán
    CustomerID INT,                              -- ID của khách hàng
    FOREIGN KEY (CustomerID) REFERENCES dbo.Customer(CustomerID)  -- Khóa ngoại liên kết với bảng Customer
)
GO

-- Bảng lưu thông tin chi tiết của mỗi đơn hàng
CREATE TABLE OrderDetail
(
    OrderDetailID INT IDENTITY PRIMARY KEY,       -- ID của chi tiết đơn hàng
    OrderID INT NOT NULL,                         -- ID của đơn hàng
    ProductID INT NOT NULL,                       -- ID của sản phẩm
    Quantity INT NOT NULL,                        -- Số lượng
    Price FLOAT NOT NULL,                         -- Giá tiền
    FOREIGN KEY (OrderID) REFERENCES dbo.OrderData(OrderID),         -- Khóa ngoại liên kết với bảng OrderData
    FOREIGN KEY (ProductID) REFERENCES dbo.Product(ProductID)   -- Khóa ngoại liên kết với bảng Product
)
GO

-- Bảng lưu thông tin về thẻ bàn
CREATE TABLE TableCard
(
    TableCardID INT IDENTITY PRIMARY KEY,         -- ID của thẻ bàn
    TableName NVARCHAR(100) NOT NULL,             -- Tên của thẻ bàn
    Status NVARCHAR(100) NOT NULL DEFAULT N'Available'   -- Trạng thái của thẻ bàn
)
GO

-- Bảng lưu thông tin thống kê
CREATE TABLE StatisticalData
(
    StatisticalID INT IDENTITY PRIMARY KEY,     -- ID của dữ liệu thống kê
    OrderDate DATE NOT NULL,                    -- Ngày đặt hàng
    OrderTime TIME NOT NULL,                    -- Thời gian đặt hàng
    OrderMethod NVARCHAR(100) NOT NULL,         -- Phương thức đặt hàng: mang về, tại quán, shipper
    Total FLOAT NOT NULL,                       -- Doanh thu
    CustomerID INT                               -- ID của khách hàng
);
GO

-- Bảng lưu thông tin về điểm và hạng thành viên của khách hàng
CREATE TABLE CustomerLoyalty (
    CustomerLoyaltyID INT IDENTITY PRIMARY KEY,
    CustomerID INT NOT NULL,
    Points INT NOT NULL DEFAULT 0,
    MembershipLevel NVARCHAR(100) NOT NULL DEFAULT N'Bronze',
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
GO

-- INSERT DATABASE
INSERT INTO ProductCategory (CategoryName)
VALUES ('Drinks'), ('Desserts'), ('Main Dishes'), ('Appetizers');

INSERT INTO Product (ProductName, CategoryID, Price, Status)
VALUES ('Espresso', 1, 2.5, 'Available'),
       ('Cappuccino', 1, 3.0, 'Available'),
       ('Chocolate Cake', 2, 5.0, 'Available'),
       ('Caesar Salad', 4, 7.5, 'Available');

INSERT INTO TableCard (TableName, Status)
VALUES ('Table 1', 'Available'),
       ('Table 2', 'Available'),
       ('Table 3', 'Available'),
       ('Table 4', 'Booked');

INSERT INTO Customer (CustomerName, PhoneNumber)
VALUES ('John Smith', '1234567890'),
       ('Alice Johnson', '0987654321'),
       ('Bob Brown', '5556667777');

INSERT INTO OrderData (OrderDate, TotalAmount, PaymentMethod, CustomerID)
VALUES 
    ('2024-04-18', 20.5, 'Cash', 1),
    ('2024-04-18', 15.0, 'Credit Card', 2),
    ('2024-04-19', 30.0, 'Cash', NULL); -- Changed CustomerID to NULL since no customer is associated with this order

INSERT INTO OrderDetail (OrderID, ProductID, Quantity, Price)
VALUES 
    (1, 1, 2, 5.0),
    (1, 3, 1, 10.0),
    (2, 2, 1, 3.0),
    (3, 4, 2, 15.0);

-- Thêm dữ liệu vào bảng StatisticalData
INSERT INTO StatisticalData (OrderDate, OrderTime, OrderMethod, Total, CustomerID)
VALUES 
    ('2024-04-18', '08:30:00', 'Take-away', 20.5, 1),
    ('2024-04-18', '09:15:00', 'Dine-in', 15.0, 2),
    ('2024-04-18', '12:45:00', 'Shipping', 30.0, NULL), -- Changed CustomerID to NULL since no customer is associated with this order
    ('2024-04-19', '10:30:00', 'Take-away', 0.0, NULL); -- Change the last value accordingly

-- Thêm dữ liệu vào bảng CustomerLoyalty
INSERT INTO CustomerLoyalty (CustomerID, Points, MembershipLevel)
VALUES
    (1, 50, N'Silver'),
    (2, 200, N'Gold'),
    (3, 800, N'Diamond');

-- TEST
SELECT * FROM ProductCategory;
SELECT * FROM Product;
SELECT * FROM TableCard;
SELECT * FROM Customer;
SELECT * FROM OrderData;
SELECT * FROM OrderDetail;
SELECT * FROM StatisticalData;
SELECT * FROM CustomerLoyalty;

GO

-- Câu truy vấn để lấy thông tin khách hàng và hạng thành viên
SELECT 
    c.CustomerName, 
    c.PhoneNumber, 
    cl.Points, 
    cl.MembershipLevel
FROM Customer c
JOIN CustomerLoyalty cl ON c.CustomerID = cl.CustomerID;