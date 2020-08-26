USE [ToKhaiYTe]
GO

/****** Object:  Table [dbo].[TravelInfomation]    Script Date: 8/24/2020 3:12:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TravelInfomation](
	[Id] [int] NOT NULL,
	[TransportVerhicle] [nvarchar](max) NOT NULL,
	[TransportStationNumber] [nvarchar](max) NULL,
	[SeatNumber] [nvarchar](max) NULL,
	[DepartureDate] [nvarchar](max) NOT NULL,
	[EntryDate] [nvarchar](max) NOT NULL,
	[DepartureCountry] [nvarchar](max) NOT NULL,
	[DepartureProvince] [nvarchar](max) NOT NULL,
	[DestinyLocationCountry] [nvarchar](max) NOT NULL,
	[DestinyLocationProvince] [nvarchar](max) NOT NULL,
	[ToKhaiYTeId] [int] NOT NULL,
	[IsPublished] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_TravelInfomation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[TravelInfomation]  WITH CHECK ADD  CONSTRAINT [FK_TravelInfomation_ToKhaiYTe_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[ToKhaiYTe] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[TravelInfomation] CHECK CONSTRAINT [FK_TravelInfomation_ToKhaiYTe_Id]
GO

