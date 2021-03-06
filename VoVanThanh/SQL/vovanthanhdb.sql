CREATE DATABASE [VoVanThanhDB01]
GO
USE [VoVanThanhDB01]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 20/06/2021 12:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 20/06/2021 12:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[UnitCost] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[Image] [nvarchar](250) NULL,
	[Description] [nvarchar](255) NULL,
	[Status] [int] NULL,
	[ProductType] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 20/06/2021 12:24:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (1, N'Dell', N'a1ss')
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (2, N'ACER', N'Nitro 5')
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (3, N'ACER', N'Nitro 7')
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (4, N'HP', N'ProBook G450')
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (5, N'MacOS', N'SPP')
INSERT [dbo].[Category] ([ID], [Name], [Description]) VALUES (6, N'Asus', N'ROG')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (1, N'Hp probook G450', CAST(17000000 AS Decimal(18, 0)), 12, N'https://images.fpt.shop/unsafe/fit-in/665x374/filters:quality(100):fill(white)/fptshop.com.vn/Uploads/Originals/2021/2/24/637497775179419245_Laptop-Asus-Gaming-ROG%20Strix%20G512-IHN281T-i7-tan-nhiet.png', N'123', NULL, NULL)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (2, N'ddđ', CAST(1222222 AS Decimal(18, 0)), 22, N'https://images.fpt.shop/unsafe/fit-in/665x374/filters:quality(100):fill(white)/fptshop.com.vn/Uploads/Originals/2021/2/24/637497775179419245_Laptop-Asus-Gaming-ROG%20Strix%20G512-IHN281T-i7-tan-nhiet.png', N'22222', 1, 1)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (3, N'AcerNitro 52', CAST(5000000 AS Decimal(18, 0)), 2, N'https://fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/acer-nitro-5-2021-20.jpg', N'New 2019', 1, 2)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (4, N'Acer Nitro Gaming AN515', CAST(22490000 AS Decimal(18, 0)), 231, N'https://images.fpt.shop/unsafe/fit-in/filters:quality(90)/fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/macbook-pro-13-2020-1.jpg', N'44 R9JM R5 4600H/8GB/512GB SSD/Nvidia GTX1650 4GB/Win10', 1, 1)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (5, N'Laptop HP Envy 13', CAST(23790000 AS Decimal(18, 0)), 22, N'https://img.fpt.shop/f_jpg/cmpr_10/https://img.fpt.shop/f_jpg/cmpr_10/https://fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/hp-envy-13-2020-2.jpg', N'12312', 1, 4)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (6, N'24442', CAST(12323131 AS Decimal(18, 0)), 2323, N'https://img.fpt.shop/f_jpg/cmpr_10/https://img.fpt.shop/f_jpg/cmpr_10/https://fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/hp-envy-13-2020-2.jpg', N'441', 1, 3)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (7, N'2342222222', CAST(22 AS Decimal(18, 0)), 234, N'https://images.fpt.shop/unsafe/fit-in/filters:quality(90)/fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/macbook-pro-13-2020-1.jpg', N'33', 1, 5)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (8, N'Acer Nitro5 8300', CAST(19000000 AS Decimal(18, 0)), 1, N'https://fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/acer-nitro-5-2021-6.jpg', N'Hot New 100%', 1, 3)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (9, N'Macbook Prooooo', CAST(56000000 AS Decimal(18, 0)), 1, N'https://images.fpt.shop/unsafe/fit-in/filters:quality(90)/fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/macbook-pro-13-2020-1.jpg', N'Full New 100%, Zin keng, đẹp', 1, 5)
INSERT [dbo].[Product] ([ID], [Name], [UnitCost], [Quantity], [Image], [Description], [Status], [ProductType]) VALUES (10, N'MacBook Air 13', CAST(30990000 AS Decimal(18, 0)), 1, N'https://fptshop.com.vn/Uploads/images/2015/Tin-Tuc/QuanLNH2/macbook-air-m1-5.jpg', N'2020 M1 16GB/256GB', NULL, 5)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[UserAccount] ON 

INSERT [dbo].[UserAccount] ([ID], [Username], [Password], [Status]) VALUES (12, N'12324123123', N'a853b1a38660efd908b94c69a1ff53f7', N'122')
INSERT [dbo].[UserAccount] ([ID], [Username], [Password], [Status]) VALUES (7, N'admin', N'21232f297a57a5a743894a0e4a801fc3', N'True')
INSERT [dbo].[UserAccount] ([ID], [Username], [Password], [Status]) VALUES (10, N'thanhfvanwvowr', N'202cb962ac59075b964b07152d234b70', N'Blocked')
INSERT [dbo].[UserAccount] ([ID], [Username], [Password], [Status]) VALUES (9, N'thanhvanvo', N'202cb962ac59075b964b07152d234b70', N'True')
INSERT [dbo].[UserAccount] ([ID], [Username], [Password], [Status]) VALUES (8, N'tv2212', N'05a70454516ecd9194c293b0e415777f', NULL)
INSERT [dbo].[UserAccount] ([ID], [Username], [Password], [Status]) VALUES (13, N'vovanthanh', N'202cb962ac59075b964b07152d234b70', N'Blocked')
SET IDENTITY_INSERT [dbo].[UserAccount] OFF
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [fk_Product_Category] FOREIGN KEY([ProductType])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [fk_Product_Category]
GO
