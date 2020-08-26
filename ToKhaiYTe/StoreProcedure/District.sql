USE [ToKhaiYTe]
GO

/****** Object:  Table [dbo].[District]    Script Date: 8/24/2020 3:11:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[District](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Type] [nvarchar](max) NULL,
	[LatiLongTude] [nvarchar](max) NULL,
	[SortOrder] [int] NULL,
	[IsPublished] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[ProvinceId] [int] NOT NULL,
 CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[District]  WITH CHECK ADD  CONSTRAINT [FK_District_Province_ProvinceId] FOREIGN KEY([ProvinceId])
REFERENCES [dbo].[Province] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[District] CHECK CONSTRAINT [FK_District_Province_ProvinceId]
GO

