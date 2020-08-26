USE [ToKhaiYTe]
GO

/****** Object:  Table [dbo].[PhatologicalSign]    Script Date: 8/24/2020 3:11:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PhatologicalSign](
	[Id] [int] NOT NULL,
	[ToKhaiYTeId] [int] NOT NULL,
	[Sot] [bit] NOT NULL,
	[Ho] [bit] NOT NULL,
	[KhoTho] [bit] NOT NULL,
	[DauHong] [bit] NOT NULL,
	[BuonNon] [bit] NOT NULL,
	[TieuChay] [bit] NOT NULL,
	[XuatHuyetNgoaiDa] [bit] NOT NULL,
	[NoiBanNgoaiDa] [bit] NOT NULL,
	[IsPublished] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_PhatologicalSign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PhatologicalSign]  WITH CHECK ADD  CONSTRAINT [FK_PhatologicalSign_ToKhaiYTe_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[ToKhaiYTe] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[PhatologicalSign] CHECK CONSTRAINT [FK_PhatologicalSign_ToKhaiYTe_Id]
GO

