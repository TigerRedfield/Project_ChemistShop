USE [ChemistShop]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 16.06.2023 21:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturers]    Script Date: 16.06.2023 21:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturers](
	[MedicineManufacturerId] [int] NOT NULL,
	[ManufacturerCountryId] [int] NOT NULL,
	[ManufacturerName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Manufacturers] PRIMARY KEY CLUSTERED 
(
	[MedicineManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManufacturersCountries]    Script Date: 16.06.2023 21:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManufacturersCountries](
	[ManufacturerCountryId] [int] NOT NULL,
	[ManufacturerCountryName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ManufacturersCountry] PRIMARY KEY CLUSTERED 
(
	[ManufacturerCountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicines]    Script Date: 16.06.2023 21:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicines](
	[MedicineId] [int] IDENTITY(1,1) NOT NULL,
	[MedicineManufacturerId] [int] NOT NULL,
	[MedicineName] [nvarchar](100) NOT NULL,
	[MedicineCost] [int] NOT NULL,
	[MedicineDiscount] [int] NOT NULL,
	[MedicineRank] [float] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[MedicineDateManufacturing] [date] NOT NULL,
	[MedicineExpirationDate] [int] NOT NULL,
 CONSTRAINT [PK_Medicines] PRIMARY KEY CLUSTERED 
(
	[MedicineId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Жаропонижающее')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Снотворное')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'Антисептик')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Иммуностимулирующее')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (5, N'Антибиотики')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (6, N'Сосудосуживающие')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (7, N'Противокашлевое')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (8, N'Противовосполительное')
GO
INSERT [dbo].[Manufacturers] ([MedicineManufacturerId], [ManufacturerCountryId], [ManufacturerName]) VALUES (1, 1, N'Bionorica')
INSERT [dbo].[Manufacturers] ([MedicineManufacturerId], [ManufacturerCountryId], [ManufacturerName]) VALUES (2, 3, N'Reckitt Benckiser Healthcare International Ltd')
INSERT [dbo].[Manufacturers] ([MedicineManufacturerId], [ManufacturerCountryId], [ManufacturerName]) VALUES (3, 2, N'Материа Медика Холдинг')
GO
INSERT [dbo].[ManufacturersCountries] ([ManufacturerCountryId], [ManufacturerCountryName]) VALUES (1, N'Германия')
INSERT [dbo].[ManufacturersCountries] ([ManufacturerCountryId], [ManufacturerCountryName]) VALUES (2, N'Россия')
INSERT [dbo].[ManufacturersCountries] ([ManufacturerCountryId], [ManufacturerCountryName]) VALUES (3, N'США')
INSERT [dbo].[ManufacturersCountries] ([ManufacturerCountryId], [ManufacturerCountryName]) VALUES (4, N'Япония')
INSERT [dbo].[ManufacturersCountries] ([ManufacturerCountryId], [ManufacturerCountryName]) VALUES (5, N'Китай')
GO
SET IDENTITY_INSERT [dbo].[Medicines] ON 

INSERT [dbo].[Medicines] ([MedicineId], [MedicineManufacturerId], [MedicineName], [MedicineCost], [MedicineDiscount], [MedicineRank], [CategoryId], [MedicineDateManufacturing], [MedicineExpirationDate]) VALUES (2, 1, N'Синупрет', 500, 5, 4.8, 8, CAST(N'2023-06-13' AS Date), 12)
INSERT [dbo].[Medicines] ([MedicineId], [MedicineManufacturerId], [MedicineName], [MedicineCost], [MedicineDiscount], [MedicineRank], [CategoryId], [MedicineDateManufacturing], [MedicineExpirationDate]) VALUES (3, 2, N'Нурофен', 300, 10, 4.9, 1, CAST(N'2023-06-14' AS Date), 36)
INSERT [dbo].[Medicines] ([MedicineId], [MedicineManufacturerId], [MedicineName], [MedicineCost], [MedicineDiscount], [MedicineRank], [CategoryId], [MedicineDateManufacturing], [MedicineExpirationDate]) VALUES (16, 3, N'Анаферон', 213, 11, 3.5, 4, CAST(N'2022-12-01' AS Date), 12)
SET IDENTITY_INSERT [dbo].[Medicines] OFF
GO
ALTER TABLE [dbo].[Manufacturers]  WITH CHECK ADD  CONSTRAINT [FK_Manufacturers_ManufacturersCountries] FOREIGN KEY([ManufacturerCountryId])
REFERENCES [dbo].[ManufacturersCountries] ([ManufacturerCountryId])
GO
ALTER TABLE [dbo].[Manufacturers] CHECK CONSTRAINT [FK_Manufacturers_ManufacturersCountries]
GO
ALTER TABLE [dbo].[Medicines]  WITH CHECK ADD  CONSTRAINT [FK_Medicines_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Medicines] CHECK CONSTRAINT [FK_Medicines_Category]
GO
ALTER TABLE [dbo].[Medicines]  WITH CHECK ADD  CONSTRAINT [FK_Medicines_Manufacturers] FOREIGN KEY([MedicineManufacturerId])
REFERENCES [dbo].[Manufacturers] ([MedicineManufacturerId])
GO
ALTER TABLE [dbo].[Medicines] CHECK CONSTRAINT [FK_Medicines_Manufacturers]
GO
