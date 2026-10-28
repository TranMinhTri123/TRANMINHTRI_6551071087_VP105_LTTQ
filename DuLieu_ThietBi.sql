IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DuLieu_ThietBi')
BEGIN
    CREATE DATABASE DuLieu_ThietBi;
END
GO

USE DuLieu_ThietBi;
GO

IF OBJECT_ID('dbo.ThietBi', 'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.ThietBi;
END
GO

CREATE TABLE ThietBi (
    MaThietBi  NVARCHAR(10) PRIMARY KEY,
    TenThietBi NTEXT        NOT NULL,
    DonGia     NVARCHAR(12) NOT NULL
);
GO

INSERT INTO ThietBi (MaThietBi, TenThietBi, DonGia) VALUES
(N'TB001', N'Máy tính xách tay Dell', N'15.000.000'),
(N'TB002', N'Máy in HP LaserJet',     N'5.500.000'),
(N'TB003', N'Màn hình Samsung',       N'3.800.000'),
(N'TB004', N'Bàn phím cơ Logitech',   N'1.200.000'),
(N'TB005', N'Chuột không dây',        N'450.000');
GO

SELECT * FROM ThietBi;
GO

