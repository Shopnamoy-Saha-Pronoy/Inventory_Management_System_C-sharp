USE [InventoryM.System]
GO
/****** Object:  Table [dbo].[CategoryData]    Script Date: 5/2/2021 4:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CategoryData](
	[Id] [int] NOT NULL,
	[CategoryName] [varchar](40) NOT NULL,
 CONSTRAINT [PK_CategoryData] PRIMARY KEY CLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductData]    Script Date: 5/2/2021 4:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductData](
	[Id] [int] NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[CategoryName] [varchar](40) NULL,
	[ProductQuantity] [int] NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[ProductUnitPrice] [float] NULL,
	[SupplierName] [varchar](40) NULL,
 CONSTRAINT [PK_ProductData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesData]    Script Date: 5/2/2021 4:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[TotalBill] [float] NOT NULL,
 CONSTRAINT [PK_SalesData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SupplierData]    Script Date: 5/2/2021 4:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SupplierData](
	[Id] [int] NOT NULL,
	[SupplierName] [varchar](40) NOT NULL,
	[SupplierAddress] [varchar](50) NOT NULL,
	[SupplierBill] [float] NOT NULL,
	[SupplierPaidAmount] [float] NOT NULL,
 CONSTRAINT [PK_SupplierData] PRIMARY KEY CLUSTERED 
(
	[SupplierName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserData]    Script Date: 5/2/2021 4:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserData](
	[Id] [int] NOT NULL,
	[FullName] [varchar](40) NOT NULL,
	[UserName] [varchar](30) NOT NULL,
	[UserPassword] [varchar](30) NOT NULL,
	[UserPhone] [varchar](20) NOT NULL,
	[Role] [varchar](20) NOT NULL,
 CONSTRAINT [PK_UserData] PRIMARY KEY CLUSTERED 
(
	[FullName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CategoryData] ([Id], [CategoryName]) VALUES (2, N'Accessories')
INSERT [dbo].[CategoryData] ([Id], [CategoryName]) VALUES (1, N'Monitor')
INSERT [dbo].[CategoryData] ([Id], [CategoryName]) VALUES (5, N'Pendrive')
INSERT [dbo].[CategoryData] ([Id], [CategoryName]) VALUES (3, N'Tv')
INSERT [dbo].[CategoryData] ([Id], [CategoryName]) VALUES (4, N'Watch')
INSERT [dbo].[ProductData] ([Id], [ProductName], [CategoryName], [ProductQuantity], [ProductPrice], [ProductUnitPrice], [SupplierName]) VALUES (1, N'32 " Tv', N'Monitor', 18, 6000, 7000, N'Sony')
INSERT [dbo].[ProductData] ([Id], [ProductName], [CategoryName], [ProductQuantity], [ProductPrice], [ProductUnitPrice], [SupplierName]) VALUES (2, N'Imilab', N'Watch', 10, 3600, 3800, N'Lg')
INSERT [dbo].[ProductData] ([Id], [ProductName], [CategoryName], [ProductQuantity], [ProductPrice], [ProductUnitPrice], [SupplierName]) VALUES (3, N'Oppo', N'Monitor', 10, 5000, 6000, N'Like')
INSERT [dbo].[ProductData] ([Id], [ProductName], [CategoryName], [ProductQuantity], [ProductPrice], [ProductUnitPrice], [SupplierName]) VALUES (4, N'Pendrive', N'Accessories', 1, 450, 500, N'Sumash')
INSERT [dbo].[ProductData] ([Id], [ProductName], [CategoryName], [ProductQuantity], [ProductPrice], [ProductUnitPrice], [SupplierName]) VALUES (5, N'Walton', N'Tv', 55, 12000, 15000, N'Sumash')
INSERT [dbo].[ProductData] ([Id], [ProductName], [CategoryName], [ProductQuantity], [ProductPrice], [ProductUnitPrice], [SupplierName]) VALUES (6, N'Mouse', N'Accessories', 27, 700, 1000, N'Like')
SET IDENTITY_INSERT [dbo].[SalesData] ON 

INSERT [dbo].[SalesData] ([Id], [ProductName], [Quantity], [Price], [TotalBill]) VALUES (2, N'Imilab', 1, 3800, 3800)
INSERT [dbo].[SalesData] ([Id], [ProductName], [Quantity], [Price], [TotalBill]) VALUES (3, N'Imilab', 2, 3800, 7600)
SET IDENTITY_INSERT [dbo].[SalesData] OFF
INSERT [dbo].[SupplierData] ([Id], [SupplierName], [SupplierAddress], [SupplierBill], [SupplierPaidAmount]) VALUES (6, N'Asus Bangladesh', N'Uttara', 27000, 20000)
INSERT [dbo].[SupplierData] ([Id], [SupplierName], [SupplierAddress], [SupplierBill], [SupplierPaidAmount]) VALUES (4, N'Lg', N'Korea', 60000, 35000)
INSERT [dbo].[SupplierData] ([Id], [SupplierName], [SupplierAddress], [SupplierBill], [SupplierPaidAmount]) VALUES (3, N'Like', N'Bashundhara', 40000, 200)
INSERT [dbo].[SupplierData] ([Id], [SupplierName], [SupplierAddress], [SupplierBill], [SupplierPaidAmount]) VALUES (2, N'Sony', N'India', 40000, 100)
INSERT [dbo].[SupplierData] ([Id], [SupplierName], [SupplierAddress], [SupplierBill], [SupplierPaidAmount]) VALUES (1, N'Sumash', N'Bashundhara', 3000, 100)
INSERT [dbo].[SupplierData] ([Id], [SupplierName], [SupplierAddress], [SupplierBill], [SupplierPaidAmount]) VALUES (5, N'Walton Bangladesh', N'Dhaka', 45000, 44000)
INSERT [dbo].[UserData] ([Id], [FullName], [UserName], [UserPassword], [UserPhone], [Role]) VALUES (1, N'Alfaz', N'2', N'2', N'01234567891', N'user')
INSERT [dbo].[UserData] ([Id], [FullName], [UserName], [UserPassword], [UserPhone], [Role]) VALUES (1, N'Emran', N'1', N'1', N'01234567891', N'admin')
ALTER TABLE [dbo].[ProductData]  WITH CHECK ADD  CONSTRAINT [FK_ProductData_CategoryData] FOREIGN KEY([CategoryName])
REFERENCES [dbo].[CategoryData] ([CategoryName])
GO
ALTER TABLE [dbo].[ProductData] CHECK CONSTRAINT [FK_ProductData_CategoryData]
GO
ALTER TABLE [dbo].[SupplierData]  WITH CHECK ADD  CONSTRAINT [FK_SupplierData_SupplierData] FOREIGN KEY([SupplierName])
REFERENCES [dbo].[SupplierData] ([SupplierName])
GO
ALTER TABLE [dbo].[SupplierData] CHECK CONSTRAINT [FK_SupplierData_SupplierData]
GO
