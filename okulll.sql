USE [okulll]
GO
/****** Object:  Table [dbo].[pru_ders]    Script Date: 7.12.2022 23:54:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pru_ders](
	[ders_id] [smallint] IDENTITY(1,1) NOT NULL,
	[ders_ad] [varchar](50) NULL,
	[ders_kredi] [varchar](50) NULL,
	[ders_okulyonetimid] [smallint] NULL,
 CONSTRAINT [PK_pru_ders] PRIMARY KEY CLUSTERED 
(
	[ders_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pru_ogrenci]    Script Date: 7.12.2022 23:54:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pru_ogrenci](
	[ogrenci_id] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrenci_fullname] [varchar](50) NULL,
	[ogrenci_recorddate] [datetime] NULL,
	[ogrenci_birthdate] [datetime] NULL,
	[ogrenci_bolum] [varchar](50) NULL,
	[ogrenci_no] [varchar](50) NULL,
 CONSTRAINT [PK_pru_ogrenci] PRIMARY KEY CLUSTERED 
(
	[ogrenci_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pru_ogrenciders]    Script Date: 7.12.2022 23:54:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pru_ogrenciders](
	[ogrenciders_id] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrenciders_dersid] [smallint] NULL,
	[ogrenciders_ogrenciid] [smallint] NULL,
 CONSTRAINT [PK_pru_ogrenciders] PRIMARY KEY CLUSTERED 
(
	[ogrenciders_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pru_okulyonetim]    Script Date: 7.12.2022 23:54:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pru_okulyonetim](
	[yonetim_id] [smallint] IDENTITY(1,1) NOT NULL,
	[yonetim_adsoyad] [varchar](50) NULL,
	[yonetim_gorev] [varchar](50) NULL,
	[yonetim_tip] [nchar](10) NULL,
 CONSTRAINT [PK_pru_okulyonetim] PRIMARY KEY CLUSTERED 
(
	[yonetim_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[pru_ders]  WITH CHECK ADD  CONSTRAINT [FK_pru_ders_pru_okulyonetim] FOREIGN KEY([ders_okulyonetimid])
REFERENCES [dbo].[pru_okulyonetim] ([yonetim_id])
GO
ALTER TABLE [dbo].[pru_ders] CHECK CONSTRAINT [FK_pru_ders_pru_okulyonetim]
GO
ALTER TABLE [dbo].[pru_ogrenciders]  WITH CHECK ADD  CONSTRAINT [FK_pru_ogrenciders_pru_ders] FOREIGN KEY([ogrenciders_dersid])
REFERENCES [dbo].[pru_ders] ([ders_id])
GO
ALTER TABLE [dbo].[pru_ogrenciders] CHECK CONSTRAINT [FK_pru_ogrenciders_pru_ders]
GO
ALTER TABLE [dbo].[pru_ogrenciders]  WITH CHECK ADD  CONSTRAINT [FK_pru_ogrenciders_pru_ogrenci] FOREIGN KEY([ogrenciders_ogrenciid])
REFERENCES [dbo].[pru_ogrenci] ([ogrenci_id])
GO
ALTER TABLE [dbo].[pru_ogrenciders] CHECK CONSTRAINT [FK_pru_ogrenciders_pru_ogrenci]
GO
