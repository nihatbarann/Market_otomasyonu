USE [market_otomasyonu]
GO
/****** Object:  Table [dbo].[Alis_Detay]    Script Date: 8.08.2022 22:47:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alis_Detay](
	[faturaAlisDetayID] [int] IDENTITY(1,1) NOT NULL,
	[FaturaAlisID] [int] NULL,
	[uid] [int] NULL,
	[urun_ad] [nvarchar](20) NULL,
	[fiyat] [money] NULL,
	[miktar] [float] NULL,
	[tutar] [money] NULL,
	[kdv] [float] NULL,
 CONSTRAINT [PK_Alis_Detay] PRIMARY KEY CLUSTERED 
(
	[faturaAlisDetayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaturaAlisUst]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaturaAlisUst](
	[FaturaAlisID] [int] IDENTITY(1,1) NOT NULL,
	[mid] [int] NULL,
	[faturaTarih] [date] NULL,
	[faturaSeri] [nvarchar](5) NULL,
	[faturaNo] [nvarchar](10) NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
 CONSTRAINT [PK_FaturaAlisUst] PRIMARY KEY CLUSTERED 
(
	[FaturaAlisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FaturaSatis]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FaturaSatis](
	[Fatura_id] [int] IDENTITY(1,1) NOT NULL,
	[mid] [int] NULL,
	[faturaTarih] [date] NULL,
	[faturaSeri] [nvarchar](5) NULL,
	[faturaNo] [nvarchar](15) NULL,
	[Ad] [nvarchar](50) NULL,
	[soyadı] [nvarchar](50) NULL,
 CONSTRAINT [PK_FaturaSatis] PRIMARY KEY CLUSTERED 
(
	[Fatura_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firma_tanim]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firma_tanim](
	[Firma_id] [int] IDENTITY(1,1) NOT NULL,
	[unvan] [nchar](10) NULL,
	[tel] [nvarchar](15) NULL,
	[adres] [nvarchar](100) NULL,
	[masa_sayisi] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Firma_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasaSatisDetay]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasaSatisDetay](
	[masa_detay_id] [int] IDENTITY(1,1) NOT NULL,
	[barkod] [nvarchar](20) NULL,
	[masa_ust_id] [int] NULL,
	[urun_id] [int] NULL,
	[urun_adi] [nvarchar](50) NULL,
	[urun_miktar] [nchar](10) NULL,
	[satis_fiyat] [float] NULL,
	[kdv] [float] NULL,
	[tutar] [float] NULL,
 CONSTRAINT [PK__MasaSati__B896EE8C3349D429] PRIMARY KEY CLUSTERED 
(
	[masa_detay_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasaSatisUst]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasaSatisUst](
	[masa_ust_id] [int] IDENTITY(1,1) NOT NULL,
	[masa] [nvarchar](20) NULL,
	[masa_durumu] [smallint] NULL,
	[odemeSekli] [nvarchar](20) NULL,
	[Tarih] [datetime] NULL,
	[seri_no] [nvarchar](10) NULL,
	[aciklama] [nvarchar](50) NULL,
	[IndırımSekli] [nchar](10) NULL,
	[Oran] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[masa_ust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri_tanim]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri_tanim](
	[mid] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[adres] [nvarchar](250) NULL,
	[tel] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[mid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satis_Detay]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis_Detay](
	[faturaDetayID] [int] IDENTITY(1,1) NOT NULL,
	[Fatura_id] [int] NOT NULL,
	[uid] [int] NULL,
	[urun_ad] [nvarchar](50) NULL,
	[fiyat] [money] NULL,
	[miktar] [float] NULL,
	[kdv] [float] NULL,
	[tutar] [money] NULL,
 CONSTRAINT [PK_Satis_Detay] PRIMARY KEY CLUSTERED 
(
	[faturaDetayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun_tanim]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun_tanim](
	[uid] [int] IDENTITY(1,1) NOT NULL,
	[barkod] [nvarchar](20) NULL,
	[kdv] [smallint] NULL,
	[urun_ad] [nvarchar](50) NULL,
	[urun_satis] [money] NULL,
	[urun_alis] [money] NULL,
	[satilan_miktar] [float] NULL,
	[alinan_miktar] [float] NULL,
 CONSTRAINT [PK__urun_tan__DD701264A3C63885] PRIMARY KEY CLUSTERED 
(
	[uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_Gelir]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[VW_Gelir]
as
SELECT	'Fatura Satış' as Tür,faturaTarih,faturaSeri,''as faturaNo,urun_ad,fiyat,miktar,kdv,tutar
FROM            FaturaSatis INNER JOIN
                         Satis_Detay ON FaturaSatis.Fatura_id = Satis_Detay.Fatura_id
union all
SELECT 'Masa Satış' as Tür,Tarih,seri_no,'' as faturaNo,urun_adi,satis_fiyat as fiyat,urun_miktar,kdv,tutar
FROM            MasaSatisUst INNER JOIN
                         MasaSatisDetay ON MasaSatisUst.masa_ust_id = MasaSatisDetay.masa_ust_id

GO
/****** Object:  View [dbo].[VW_Gider]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[VW_Gider]
as
SELECT     'Fatura Alış'as Tür,faturaTarih, faturaSeri, faturaNo, urun_ad, fiyat, miktar, kdv, tutar
FROM            FaturaAlisUst INNER JOIN
                         Alis_Detay ON FaturaAlisUst.FaturaAlisID = Alis_Detay.FaturaAlisID

GO
/****** Object:  View [dbo].[VW_KarZarar]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[VW_KarZarar]
as
SELECT	'Fatura Satış' as Tür,faturaTarih,faturaSeri,faturaNo,urun_ad,fiyat,miktar,kdv,tutar
FROM            FaturaSatis INNER JOIN
                         Satis_Detay ON FaturaSatis.Fatura_id = Satis_Detay.Fatura_id
union all 
SELECT 'Masa Satış' as Tür,tarih as faturaTarih,seri_no as faturaSeri,'' as faturaNo,urun_adi as urun_ad,satis_fiyat as fiyat,urun_miktar as miktar,kdv,tutar
FROM            MasaSatisUst INNER JOIN
                         MasaSatisDetay ON MasaSatisUst.masa_ust_id = MasaSatisDetay.masa_ust_id
union all
SELECT  'Fatura Alış'as Tür,faturaTarih, faturaSeri,faturaNo, urun_ad, fiyat,miktar,kdv,tutar
FROM            FaturaAlisUst INNER JOIN
                         Alis_Detay ON FaturaAlisUst.FaturaAlisID = Alis_Detay.FaturaAlisID

GO
/****** Object:  View [dbo].[VW_StokAlis]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create view [dbo].[VW_StokAlis]
as

SELECT  'Fatura Alış'as Tür,faturaTarih,faturaSeri,faturaNo,uid, urun_ad, fiyat, miktar, kdv,tutar
FROM            FaturaAlisUst INNER JOIN
                         Alis_Detay ON FaturaAlisUst.FaturaAlisID = Alis_Detay.FaturaAlisID

GO
/****** Object:  View [dbo].[VW_StokSatis]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[VW_StokSatis]
as
SELECT	'Fatura Satış' as Tür,faturaTarih as tarih,faturaSeri as seri_no,faturaNo,uid as urun_id,urun_ad as urun_adi,fiyat,miktar,kdv,tutar
FROM            FaturaSatis INNER JOIN
                         Satis_Detay ON FaturaSatis.Fatura_id = Satis_Detay.Fatura_id
union all 
SELECT 'Masa Satış' as Tür,tarih,seri_no,'' as faturaNo,urun_id,urun_adi,satis_fiyat as fiyat,urun_miktar as miktar,kdv,tutar
FROM            MasaSatisUst INNER JOIN
                         MasaSatisDetay ON MasaSatisUst.masa_ust_id = MasaSatisDetay.masa_ust_id

GO
SET IDENTITY_INSERT [dbo].[Alis_Detay] ON 
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (1, -1, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (2, -1, 30, N'çay', 2.0000, 1, 2.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (3, -1, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (4, -1, 34, N'fanta', 7.0000, 1, 7.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (5, 2, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (6, 2, 32, N'kola', 5.0000, 6, 30.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (7, 2, 30, N'çay', 2.0000, 1, 2.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (8, 2, 34, N'fanta', 7.0000, 1, 7.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (9, -1, 29, N'su', 2.0000, 50, 100.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (10, -3, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (11, -3, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (12, 6, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (13, 6, 31, N'kahve', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (14, 7, 30, N'çay', 2.0000, 1, 2.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (15, 7, 34, N'fanta', 7.0000, 1, 7.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (16, -1, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (17, -1, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (18, -1, 33, N'limonata', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (19, -1, 31, N'kahve', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (21, -1, 33, N'limonata', 5.0000, 5, 25.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (22, -1, 29, N'su', 2.0000, 100, 200.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (23, -1, 31, N'kahve', 5.0000, 2, 10.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (24, -1, 30, N'çay', 2.0000, 4, 8.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (25, -1, 29, N'su', 2.0000, 1, 2.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (26, -1, 33, N'limonata', 5.0000, 8, 40.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (27, -1, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (28, -1, 34, N'fanta', 7.0000, 5, 35.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (29, -1, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (30, -1, 29, N'su', 2.0000, 1, 2.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (31, -1, 33, N'limonata', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (32, -1, 31, N'kahve', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (33, 14, 30, N'çay', 2.0000, 1, 2.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (34, 14, 32, N'kola', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (35, 14, 33, N'limonata', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (36, 15, 36, N'cola', 3.0000, 9, 27.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (37, -1, 33, N'limonata', 5.0000, 1, 5.0000, 18)
GO
INSERT [dbo].[Alis_Detay] ([faturaAlisDetayID], [FaturaAlisID], [uid], [urun_ad], [fiyat], [miktar], [tutar], [kdv]) VALUES (38, -1, 31, N'kahve', 5.0000, 1, 5.0000, 18)
GO
SET IDENTITY_INSERT [dbo].[Alis_Detay] OFF
GO
SET IDENTITY_INSERT [dbo].[FaturaAlisUst] ON 
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (1, 10, CAST(N'2022-06-10' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (3, NULL, CAST(N'2022-06-10' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (5, 16, CAST(N'2022-06-10' AS Date), NULL, NULL, N'Ayşe', N'Duran')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (6, 10, CAST(N'2022-06-11' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (7, 10, CAST(N'2022-06-11' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (9, 10, CAST(N'2022-06-14' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (10, 16, CAST(N'2022-06-15' AS Date), NULL, NULL, N'Ayşe', N'Duran')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (11, 8, CAST(N'2022-06-15' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (12, 16, CAST(N'2022-06-15' AS Date), NULL, NULL, N'Ayşe', N'Duran')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (13, 16, CAST(N'2022-06-15' AS Date), NULL, NULL, N'Ayşe', N'Duran')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (14, 16, CAST(N'2022-06-15' AS Date), NULL, NULL, N'Ayşe', N'Duran')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (15, 18, CAST(N'2022-06-15' AS Date), NULL, NULL, N'recep', N'kara')
GO
INSERT [dbo].[FaturaAlisUst] ([FaturaAlisID], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [Soyad]) VALUES (16, 10, CAST(N'2022-08-08' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
SET IDENTITY_INSERT [dbo].[FaturaAlisUst] OFF
GO
SET IDENTITY_INSERT [dbo].[FaturaSatis] ON 
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (3, NULL, CAST(N'2022-04-01' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (21, 10, CAST(N'2022-04-14' AS Date), NULL, NULL, N'mehmet', N'demir')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (22, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (23, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (25, 8, CAST(N'2022-04-15' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (26, 10, CAST(N'2022-04-15' AS Date), NULL, NULL, N'mehmet', N'demir')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (27, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (28, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (29, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (30, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (31, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (32, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (33, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (34, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (35, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (36, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (38, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (39, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (40, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (41, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (42, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (43, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (44, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (45, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (46, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (47, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (49, NULL, CAST(N'2022-04-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (50, 8, CAST(N'2022-04-15' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (51, 9, CAST(N'2022-04-15' AS Date), NULL, NULL, N'ali', N'yılmaz')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (53, 9, CAST(N'2022-04-15' AS Date), NULL, NULL, N'ali', N'yılmaz')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (54, 8, CAST(N'2022-04-15' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (62, 10, CAST(N'2022-05-20' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (63, NULL, CAST(N'2022-05-20' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (64, NULL, CAST(N'2022-05-20' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (67, 10, CAST(N'2022-05-23' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (70, 10, CAST(N'2022-05-23' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (71, 16, CAST(N'2022-05-23' AS Date), NULL, NULL, N'as', N'as')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (74, NULL, CAST(N'2022-05-23' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (75, 8, CAST(N'2022-05-23' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (78, NULL, CAST(N'2022-05-26' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (80, 10, CAST(N'2022-05-26' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (81, 10, CAST(N'2022-05-27' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (82, NULL, CAST(N'2022-05-27' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (83, 8, CAST(N'2022-05-31' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (84, 10, CAST(N'2022-06-03' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (85, 8, CAST(N'2022-06-03' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (86, NULL, CAST(N'2022-06-10' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (89, NULL, CAST(N'2022-06-10' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (90, NULL, CAST(N'2022-06-10' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (93, NULL, CAST(N'2022-06-11' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (94, 10, CAST(N'2022-06-14' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (95, NULL, CAST(N'2022-06-15' AS Date), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (96, 8, CAST(N'2022-06-15' AS Date), NULL, NULL, N'ahmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (97, 10, CAST(N'2022-08-08' AS Date), NULL, NULL, N'mehmet', N'kaya')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (98, 19, CAST(N'2022-08-08' AS Date), NULL, NULL, N'ismail', N'tekeş')
GO
INSERT [dbo].[FaturaSatis] ([Fatura_id], [mid], [faturaTarih], [faturaSeri], [faturaNo], [Ad], [soyadı]) VALUES (99, 18, CAST(N'2022-08-08' AS Date), NULL, NULL, N'recep', N'kara')
GO
SET IDENTITY_INSERT [dbo].[FaturaSatis] OFF
GO
SET IDENTITY_INSERT [dbo].[Firma_tanim] ON 
GO
INSERT [dbo].[Firma_tanim] ([Firma_id], [unvan], [tel], [adres], [masa_sayisi]) VALUES (25, NULL, NULL, NULL, 14)
GO
SET IDENTITY_INSERT [dbo].[Firma_tanim] OFF
GO
SET IDENTITY_INSERT [dbo].[MasaSatisDetay] ON 
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (1, N'', 7, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (2, N'', 7, 8, N'çay', N'1         ', 7, 5, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (3, N'', 7, 9, N'oralet', N'5         ', 2, 0, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (4, N'01', 10, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (5, N'', 10, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (6, N'', 10, 9, N'oralet', N'1         ', 2, 0, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (7, N'01', 11, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (8, N'', 11, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (9, N'02', 13, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (10, N'01', 13, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (11, N'03', 13, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (12, N'04', 13, 13, N'ayran', N'1         ', 79, 0, 79)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (13, N'05', 13, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (15, N'05', 14, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (16, N'', 14, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (17, N'05', 14, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (18, N'03', 15, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (19, NULL, 15, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (21, NULL, 15, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (22, N'01', 22, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (23, N'02', 23, 12, N'limonata', N'2         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (24, N'03', 18, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (26, N'01', 26, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (27, N'02', 19, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (28, N'03', 19, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (29, N'01', 29, 7, N'fanta', N'1         ', 11, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (30, N'02', 20, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (31, N'03', 20, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (32, N'05', 20, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (33, N'03', 20, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (34, N'02', 20, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (35, N'', 20, 9, N'oralet', N'1         ', 2, 0, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (36, N'', 21, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (37, N'05', 21, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (38, N'', 21, 9, N'oralet', N'1         ', 2, 0, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (39, N'02', 21, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (40, N'03', 21, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (41, N'01', 21, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (42, N'05', 21, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (43, N'', 22, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (44, N'05', 22, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (45, N'', 22, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (46, N'', 22, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (47, N'', 22, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (48, N'', 22, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (49, N'', 22, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (50, N'', 23, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (51, N'05', 23, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (52, N'', 24, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (53, N'05', 24, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (54, N'01', 25, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (55, N'02', 25, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (56, N'03', 25, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (57, N'01', 26, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (58, N'02', 26, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (59, N'03', 26, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (60, N'', 27, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (61, N'05', 27, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (62, N'01', NULL, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (63, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (64, N'03', 28, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (65, N'01', NULL, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (66, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (67, N'03', 29, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (68, N'01', NULL, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (69, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (70, N'03', NULL, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (71, N'01', NULL, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (72, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (73, N'03', NULL, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (74, N'01', NULL, 7, N'fanta', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (75, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (76, N'03', NULL, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (77, N'01', NULL, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (78, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (79, N'03', NULL, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (80, N'01', NULL, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (81, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (82, N'03', NULL, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (83, N'04', NULL, 13, N'ayran', N'1         ', 79, 0, 79)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (84, N'01', NULL, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (85, N'05', NULL, 11, N'kahve', N'1         ', 3, 0, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (86, N'07', NULL, 8, N'çay', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (87, N'01', 36, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (88, N'02', 36, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (89, N'03', 36, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (90, N'01', 37, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (91, N'02', 37, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (92, N'03', 37, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (95, N'01', 39, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (96, N'02', 39, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (97, N'01', NULL, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (98, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (99, N'03', NULL, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (100, N'01', NULL, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (101, N'02', NULL, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (102, N'03', NULL, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (103, N'01', 42, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (104, N'03', 42, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (105, N'02', 42, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (106, N'01', 43, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (107, N'02', 43, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (108, N'03', 43, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (111, N'01', 41, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (112, N'02', 41, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (113, N'03', 41, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (117, N'01', 46, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (118, N'02', 46, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (119, N'04', 46, 13, N'ayran', N'1         ', 79, 0, 79)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (121, N'01', 40, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (122, N'02', 40, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (123, N'03', 40, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (133, N'01', 52, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (134, N'02', 52, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (135, N'03', 52, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (136, N'01', 53, 7, N'fanta', N'1         ', 11, 0, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (137, N'02', 53, 12, N'limonata', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (138, N'03', 53, 10, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (149, N'01', 59, 7, N'fanta', N'1         ', 11, 18, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (150, N'02', 59, 12, N'limonata', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (151, N'03', 59, 10, N'su', N'4         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (152, N'01', 60, 7, N'fanta', N'1         ', 11, 18, 11)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (153, N'02', 60, 12, N'limonata', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (154, N'03', 60, 10, N'su', N'3         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (155, N'01', 61, 7, N'fanta', N'5         ', 11, 18, 55)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (156, N'02', 61, 12, N'limonata', N'2         ', 5, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (157, N'02', 62, 12, N'limonata', N'3         ', 5, 18, 15)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (158, N'03', 62, 10, N'su', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (159, N'04', 62, 13, N'ayran', N'1         ', 79, 18, 79)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (160, N'01', 63, 7, N'fanta', N'3         ', 11, 18, 33)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (161, N'02', 63, 12, N'limonata', N'4         ', 5, 18, 20)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (162, N'03', 63, 10, N'su', N'4         ', 5, 18, 20)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (163, N'01', 64, 7, N'fanta', N'3         ', 11, 18, 33)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (164, N'02', 64, 12, N'limonata', N'3         ', 6, 18, 18)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (165, N'03', 64, 10, N'su', N'2         ', 5, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (166, N'04', 64, 13, N'ayran', N'1         ', 79, 18, 79)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (171, N'02', 66, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (172, N'03', 66, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (173, N'04', 66, 18, N'çay', N'1         ', 3, 18, 3)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (174, N'05', 66, 19, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (198, N'01', 76, 15, N'oralet', N'1         ', 7, 0, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (199, N'02', 76, 16, N'kahve', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (200, N'03', 76, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (202, N'03', NULL, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (204, N'03', NULL, 17, N'limonata', N'2         ', 10, 0, 20)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (206, N'03', NULL, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (208, N'04', NULL, 22, N'çay', N'3         ', 4, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (210, N'03', NULL, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (212, N'05', NULL, 23, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (214, N'03', NULL, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (216, N'01', NULL, 15, N'oralet', N'1         ', 7, 0, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (218, N'03', NULL, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (221, N'03', NULL, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (223, N'02', NULL, 16, N'kahve', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (235, N'02', 86, 16, N'kahve', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (236, N'03', 86, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (237, N'04', 86, 22, N'çay', N'1         ', 4, 0, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (238, N'01', 87, 15, N'oralet', N'1         ', 7, 0, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (239, N'03', 87, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (240, N'05', 87, 23, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (241, N'03', 87, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (242, N'02', 88, 16, N'kahve', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (243, N'01', 88, 15, N'oralet', N'1         ', 7, 0, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (244, N'03', 88, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (245, N'04', 88, 22, N'çay', N'1         ', 4, 0, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (246, N'05', 88, 23, N'su', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (260, N'01', 92, 15, N'oralet', N'1         ', 7, 0, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (261, N'02', 92, 16, N'kahve', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (262, N'03', 92, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (263, N'04', 92, 22, N'çay', N'1         ', 4, 0, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (264, N'01', 93, 15, N'oralet', N'1         ', 7, 0, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (265, N'02', 93, 16, N'kahve', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (266, N'03', 93, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (267, N'04', 93, 22, N'çay', N'1         ', 4, 0, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (271, N'01', 96, 15, N'oralet', N'1         ', 7, 0, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (272, N'02', 96, 16, N'kahve', N'1         ', 12, 0, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (273, N'03', 96, 17, N'limonata', N'1         ', 10, 0, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (307, N'03', 105, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (308, N'04', 105, 22, N'çay', N'5         ', 6, 18, 30)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (314, N'01', 108, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (315, N'02', 108, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (316, N'03', 108, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (317, N'04', 108, 22, N'çay', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (323, N'02', 110, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (328, N'03', 110, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (329, N'04', 110, 22, N'çay', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (330, N'01', 111, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (333, N'04', 111, 22, N'çay', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (334, N'01', 113, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (335, N'01', 113, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (336, N'02', 113, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (337, N'03', 113, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (338, N'04', 113, 22, N'çay', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (366, N'01', 120, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (367, N'02', 120, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (368, N'03', 120, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (369, N'04', 120, 22, N'çay', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (377, N'01', 122, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (378, N'02', 122, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (379, N'03', 122, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (380, N'04', 122, 22, N'çay', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (405, N'01', 129, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (406, N'02', 129, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (407, N'03', 129, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (408, N'04', 129, 22, N'çay', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (409, N'01', 130, 15, N'oralet', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (410, N'02', 130, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (411, N'03', 130, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (412, N'03', 130, 17, N'limonata', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (413, N'02', 130, 16, N'kahve', N'1         ', 12, 18, 12)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (422, N'01', 133, 29, N'su', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (423, N'02', 133, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (424, N'03', 133, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (425, N'04', 133, 32, N'kola', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (426, N'05', 133, 33, N'limonata', N'1         ', 15, 18, 15)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (427, N'01', 133, 29, N'su', N'1         ', 4, 18, 4)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (428, N'01', 134, 29, N'su', N'2         ', 5, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (429, N'02', 134, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (430, N'03', 134, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (431, N'04', 134, 32, N'kola', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (436, N'01', 136, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (437, N'02', 136, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (465, N'01', 143, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (466, N'02', 143, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (467, N'03', 143, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (468, N'04', 143, 32, N'kola', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (474, N'01', 145, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (475, N'02', 145, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (476, N'03', 145, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (477, N'04', 145, 32, N'kola', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (478, N'01', 147, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (479, N'02', 147, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (480, N'03', 147, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (481, N'04', 147, 32, N'kola', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (487, N'01', 147, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (505, N'01', 152, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (506, N'02', 152, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (507, N'03', 152, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (508, N'04', 152, 32, N'kola', N'5         ', 10, 18, 50)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (513, N'01', 154, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (514, N'02', 154, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (516, N'04', 154, 32, N'kola', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (519, N'03', 154, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (520, N'01', 156, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (521, N'02', 156, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (522, N'03', 156, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (523, N'04', 156, 32, N'kola', N'1         ', 10, 18, 10)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (532, N'01', 161, 29, N'su', N'1         ', 2, 18, 2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (533, N'02', 161, 30, N'çay', N'1         ', 5, 18, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (534, N'03', 161, 31, N'kahve', N'1         ', 7, 18, 7)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (545, N'06', 165, 34, N'fanta', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (546, N'06', 166, 34, N'fanta', N'1         ', 5, 0, 5)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (547, N'06', 167, 34, N'fanta', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (548, N'06', 168, 34, N'fanta', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (549, N'01', 169, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (550, N'02', 169, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (551, N'03', 169, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (552, N'04', 169, 32, N'kola', N'1         ', 10.2, 18, 10.2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (553, N'05', 169, 33, N'limonata', N'1         ', 16.32, 18, 16.32)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (554, N'02', 170, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (555, N'03', 170, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (556, N'04', 170, 32, N'kola', N'1         ', 10.2, 18, 10.2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (557, N'02', 171, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (558, N'03', 171, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (560, N'02', 171, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (561, N'05', 171, 33, N'limonata', N'1         ', 16.32, 18, 16.32)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (562, N'02', 172, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (563, N'02', 172, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (564, N'03', 172, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (565, N'04', 172, 32, N'kola', N'1         ', 10.2, 18, 10.2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (566, N'02', 173, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (567, N'01', 173, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (568, N'03', 173, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (569, N'04', 173, 32, N'kola', N'1         ', 10.2, 18, 10.2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (570, N'01', 173, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (571, N'02', 174, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (572, N'01', 174, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (573, N'02', 174, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (574, N'03', 174, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (575, N'02', 175, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (576, N'01', 175, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (577, N'03', 175, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (578, N'04', 175, 32, N'kola', N'1         ', 10.2, 18, 10.2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (579, N'01', 176, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (580, N'02', 176, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (581, N'01', 176, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (582, N'02', 176, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (583, N'03', 176, 31, N'kahve', N'1         ', 7.14, 18, 7.14)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (584, N'01', 177, 29, N'su', N'8         ', 2.04, 18, 16.32)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (585, N'01', 178, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (586, N'02', 178, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (587, N'03', 178, 31, N'kahve', N'6         ', 7.14, 18, 42.84)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (588, N'01', 178, 29, N'su', N'5         ', 2.04, 18, 10.2)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (589, N'02', 178, 30, N'çay', N'1         ', 5.1, 18, 5.1)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (590, N'03', 178, 31, N'kahve', N'4         ', 7.14, 18, 28.56)
GO
INSERT [dbo].[MasaSatisDetay] ([masa_detay_id], [barkod], [masa_ust_id], [urun_id], [urun_adi], [urun_miktar], [satis_fiyat], [kdv], [tutar]) VALUES (591, N'01', 178, 29, N'su', N'1         ', 2.04, 18, 2.04)
GO
SET IDENTITY_INSERT [dbo].[MasaSatisDetay] OFF
GO
SET IDENTITY_INSERT [dbo].[MasaSatisUst] ON 
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (1, N'16', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (6, N'15', NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (7, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (8, N'15', NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (9, N'masa: 14', NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (10, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (11, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (12, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (13, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (15, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (16, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (17, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (18, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (19, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (21, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (22, N'masa: 12', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (23, N'masa: 10', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (24, N'masa: 9', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (25, N'masa: 7', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (26, N'masa: 1', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (27, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (28, N'masa: 10', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (29, N'masa: 11', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (30, N'masa: 9', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (31, N'masa: 11', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (32, N'masa: 12', 1, N'Nakit', NULL, N'2', N'sxzx', NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (33, N'masa: 5', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (34, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (35, N'masa: 8', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (36, N'masa: 9', NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (37, NULL, NULL, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (39, N'Masa=10  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (40, N'Masa=5  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (41, N'Masa=7  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (42, N'Masa=7  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (43, N'Masa=7  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (46, N'Masa=5  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (49, N'Masa=6  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (52, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (53, N'Masa=14  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (56, N'Masa=8  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (57, N'Masa=8  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (59, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (60, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (61, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (62, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (63, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (64, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (66, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (71, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (76, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (86, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (87, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (88, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (92, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (93, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (94, N'Masa=6  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (96, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (105, N'Masa=7  D', 0, N'Kredi Kartı', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (108, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (110, N'Masa=6', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (111, N'Masa=11  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (112, N'Masa=9  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (113, N'Masa=11  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (120, N'Masa=11', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (122, NULL, 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (127, N'Masa=9  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (129, N'Masa=12', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (130, N'Masa=3', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (133, N'Masa=9  D', 1, N'Nakit', NULL, NULL, NULL, N'Yüzde     ', 10)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (134, N'Masa=10  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (136, N'Masa=12  D', 0, N'Nakit', NULL, NULL, NULL, N'TL        ', 5)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (139, N'Masa=6  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (143, N'Masa=9  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (145, N'Masa=9  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (146, N'Masa=11  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (147, N'Masa=9  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (150, N'Masa=5  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (152, NULL, 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (154, N'Masa=12  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (155, N'Masa=12  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (156, N'Masa=9  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (159, N'Masa=12  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (160, N'Masa=12  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (161, N'Masa=12  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (165, N'Masa=9  D', 1, N'Nakit', NULL, NULL, NULL, N'TL        ', 2)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (166, N'Masa=10  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (167, N'Masa=10  D', 1, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (168, N'Masa=10  D', 0, N'Nakit', NULL, NULL, NULL, N'TL        ', 5)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (169, N'Masa=10  D', 0, N'Nakit', NULL, N'21', N'scsacs', NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (170, N'Masa=8  D', 0, N'Nakit', NULL, N'21', N'sadas', NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (171, N'Masa=12  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (172, N'Masa=10', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (173, N'Masa=6', 0, N'Nakit', CAST(N'2022-06-14T00:00:00.000' AS DateTime), N'12', NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (174, N'Masa=10', 0, N'Nakit', NULL, N'12', N'sdf', NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (175, N'Masa=6', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (176, N'Masa=12  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (177, N'Masa=11  D', 0, N'Nakit', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[MasaSatisUst] ([masa_ust_id], [masa], [masa_durumu], [odemeSekli], [Tarih], [seri_no], [aciklama], [IndırımSekli], [Oran]) VALUES (178, N'Masa=10', 0, N'Nakit', CAST(N'2022-06-15T00:00:00.000' AS DateTime), NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[MasaSatisUst] OFF
GO
SET IDENTITY_INSERT [dbo].[musteri_tanim] ON 
GO
INSERT [dbo].[musteri_tanim] ([mid], [ad], [soyad], [adres], [tel]) VALUES (8, N'ahmet', N'kaya', N'dskdjasmdlksamd', N'(555) 555-5555')
GO
INSERT [dbo].[musteri_tanim] ([mid], [ad], [soyad], [adres], [tel]) VALUES (10, N'mehmet', N'kaya', N'sdssfsdfs', N'(333) 333-3333')
GO
INSERT [dbo].[musteri_tanim] ([mid], [ad], [soyad], [adres], [tel]) VALUES (16, N'Ayşe', N'Duran', N'sdfs', N'(555) 555-5555')
GO
INSERT [dbo].[musteri_tanim] ([mid], [ad], [soyad], [adres], [tel]) VALUES (18, N'recep', N'kara', N'asdas', N'(555) 444-4444')
GO
INSERT [dbo].[musteri_tanim] ([mid], [ad], [soyad], [adres], [tel]) VALUES (19, N'ismail', N'tekeş', N'adsad', N'(555) 555-555')
GO
INSERT [dbo].[musteri_tanim] ([mid], [ad], [soyad], [adres], [tel]) VALUES (20, N'Ramazan', N'Yağmur', N'asdas', N'(555) 555-5555')
GO
SET IDENTITY_INSERT [dbo].[musteri_tanim] OFF
GO
SET IDENTITY_INSERT [dbo].[Satis_Detay] ON 
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (17, -2, 8, N'çay', 2.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (18, -2, 9, N'oralet', 1.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (19, -2, 11, N'kahve', 5.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (20, 37, 11, N'kahve', 5.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (21, 37, 9, N'oralet', 1.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (22, 37, 7, N'fanta', 10.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (23, -1, 8, N'çay', 2.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (24, -1, 9, N'oralet', 1.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (25, -1, 10, N'su', 2.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (26, -1, 13, N'ayran', 9.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (27, 48, 9, N'oralet', 1.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (28, 48, 8, N'çay', 2.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (29, 48, 7, N'fanta', 10.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (30, 48, 9, N'oralet', 1.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (31, 48, 13, N'ayran', 9.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (32, -1, 18, N'çay', 1.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (33, -1, 16, N'kahve', 10.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (34, -1, 15, N'oralet', 3.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (35, -1, 16, N'kahve', 10.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (36, -1, 17, N'limonata', 8.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (37, -1, 17, N'limonata', 8.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (38, -1, 16, N'kahve', 10.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (39, -1, 15, N'oralet', 3.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (40, -1, 17, N'limonata', 8.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (41, -1, 19, N'su', 1.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (42, -1, 17, N'limonata', 8.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (43, -1, 15, N'oralet', 3.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (44, -1, 17, N'limonata', 8.0000, NULL, NULL, NULL)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (45, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (46, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (47, -1, 15, N'oralet', 3.0000, 1, 18, 3.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (48, -1, 22, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (49, -1, 22, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (50, -1, 17, N'limonata', 8.0000, 1, 18, 8.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (51, -1, 22, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (52, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (53, -1, 15, N'oralet', 3.0000, 1, 18, 3.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (54, -1, 23, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (55, -1, 22, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (56, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (57, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (58, -1, 17, N'limonata', 8.0000, 1, 18, 8.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (59, -1, 22, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (60, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (61, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (62, -1, 22, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (63, -1, 16, N'kahve', 10.0000, 1, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (64, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (65, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (66, -1, 33, N'limonata', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (67, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (68, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (69, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (70, -1, 33, N'limonata', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (71, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (72, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (73, -1, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (74, 69, 32, N'kola', 6.0000, 4, 18, 24.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (75, 69, 30, N'çay', 4.0000, 5, 18, 20.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (76, 69, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (77, 69, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (78, 69, 30, N'çay', 2.0000, 5, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (79, 69, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (80, -1, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (81, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (82, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (83, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (84, -2, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (85, -2, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (86, -2, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (87, -2, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (88, -2, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (89, -2, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (90, -2, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (91, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (92, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (93, -1, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (94, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (95, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (96, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (97, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (98, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (99, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (100, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (101, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (102, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (103, -1, 33, N'limonata', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (104, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (105, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (106, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (107, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (108, -3, 30, N'çay', 2.0000, 4, 18, 8.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (109, -3, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (110, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (111, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (112, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (113, -1, 32, N'kola', 5.0000, 50, 18, 250.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (114, -1, 32, N'kola', 5.0000, 10, 18, 50.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (115, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (116, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (117, -1, 29, N'su', 2.0000, 5, 18, 10.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (118, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (119, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (120, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (121, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (122, -1, 33, N'limonata', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (123, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (124, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (125, -1, 33, N'limonata', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (126, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (127, 87, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (128, 87, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (130, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (131, -1, 29, N'su', 2.0000, 7, 18, 14.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (132, -1, 31, N'kahve', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (134, -1, 31, N'kahve', 5.0000, 5, 18, 25.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (135, 92, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (136, 92, 32, N'kola', 5.0000, 5, 18, 25.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (137, -1, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (138, -1, 34, N'fanta', 7.0000, 1, 18, 7.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (140, -1, 33, N'limonata', 5.0000, 20, 18, 100.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (141, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (142, -1, 29, N'su', 2.0000, 70, 18, 140.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (143, -1, 30, N'çay', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (144, -1, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (145, -1, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (146, -1, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (147, 99, 29, N'su', 2.0000, 1, 18, 2.0000)
GO
INSERT [dbo].[Satis_Detay] ([faturaDetayID], [Fatura_id], [uid], [urun_ad], [fiyat], [miktar], [kdv], [tutar]) VALUES (148, 99, 32, N'kola', 5.0000, 1, 18, 5.0000)
GO
SET IDENTITY_INSERT [dbo].[Satis_Detay] OFF
GO
SET IDENTITY_INSERT [dbo].[urun_tanim] ON 
GO
INSERT [dbo].[urun_tanim] ([uid], [barkod], [kdv], [urun_ad], [urun_satis], [urun_alis], [satilan_miktar], [alinan_miktar]) VALUES (29, N'01', NULL, N'su', 2.0400, 2.0000, 125, 202)
GO
INSERT [dbo].[urun_tanim] ([uid], [barkod], [kdv], [urun_ad], [urun_satis], [urun_alis], [satilan_miktar], [alinan_miktar]) VALUES (30, N'02', NULL, N'çay', 5.1000, 2.0000, 50, 55)
GO
INSERT [dbo].[urun_tanim] ([uid], [barkod], [kdv], [urun_ad], [urun_satis], [urun_alis], [satilan_miktar], [alinan_miktar]) VALUES (31, N'03', NULL, N'kahve', 7.1400, 5.0000, 46, 44)
GO
INSERT [dbo].[urun_tanim] ([uid], [barkod], [kdv], [urun_ad], [urun_satis], [urun_alis], [satilan_miktar], [alinan_miktar]) VALUES (32, N'04', NULL, N'kola', 10.2000, 5.0000, 35, 63)
GO
INSERT [dbo].[urun_tanim] ([uid], [barkod], [kdv], [urun_ad], [urun_satis], [urun_alis], [satilan_miktar], [alinan_miktar]) VALUES (33, N'05', NULL, N'limonata', 16.3200, 5.0000, 26, 46)
GO
INSERT [dbo].[urun_tanim] ([uid], [barkod], [kdv], [urun_ad], [urun_satis], [urun_alis], [satilan_miktar], [alinan_miktar]) VALUES (34, N'06', NULL, N'fanta', 5.1000, 7.0000, 5, 15)
GO
SET IDENTITY_INSERT [dbo].[urun_tanim] OFF
GO
/****** Object:  Trigger [dbo].[AlisDetayEkle]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Trigger [dbo].[AlisDetayEkle] on [dbo].[Alis_Detay]
for insert
As
begin
declare @uid int,@miktar float

select @uid=uid,@miktar=miktar from inserted

Update urun_tanim set alinan_miktar=isnull(alinan_miktar,0)+isnull(@miktar,0)
where uid=@uid

end
GO
ALTER TABLE [dbo].[Alis_Detay] ENABLE TRIGGER [AlisDetayEkle]
GO
/****** Object:  Trigger [dbo].[AlisGuncelleme]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[AlisGuncelleme] on [dbo].[Alis_Detay]
for update
As
begin
	declare @in_uid int,@in_miktar float
	declare @del_uid int,@del_miktar float

	select @in_uid=uid,@in_miktar=miktar from inserted
	select @del_uid=uid,@del_miktar=miktar from deleted
	if update(miktar) or update(uid)
	begin
		if (@in_uid=@del_uid)
		begin
			Update Urun_Tanim set alinan_miktar=isnull(alinan_miktar,0)-isnull(@del_miktar,0)+isnull(@in_miktar,0)
			where uid=@in_uid
		end
		else
		begin
			Update Urun_Tanim set alinan_miktar=isnull(alinan_miktar,0)-isnull(@del_miktar,0)
			where uid=@del_uid
			Update Urun_Tanim set alinan_miktar=isnull(alinan_miktar,0)+isnull(@in_miktar,0)
			where uid=@in_uid
		end
	end

end
GO
ALTER TABLE [dbo].[Alis_Detay] ENABLE TRIGGER [AlisGuncelleme]
GO
/****** Object:  Trigger [dbo].[AlisSilme]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[AlisSilme] on [dbo].[Alis_Detay]
for delete
As
begin
declare @uid int,@miktar float

select @uid=uid,@miktar=miktar from deleted

Update urun_tanim set alinan_miktar=isnull(alinan_miktar,0)-isnull(@miktar,0)
where uid=@uid

end
GO
ALTER TABLE [dbo].[Alis_Detay] ENABLE TRIGGER [AlisSilme]
GO
/****** Object:  Trigger [dbo].[TR_SatisEkleme]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Trigger [dbo].[TR_SatisEkleme] on [dbo].[MasaSatisDetay]
for insert
As
begin
declare @uid int,@miktar float

select @uid=urun_id,@miktar=urun_miktar from inserted

Update urun_tanim set satilan_miktar=isnull(satilan_miktar,0)+isnull(@miktar,0)
where uid=@uid

end
GO
ALTER TABLE [dbo].[MasaSatisDetay] ENABLE TRIGGER [TR_SatisEkleme]
GO
/****** Object:  Trigger [dbo].[TR_SatisGuncellem]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Trigger [dbo].[TR_SatisGuncellem] on [dbo].[MasaSatisDetay]
for update
As
begin
	declare @in_uid int,@in_miktar float
	declare @del_uid int,@del_miktar float

	select @in_uid=urun_id,@in_miktar=urun_miktar from inserted
	select @del_uid=urun_id,@del_miktar=urun_miktar from deleted
	if update(urun_miktar) or update(urun_id)
	begin
		if (@in_uid=@del_uid)
		begin
			Update Urun_Tanim set satilan_miktar=isnull(satilan_miktar,0)-isnull(@del_miktar,0)+isnull(@in_miktar,0)
			where uid=@in_uid
		end
		else
		begin
			Update Urun_Tanim set satilan_miktar=isnull(satilan_miktar,0)-isnull(@del_miktar,0)
			where uid=@del_uid
			Update Urun_Tanim set satilan_miktar=isnull(satilan_miktar,0)+isnull(@in_miktar,0)
			where uid=@in_uid
		end
	end

end
GO
ALTER TABLE [dbo].[MasaSatisDetay] ENABLE TRIGGER [TR_SatisGuncellem]
GO
/****** Object:  Trigger [dbo].[TR_SatisSilme]    Script Date: 8.08.2022 22:47:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Trigger [dbo].[TR_SatisSilme] on [dbo].[MasaSatisDetay]
for delete
As
begin
declare @uid int,@miktar float

select @uid=urun_id,@miktar=urun_miktar from deleted

Update urun_tanim set satilan_miktar=isnull(satilan_miktar,0)-isnull(@miktar,0)
where uid=@uid

end
GO
ALTER TABLE [dbo].[MasaSatisDetay] ENABLE TRIGGER [TR_SatisSilme]
GO
/****** Object:  Trigger [dbo].[FaturaDetayEkle]    Script Date: 8.08.2022 22:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Trigger [dbo].[FaturaDetayEkle] on [dbo].[Satis_Detay]
for insert
As
begin
declare @uid int,@miktar float

select @uid=uid,@miktar=miktar from inserted

Update urun_tanim set satilan_miktar=isnull(satilan_miktar,0)+isnull(@miktar,0)
where uid=@uid

end
GO
ALTER TABLE [dbo].[Satis_Detay] ENABLE TRIGGER [FaturaDetayEkle]
GO
/****** Object:  Trigger [dbo].[SatisGuncellem]    Script Date: 8.08.2022 22:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Trigger [dbo].[SatisGuncellem] on [dbo].[Satis_Detay]
for update
As
begin
	declare @in_uid int,@in_miktar float
	declare @del_uid int,@del_miktar float

	select @in_uid=uid,@in_miktar=miktar from inserted
	select @del_uid=uid,@del_miktar=miktar from deleted
	if update(miktar) or update(uid)
	begin
		if (@in_uid=@del_uid)
		begin
			Update Urun_Tanim set satilan_miktar=isnull(satilan_miktar,0)-isnull(@del_miktar,0)+isnull(@in_miktar,0)
			where uid=@in_uid
		end
		else
		begin
			Update Urun_Tanim set satilan_miktar=isnull(satilan_miktar,0)-isnull(@del_miktar,0)
			where uid=@del_uid
			Update Urun_Tanim set satilan_miktar=isnull(satilan_miktar,0)+isnull(@in_miktar,0)
			where uid=@in_uid
		end
	end

end
GO
ALTER TABLE [dbo].[Satis_Detay] ENABLE TRIGGER [SatisGuncellem]
GO
/****** Object:  Trigger [dbo].[SatisSilme]    Script Date: 8.08.2022 22:47:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[SatisSilme] on [dbo].[Satis_Detay]
for delete
As
begin
declare @uid int,@miktar float

select @uid=uid,@miktar=miktar from deleted

Update urun_tanim set satilan_miktar=isnull(satilan_miktar,0)-isnull(@miktar,0)
where uid=@uid

end
GO
ALTER TABLE [dbo].[Satis_Detay] ENABLE TRIGGER [SatisSilme]
GO
