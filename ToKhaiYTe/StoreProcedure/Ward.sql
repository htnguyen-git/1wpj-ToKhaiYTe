USE [ToKhaiYTe]
GO

/****** Object:  Table [dbo].[Ward]    Script Date: 8/24/2020 3:12:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ward](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Type] [nvarchar](max) NULL,
	[LatiLongTude] [nvarchar](max) NULL,
	[SortOrder] [int] NOT NULL,
	[IsPublished] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[DistrictID] [int] NOT NULL,
 CONSTRAINT [PK_Ward] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Ward]  WITH CHECK ADD  CONSTRAINT [FK_Ward_District_DistrictID] FOREIGN KEY([DistrictID])
REFERENCES [dbo].[District] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Ward] CHECK CONSTRAINT [FK_Ward_District_DistrictID]
GO

