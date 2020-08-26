USE [ToKhaiYTe]
GO

/****** Object:  Table [dbo].[Country]    Script Date: 8/24/2020 3:10:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Country](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountryCode] [nvarchar](max) NULL,
	[CommonName] [nvarchar](max) NOT NULL,
	[FormalName] [nvarchar](max) NULL,
	[CountryType] [nvarchar](max) NULL,
	[CountrySubType] [nvarchar](max) NULL,
	[Sovereignty] [nvarchar](max) NULL,
	[Capital] [nvarchar](max) NULL,
	[CurrencyCode] [nvarchar](max) NULL,
	[CurrencyName] [nvarchar](max) NULL,
	[TelephoneCode] [nvarchar](max) NULL,
	[CountryCode3] [nvarchar](max) NULL,
	[CountryNumber] [nvarchar](max) NULL,
	[InternetCountryCode] [nvarchar](max) NULL,
	[SortOrder] [int] NULL,
	[IsPublished] [bit] NULL,
	[Flags] [nvarchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

