USE [ToKhaiYTe]
GO

/****** Object:  Table [dbo].[LichSuPhoiNhiem]    Script Date: 8/24/2020 3:11:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LichSuPhoiNhiem](
	[Id] [int] NOT NULL,
	[TiepXucDongVat] [bit] NOT NULL,
	[TiepXucGanVoiNguoiBenh] [bit] NOT NULL,
	[ToKhaiYTeId] [int] NOT NULL,
	[IsPublished] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_LichSuPhoiNhiem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[LichSuPhoiNhiem]  WITH CHECK ADD  CONSTRAINT [FK_LichSuPhoiNhiem_ToKhaiYTe_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[ToKhaiYTe] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[LichSuPhoiNhiem] CHECK CONSTRAINT [FK_LichSuPhoiNhiem_ToKhaiYTe_Id]
GO

