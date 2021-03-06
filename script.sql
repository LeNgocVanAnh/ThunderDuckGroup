USE [ThunderDuck]
GO
/****** Object:  Table [dbo].[Td_AreaType]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_AreaType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Area] [int] NULL,
	[Area1] [int] NULL,
	[Area2] [int] NULL,
	[Area3] [int] NULL,
	[All] [int] NULL,
 CONSTRAINT [PK_Td_AreaType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_Contact]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_Contact](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Hotline] [nvarchar](max) NULL,
	[Headaddress] [nvarchar](300) NULL,
	[OfficeAddress] [nvarchar](300) NULL,
 CONSTRAINT [PK_Td_Contact] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_Events]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_Events](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
	[Description] [nvarchar](1000) NULL,
	[Images] [nvarchar](50) NULL,
 CONSTRAINT [PK_Td_Event] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_Images]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_Images](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[images] [nvarchar](50) NULL,
	[images1] [nvarchar](50) NULL,
	[images2] [nvarchar](50) NULL,
	[images3] [nvarchar](50) NULL,
	[images4] [nvarchar](50) NULL,
	[images5] [nvarchar](50) NULL,
	[images6] [nvarchar](50) NULL,
	[images7] [nvarchar](50) NULL,
	[images8] [nvarchar](50) NULL,
	[Title] [nvarchar](150) NULL,
 CONSTRAINT [PK_Td_Images] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_Members]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_Members](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NULL,
	[Subtitle] [nvarchar](200) NULL,
	[Description] [nvarchar](200) NULL,
	[Images] [nvarchar](50) NULL,
 CONSTRAINT [PK_Td_Member] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_News]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_News](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NULL,
	[Description] [nvarchar](1000) NULL,
	[Images] [nvarchar](50) NULL,
	[Subtitle] [nvarchar](200) NULL,
 CONSTRAINT [PK_Td_News] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_Slider]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_Slider](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Description] [nvarchar](200) NULL,
	[Video] [nvarchar](200) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[Logo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Td_Slider] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_Storys]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_Storys](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NULL,
	[Description] [nvarchar](1000) NULL,
	[Signature] [nvarchar](50) NULL,
	[Images] [nvarchar](50) NULL,
 CONSTRAINT [PK_Td_Story] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_ThunderDuckType]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_ThunderDuckType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [int] NULL,
	[Name1] [int] NULL,
	[Name2] [int] NULL,
 CONSTRAINT [PK_Td_ThunderDuckType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Td_Tours]    Script Date: 10/26/2018 11:10:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Td_Tours](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Subtitle] [nvarchar](50) NULL,
	[Description] [nvarchar](500) NULL,
	[Price] [nvarchar](50) NULL,
 CONSTRAINT [PK_Td_Tour] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Td_AreaType] ON 

INSERT [dbo].[Td_AreaType] ([id], [Area], [Area1], [Area2], [Area3], [All]) VALUES (1, 1, 2, 3, 4, 5)
SET IDENTITY_INSERT [dbo].[Td_AreaType] OFF
SET IDENTITY_INSERT [dbo].[Td_Contact] ON 

INSERT [dbo].[Td_Contact] ([id], [Email], [Phone], [Hotline], [Headaddress], [OfficeAddress]) VALUES (1, N'info@thunderduck.com.vn', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Td_Contact] OFF
SET IDENTITY_INSERT [dbo].[Td_Events] ON 

INSERT [dbo].[Td_Events] ([id], [Title], [Price], [Description], [Images]) VALUES (1, N'Event', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Td_Events] OFF
SET IDENTITY_INSERT [dbo].[Td_Images] ON 

INSERT [dbo].[Td_Images] ([id], [images], [images1], [images2], [images3], [images4], [images5], [images6], [images7], [images8], [Title]) VALUES (1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'Hình ảnh')
SET IDENTITY_INSERT [dbo].[Td_Images] OFF
SET IDENTITY_INSERT [dbo].[Td_Members] ON 

INSERT [dbo].[Td_Members] ([id], [Title], [Subtitle], [Description], [Images]) VALUES (1, N'Thành viên', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Td_Members] OFF
SET IDENTITY_INSERT [dbo].[Td_News] ON 

INSERT [dbo].[Td_News] ([id], [Title], [Description], [Images], [Subtitle]) VALUES (1, N'Tin tức', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Td_News] OFF
SET IDENTITY_INSERT [dbo].[Td_Slider] ON 

INSERT [dbo].[Td_Slider] ([id], [Title], [Description], [Video], [Email], [Phone], [Logo]) VALUES (1, N'Chào mừng đến với Thunder Duck', NULL, N'https://www.youtube.com/watch?v=P_q3BdrFsLI', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Td_Slider] OFF
SET IDENTITY_INSERT [dbo].[Td_Storys] ON 

INSERT [dbo].[Td_Storys] ([id], [Title], [Description], [Signature], [Images]) VALUES (1, N'Câu chuyện của chúng tôi', N'Hai con người cùng chung chí hướng và đam mê, một người xây nhà, một người tô điểm thêm cho ngôi nhà', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Td_Storys] OFF
SET IDENTITY_INSERT [dbo].[Td_ThunderDuckType] ON 

INSERT [dbo].[Td_ThunderDuckType] ([id], [Name], [Name1], [Name2]) VALUES (1, 1, 2, 3)
SET IDENTITY_INSERT [dbo].[Td_ThunderDuckType] OFF
SET IDENTITY_INSERT [dbo].[Td_Tours] ON 

INSERT [dbo].[Td_Tours] ([id], [Title], [Subtitle], [Description], [Price]) VALUES (1, N'Bùng nổ Tour', N'Trung Quốc - Hàn Quốc', N'Thưởng lãm những thắng cành nổi tiếng tại 2 quốc gia: Trung Quốc - Hàn Quốc', N'10.000.000/1 người')
SET IDENTITY_INSERT [dbo].[Td_Tours] OFF
