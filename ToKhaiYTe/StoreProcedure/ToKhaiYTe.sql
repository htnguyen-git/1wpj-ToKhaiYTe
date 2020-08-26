USE [ToKhaiYTe]
GO

/****** Object:  Table [dbo].[ToKhaiYTe]    Script Date: 8/24/2020 3:12:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ToKhaiYTe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GateId] [int] NOT NULL,
	[Fullname] [nvarchar](max) NOT NULL,
	[DoB] [nvarchar](max) NOT NULL,
	[Gender] [nvarchar](max) NOT NULL,
	[National] [nvarchar](max) NOT NULL,
	[CMND] [nvarchar](max) NOT NULL,
	[ListCountryhasGoneThrough] [nvarchar](max) NOT NULL,
	[CurrentAddressProvince] [nvarchar](max) NOT NULL,
	[CurrentAddressDistrict] [nvarchar](max) NOT NULL,
	[CurrentAddressWard] [nvarchar](max) NOT NULL,
	[CurrentAddressStreet] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[TravelInfomationId] [int] NOT NULL,
	[PhatologicalSignId] [int] NOT NULL,
	[UsedVaccineList] [nvarchar](max) NULL,
	[LichSuPhoiNhiemId] [int] NOT NULL,
	[IsPublished] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_ToKhaiYTe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ToKhaiYTe]  WITH CHECK ADD  CONSTRAINT [FK_ToKhaiYTe_Gate_GateId] FOREIGN KEY([GateId])
REFERENCES [dbo].[Gate] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[ToKhaiYTe] CHECK CONSTRAINT [FK_ToKhaiYTe_Gate_GateId]
GO

