USE [RMS_DB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/5/2019 1:36:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 4/5/2019 1:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [nchar](10) NOT NULL,
	[CustomerName] [nchar](100) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[City] [varchar](250) NOT NULL,
	[ContactNo] [nchar](15) NOT NULL,
	[ContactNo1] [nchar](15) NULL,
	[Email] [varchar](250) NULL,
	[Notes] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Invoice_Info]    Script Date: 4/5/2019 1:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Invoice_Info](
	[InvoiceNo] [nchar](15) NOT NULL,
	[InvoiceDate] [nchar](30) NOT NULL,
	[SubTotal] [float] NOT NULL,
	[VATPer] [float] NOT NULL,
	[VATAmount] [float] NOT NULL,
	[DiscountPer] [float] NOT NULL,
	[DiscountAmount] [float] NOT NULL,
	[GrandTotal] [float] NOT NULL,
	[TotalPayment] [float] NOT NULL,
	[PaymentDue] [float] NOT NULL,
	[Remarks] [varchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 4/5/2019 1:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](max) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductSold]    Script Date: 4/5/2019 1:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductSold](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceNo] [nchar](15) NOT NULL,
	[ProductID] [int] NOT NULL,
	[ProductName] [varchar](250) NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalAmount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 4/5/2019 1:36:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registration](
	[UserName] [nchar](30) NOT NULL,
	[UserType] [nchar](20) NOT NULL,
	[Password] [nchar](30) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[ContactNo] [nchar](15) NOT NULL,
	[Email] [varchar](250) NULL,
	[JoiningDate] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [CategoryName]) VALUES (1, N'Veg')
SET IDENTITY_INSERT [dbo].[Category] OFF
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [Address], [City], [ContactNo], [ContactNo1], [Email], [Notes]) VALUES (N'C-611944  ', N'Raj Sharma                                                                                          ', N'356/3 malviya Nagar', N'Indore', N'9827938887     ', N'9827858191     ', N'rajlovesashi4ever@gmail.com', N'')
INSERT [dbo].[Invoice_Info] ([InvoiceNo], [InvoiceDate], [SubTotal], [VATPer], [VATAmount], [DiscountPer], [DiscountAmount], [GrandTotal], [TotalPayment], [PaymentDue], [Remarks]) VALUES (N'OD-49416594    ', N'04/Feb/2014                   ', 1420, 4.67, 66, 7.8, 116, 1370, 1370, 0, N'')
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (1, N'Paneer Butter Masala', 1, 220)
INSERT [dbo].[Product] ([ProductID], [ProductName], [CategoryID], [Price]) VALUES (2, N'Malai Kofte', 1, 190)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[ProductSold] ON 

INSERT [dbo].[ProductSold] ([Id], [InvoiceNo], [ProductID], [ProductName], [Price], [Quantity], [TotalAmount]) VALUES (18, N'OD-49416594    ', 2, N'Malai Kofte', 190, 4, 760)
INSERT [dbo].[ProductSold] ([Id], [InvoiceNo], [ProductID], [ProductName], [Price], [Quantity], [TotalAmount]) VALUES (19, N'OD-49416594    ', 1, N'Paneer Butter Masala', 220, 3, 660)
SET IDENTITY_INSERT [dbo].[ProductSold] OFF
INSERT [dbo].[Registration] ([UserName], [UserType], [Password], [Name], [ContactNo], [Email], [JoiningDate]) VALUES (N'admin                         ', N'Admin               ', N'admin                         ', N'Rabia', N'9876786543     ', N'Rabia.21@gmail.com', N'2/2/2014 11:21:34 AM                              ')
INSERT [dbo].[Registration] ([UserName], [UserType], [Password], [Name], [ContactNo], [Email], [JoiningDate]) VALUES (N'yousuf                        ', N'Cashier             ', N'a                             ', N'yousuf', N'03323017660    ', N'yousufsaleemshahani1994@gmail.com', N'4/5/2019 1:15:03 AM                               ')
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ToCategory] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ToCategory]
GO
ALTER TABLE [dbo].[ProductSold]  WITH CHECK ADD  CONSTRAINT [FK_ProductSold_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ProductSold] CHECK CONSTRAINT [FK_ProductSold_Product]
GO
ALTER TABLE [dbo].[ProductSold]  WITH CHECK ADD  CONSTRAINT [FK_Table_InvoiceInfo] FOREIGN KEY([InvoiceNo])
REFERENCES [dbo].[Invoice_Info] ([InvoiceNo])
GO
ALTER TABLE [dbo].[ProductSold] CHECK CONSTRAINT [FK_Table_InvoiceInfo]
GO
