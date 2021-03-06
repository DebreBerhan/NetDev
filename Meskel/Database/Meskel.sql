USE [Meskel]
GO
/****** Object:  Table [dbo].[beads]    Script Date: 6/24/2020 2:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[beads](
	[id] [tinyint] NULL,
	[color] [nchar](10) NULL,
	[size] [nchar](10) NULL,
	[image] [nchar](10) NULL,
	[Description] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Design]    Script Date: 6/24/2020 2:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Design](
	[id] [tinyint] NOT NULL,
	[name] [nchar](10) NULL,
	[material] [nchar](10) NULL,
	[image] [nchar](10) NULL,
 CONSTRAINT [PK_Design] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/24/2020 2:20:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Color] [nvarchar](max) NULL,
	[pp_image] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
