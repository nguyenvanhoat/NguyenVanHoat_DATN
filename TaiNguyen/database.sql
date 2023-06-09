Create database  [HoatIdentityDb]
go
USE [HoatIdentityDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUser]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUser](
	[Id] [nvarchar](450) NOT NULL,
	[CreateAt] [date] NOT NULL,
	[UpdateAt] [date] NULL,
	[DeleteAt] [date] NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AppUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaoHanh]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoHanh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NgayMua] [datetime2](7) NOT NULL,
	[SoMay] [nvarchar](max) NOT NULL,
	[SoDienThoai] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BaoHanh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[Color] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietBaoHanh]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBaoHanh](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [datetime2](7) NOT NULL,
	[ChiTiet] [nvarchar](max) NOT NULL,
	[BaoHanhId] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietBaoHanh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhieuNhapId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [decimal](18, 2) NOT NULL,
	[DVT] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatLich]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatLich](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiDat] [nvarchar](max) NOT NULL,
	[SoDienThoai] [nvarchar](max) NOT NULL,
	[ProductId] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NOT NULL,
	[NgayHen] [datetime2](7) NOT NULL,
	[TrangThai] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DatLich] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaXe]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaXe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MauXe] [nvarchar](max) NOT NULL,
	[Gia] [decimal](18, 2) NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_GiaXe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medias]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Medias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Color] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC,
	[Color] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[UserId] [nvarchar](450) NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[Reason] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[BenGiao] [nvarchar](150) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NgayGiao] [datetime] NOT NULL,
	[NguoiNhan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/28/2023 1:57:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Slug] [nvarchar](256) NOT NULL,
	[ProductDetails] [ntext] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Trending] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
	[Views] [int] NOT NULL,
	[Thumbnail] [nvarchar](max) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NULL,
	[DeleteAt] [datetime2](7) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 5/28/2023 1:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[UserId] [nvarchar](450) NOT NULL,
	[ProductId] [int] NOT NULL,
	[Viewd] [bit] NOT NULL,
	[IsWishList] [bit] NOT NULL,
	[ReviewsDetails] [ntext] NULL,
	[DateView] [datetime2](7) NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NULL,
	[DeleteAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 5/28/2023 1:57:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ShopName] [nvarchar](100) NOT NULL,
	[Slug] [nvarchar](256) NOT NULL,
	[Trending] [bit] NOT NULL,
	[CreateAt] [datetime2](7) NOT NULL,
	[UpdateAt] [datetime2](7) NULL,
	[DeleteAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230402020415_init', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230402023609_fix', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230402143447_iag', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230416033938_fix_dat_lich', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230416034251_fix_dat_hang_2', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230422030136_add_giaXe', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230429122525_haha', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230429131647_seeding_data', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230430064109_fix_primarykey', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230430064220_fix_haha', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230502030419_add_ii', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230502031817_hehi', N'6.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230503014024_add_someone', N'6.0.12')
GO
INSERT [dbo].[AppUser] ([Id], [CreateAt], [UpdateAt], [DeleteAt], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'15d3c789-ab99-45fc-ab24-10c998531df9', CAST(N'2023-05-13' AS Date), NULL, NULL, N'toan', N'TOAN', N'toan@gmail.com', N'TOAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEQmZ52E+RFadTnf9Gz8ycK4DFJUmxFa2IgekZ/c5W8twigOkhsmgrChUMZH6+WR0w==', N'32B4E373GLDHFDO54VPVRIKNCTDM3DF7', N'88e7fbd4-4a10-45b1-bc5a-1c9e505870ca', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AppUser] ([Id], [CreateAt], [UpdateAt], [DeleteAt], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4da82fce-957c-449f-881f-97d4ebe172af', CAST(N'2023-05-03' AS Date), NULL, NULL, N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMfkjUuiOGCj4je7Jury+TwHgNdXv4nBC8Kjyu6CuOgXf3UVIJDsRslqOQIGcXbd/A==', N'NQ6AZXLJ7PGSJQQ6M2SEBFAPJ7YLXA6N', N'd1e82e18-3a79-4649-aebb-730285714c82', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AppUser] ([Id], [CreateAt], [UpdateAt], [DeleteAt], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'adb88806-f7fa-48aa-95e4-7a493844f9e6', CAST(N'2023-05-13' AS Date), NULL, NULL, N'hieu', N'HIEU', N'hieu2001@gmail.com', N'HIEU2001@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAECIWuY9RmpkUSyaC899a2maQ2PGyb7brDVwpkSja8Pe2rws+rg3nmDCSSc+D3rkPuQ==', N'6JDCO4RZ3XVSHJY4BS3ZWDCNHFZJTAGB', N'f52fee95-3b67-43e0-976c-315174a33c40', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AppUser] ([Id], [CreateAt], [UpdateAt], [DeleteAt], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', CAST(N'2023-04-29' AS Date), NULL, NULL, N'hoat', N'HOAT', N'hoat@gmail.com', N'HOAT@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELsihrEq7g+O95BAr70NZG85Ry1Zgc21cwPQspxjvng7j8i2ClgEqyTrEjlKmBWimA==', N'TT55EL43OIS6KK3BVII3JEB4O53HL7PJ', N'0794ed61-16db-4840-902f-4b4388bd2682', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AppUser] ([Id], [CreateAt], [UpdateAt], [DeleteAt], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c8bdec4a-bc26-403d-a3bf-901c9371d04e', CAST(N'2023-05-03' AS Date), NULL, NULL, N'saler', N'SALER', N'saler@gmail.com', N'SALER@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAQW4n8Pg28/A/wU7TDNQzM6TbeGhsYEMUKs2WWyClPlOY/HHZTDp2ReDdumjLoO/w==', N'ZHHR6JH5OYTETTQO4YJFJOP3OI4KVTHE', N'd13df53b-fba9-4220-a93f-64a05a074113', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'35c92cf8-0beb-4ae0-9d36-9dbd069cdd86', N'Saler', N'SALER', N'cc71fd2d-1891-467d-90fc-64a47f844ac5')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b03ba7c7-a4ab-41ef-9285-13f0dc6a3e57', N'Admin', N'ADMIN', N'5435aefe-d812-41c8-af29-3181bfa4494d')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c853efd4-4cc8-4ffa-b87a-60d2733ee39e', N'User', N'USER', N'93534cfc-f301-46d6-bb57-6f71832aee75')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c8bdec4a-bc26-403d-a3bf-901c9371d04e', N'35c92cf8-0beb-4ae0-9d36-9dbd069cdd86')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4da82fce-957c-449f-881f-97d4ebe172af', N'b03ba7c7-a4ab-41ef-9285-13f0dc6a3e57')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'15d3c789-ab99-45fc-ab24-10c998531df9', N'c853efd4-4cc8-4ffa-b87a-60d2733ee39e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'adb88806-f7fa-48aa-95e4-7a493844f9e6', N'c853efd4-4cc8-4ffa-b87a-60d2733ee39e')
GO
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhap] ON 

INSERT [dbo].[ChiTietPhieuNhap] ([ID], [PhieuNhapId], [ProductId], [SoLuong], [DonGia], [DVT]) VALUES (2, 2, 9, 23, CAST(19000000.00 AS Decimal(18, 2)), N'Chiếc')
INSERT [dbo].[ChiTietPhieuNhap] ([ID], [PhieuNhapId], [ProductId], [SoLuong], [DonGia], [DVT]) VALUES (3, 3, 10, 2, CAST(98000000.00 AS Decimal(18, 2)), N'Chiếc')
INSERT [dbo].[ChiTietPhieuNhap] ([ID], [PhieuNhapId], [ProductId], [SoLuong], [DonGia], [DVT]) VALUES (4, 4, 15, 2, CAST(33000000.00 AS Decimal(18, 2)), N'Chiếc')
INSERT [dbo].[ChiTietPhieuNhap] ([ID], [PhieuNhapId], [ProductId], [SoLuong], [DonGia], [DVT]) VALUES (5, 5, 15, 12, CAST(34000000.00 AS Decimal(18, 2)), N'Chiếc')
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[DatLich] ON 

INSERT [dbo].[DatLich] ([Id], [TenNguoiDat], [SoDienThoai], [ProductId], [GhiChu], [NgayHen], [TrangThai]) VALUES (8, N'Nguyễn Văn Hoạt', N'0337981244', 9, N'', CAST(N'2023-05-11T00:00:00.0000000' AS DateTime2), N'1')
INSERT [dbo].[DatLich] ([Id], [TenNguoiDat], [SoDienThoai], [ProductId], [GhiChu], [NgayHen], [TrangThai]) VALUES (9, N'Nguyễn Văn Toàn', N'0337981244', 11, N'', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'0')
SET IDENTITY_INSERT [dbo].[DatLich] OFF
GO
SET IDENTITY_INSERT [dbo].[GiaXe] ON 

INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (31, N'Xanh', CAST(19500000.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (32, N'Đỏ', CAST(18500000.00 AS Decimal(18, 2)), 9)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (33, N'Đỏ', CAST(99000000.00 AS Decimal(18, 2)), 10)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (34, N'Đen', CAST(98000000.00 AS Decimal(18, 2)), 10)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (35, N'Đen', CAST(599490000.00 AS Decimal(18, 2)), 11)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (36, N'Đỏ', CAST(598490000.00 AS Decimal(18, 2)), 11)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (37, N'Đen', CAST(69990000.00 AS Decimal(18, 2)), 12)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (38, N'Xám', CAST(68990000.00 AS Decimal(18, 2)), 12)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (39, N'Trắng', CAST(50990000.00 AS Decimal(18, 2)), 13)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (40, N'Xám', CAST(49990000.00 AS Decimal(18, 2)), 13)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (41, N'Đen', CAST(70590000.00 AS Decimal(18, 2)), 14)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (42, N'Xanh', CAST(69590000.00 AS Decimal(18, 2)), 14)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (43, N'Đỏ', CAST(49590000.00 AS Decimal(18, 2)), 15)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (44, N'Đen', CAST(48590000.00 AS Decimal(18, 2)), 15)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (45, N'Trắng', CAST(55590000.00 AS Decimal(18, 2)), 16)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (46, N'Đen', CAST(54590000.00 AS Decimal(18, 2)), 16)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (47, N'Cam', CAST(23590000.00 AS Decimal(18, 2)), 17)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (48, N'Xám', CAST(22590000.00 AS Decimal(18, 2)), 17)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (49, N'Xanh', CAST(74590000.00 AS Decimal(18, 2)), 18)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (50, N'Đen', CAST(76590000.00 AS Decimal(18, 2)), 18)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (51, N'Đen đỏ', CAST(52590000.00 AS Decimal(18, 2)), 19)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (52, N'Xanh đen', CAST(52590000.00 AS Decimal(18, 2)), 19)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (53, N'Xanh', CAST(26590000.00 AS Decimal(18, 2)), 20)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (54, N'Trắng', CAST(33690000.00 AS Decimal(18, 2)), 21)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (55, N'Đen đỏ', CAST(34690000.00 AS Decimal(18, 2)), 21)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (56, N'Đen', CAST(24690000.00 AS Decimal(18, 2)), 22)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (57, N'Xám đen', CAST(24290000.00 AS Decimal(18, 2)), 22)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (58, N'Đỏ đen', CAST(23990000.00 AS Decimal(18, 2)), 23)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (59, N'Trắng đen', CAST(23590000.00 AS Decimal(18, 2)), 23)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (60, N'Trắng', CAST(35590000.00 AS Decimal(18, 2)), 24)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (61, N'Xanh', CAST(34590000.00 AS Decimal(18, 2)), 24)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (62, N'Đen', CAST(28290000.00 AS Decimal(18, 2)), 25)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (63, N'Trắng', CAST(28290000.00 AS Decimal(18, 2)), 25)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (64, N'Đỏ nhám', CAST(49990000.00 AS Decimal(18, 2)), 26)
INSERT [dbo].[GiaXe] ([Id], [MauXe], [Gia], [ProductId]) VALUES (65, N'Xanh', CAST(49990000.00 AS Decimal(18, 2)), 26)
SET IDENTITY_INSERT [dbo].[GiaXe] OFF
GO
SET IDENTITY_INSERT [dbo].[Medias] ON 

INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (7, N'yrf5ukyr.png', 9)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (8, N'qqwketq1.png', 10)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (9, N'ptxkc4f0.png', 10)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (10, N'nc2wbgad.png', 10)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (11, N'hiqah3hn.png', 11)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (12, N'jawukahm.png', 12)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (13, N'52q3x01a.png', 13)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (14, N'co0ulpwq.png', 14)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (15, N'ihya0rdt.png', 15)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (16, N'uyfci55n.png', 16)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (17, N'lvzusgfg.png', 17)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (18, N'wedufdq2.png', 18)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (19, N'p4jqy032.png', 19)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (20, N'2vovzqph.png', 20)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (21, N'c5bmpehx.png', 21)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (22, N'bdju0hp0.png', 22)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (23, N'ytjy3uis.png', 23)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (24, N'gb52ewp0.png', 24)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (25, N'tveyzx2v.png', 25)
INSERT [dbo].[Medias] ([Id], [Name], [ProductId]) VALUES (26, N'ne5fszs0.png', 26)
SET IDENTITY_INSERT [dbo].[Medias] OFF
GO
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (10, 9, 1, CAST(19500000.00 AS Decimal(18, 2)), N'Xanh')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (11, 9, 1, CAST(18500000.00 AS Decimal(18, 2)), N'Đỏ')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (12, 9, 1, CAST(18500000.00 AS Decimal(18, 2)), N'Đỏ')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (13, 9, 1, CAST(18500000.00 AS Decimal(18, 2)), N'Đỏ')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (14, 10, 1, CAST(99000000.00 AS Decimal(18, 2)), N'Đỏ')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (15, 9, 1, CAST(19500000.00 AS Decimal(18, 2)), N'Xanh')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (17, 10, 1, CAST(98000000.00 AS Decimal(18, 2)), N'Đen')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (17, 10, 1, CAST(99000000.00 AS Decimal(18, 2)), N'Đỏ')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (18, 11, 1, CAST(599490000.00 AS Decimal(18, 2)), N'Đen')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (19, 9, 1, CAST(18500000.00 AS Decimal(18, 2)), N'Đỏ')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (20, 10, 1, CAST(98000000.00 AS Decimal(18, 2)), N'Đen')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (20, 11, 1, CAST(599490000.00 AS Decimal(18, 2)), N'Đen')
INSERT [dbo].[OrderDetails] ([OrderId], [ProductId], [Quantity], [Price], [Color]) VALUES (22, 9, 1, CAST(18500000.00 AS Decimal(18, 2)), N'Đỏ')
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (1, CAST(N'2023-04-29' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'12', N'12', N'0337981244', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (2, CAST(N'2023-04-29' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'sfg', N'àg', N'0337981255', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (3, CAST(N'2023-04-29' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Nanm định', N'12', N'0337981244', N'offline', NULL, N'Huy')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (4, CAST(N'2023-04-29' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Nanm định', N'qư', N'0337981244', N'offline', NULL, N'Huy')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (5, CAST(N'2023-04-30' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Hải Hậu Nam Định', N'Nguyễn Văn Toàn', N'0976853182', N'offline', NULL, N'Huy')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (6, CAST(N'2023-04-30' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Nam định', N'Toàn', N'0976853182', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (7, CAST(N'2023-04-30' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Hoat', N'nguyễn Văn hoạt', N'0337981244', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (9, CAST(N'2023-04-30' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'12', N'12', N'0337981244', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (10, CAST(N'2023-05-06' AS Date), N'c8bdec4a-bc26-403d-a3bf-901c9371d04e', N'àg', N'Nguyễn Văn hoat', N'0337981244', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (11, CAST(N'2023-05-07' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Hải Hậu', N'Nguyễn Văn hoat', N'0335566873', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (12, CAST(N'2023-05-07' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Hải Hậu', N'Nguyễn Văn hoat', N'0335566873', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (13, CAST(N'2023-05-07' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Hải Hậu', N'Nguyễn Văn hoat', N'0335566873', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (14, CAST(N'2023-05-08' AS Date), N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', N'Hải Hậu', N'Nguyễn Văn hoat', N'0337981244', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (15, CAST(N'2023-05-12' AS Date), N'4da82fce-957c-449f-881f-97d4ebe172af', N'Hải Hậu', N'Nguyễn Văn hoat', N'0337981244', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (16, CAST(N'2023-05-12' AS Date), N'4da82fce-957c-449f-881f-97d4ebe172af', N'Hải Hậu', N'Nguyễn Văn hoat', N'0337981244', N'offline', NULL, N'Huy')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (17, CAST(N'2023-05-13' AS Date), N'15d3c789-ab99-45fc-ab24-10c998531df9', N'Nam định', N'Nguyễn Văn Toàn', N'0337981244', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (18, CAST(N'2023-05-13' AS Date), N'15d3c789-ab99-45fc-ab24-10c998531df9', N'Nam định', N'Nguyễn Văn Toàn', N'0337981244', N'offline', NULL, N'NEW')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (19, CAST(N'2023-05-13' AS Date), N'adb88806-f7fa-48aa-95e4-7a493844f9e6', N'Hải Hậu - Nam Định', N'Trần Huy Hiệu', N'0333561008', N'offline', NULL, N'Huy')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (20, CAST(N'2023-05-13' AS Date), N'adb88806-f7fa-48aa-95e4-7a493844f9e6', N'Hải Phú - Nam Định', N'Hiệu', N'0333561008', N'offline', NULL, N'Đã xử lý')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (21, CAST(N'2023-05-13' AS Date), N'adb88806-f7fa-48aa-95e4-7a493844f9e6', N'Hải Phú - Nam Định', N'Hiệu', N'0333561008', N'offline', NULL, N'NEW')
INSERT [dbo].[Orders] ([Id], [OrderDate], [UserId], [Address], [Name], [PhoneNumber], [Type], [Reason], [Status]) VALUES (22, CAST(N'2023-05-14' AS Date), N'15d3c789-ab99-45fc-ab24-10c998531df9', N'Hà Nội', N'Nguyễn Văn Toàn', N'0337981244', N'offline', NULL, N'Đã xử lý')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([MaPhieu], [BenGiao], [DiaChi], [NgayGiao], [NguoiNhan]) VALUES (1, N'Honda', N'Hà Nội', CAST(N'2023-04-16T10:58:43.200' AS DateTime), N'Hoạt')
INSERT [dbo].[PhieuNhap] ([MaPhieu], [BenGiao], [DiaChi], [NgayGiao], [NguoiNhan]) VALUES (2, N'HonDa', N'Hà Nội', CAST(N'2023-05-06T15:16:28.683' AS DateTime), N'Nguyễn Văn Hoạt')
INSERT [dbo].[PhieuNhap] ([MaPhieu], [BenGiao], [DiaChi], [NgayGiao], [NguoiNhan]) VALUES (3, N'HonDa Trường Tín', N'Hà Nội', CAST(N'2023-05-06T15:17:33.187' AS DateTime), N'Nguyễn Toàn')
INSERT [dbo].[PhieuNhap] ([MaPhieu], [BenGiao], [DiaChi], [NgayGiao], [NguoiNhan]) VALUES (4, N'Yamaha', N'Hà Nam', CAST(N'2023-05-06T15:18:19.380' AS DateTime), N'Trần Huy Hiệu')
INSERT [dbo].[PhieuNhap] ([MaPhieu], [BenGiao], [DiaChi], [NgayGiao], [NguoiNhan]) VALUES (5, N'Yamaha', N'Hà Nội', CAST(N'2023-05-13T15:10:27.307' AS DateTime), N'Nguyễn Văn Hoạt')
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (9, N'Wave Alpha', N'wave-alpha', N'<h4><strong>Độ cao yên:</strong>&nbsp;&nbsp;&nbsp; 799mm</h4><h4><strong>Khoảng cách trục bánh xe:</strong>&nbsp;&nbsp;&nbsp; 1353mm</h4><h4><strong>Độ cao gầm xe&nbsp;:</strong>&nbsp;&nbsp; 146mm</h4><h4><strong>Trọng lượng&nbsp;:</strong>&nbsp;&nbsp; 134kg</h4><h4><strong>Kích thước:&nbsp;</strong>&nbsp;&nbsp; 2090 x 739 x 1129mm</h4><h4><strong>Dung tích cốp:</strong>&nbsp;&nbsp;&nbsp; 28L</h4><h4><strong>Số chỗ ngồi:</strong>&nbsp;&nbsp;&nbsp;&nbsp;2<br><strong>Màu sắc:</strong>&nbsp;&nbsp;&nbsp; Đen, Đen Bạc, Đỏ, Trắng, Xám đen</h4><h4><strong>Năm ra mắt:</strong>&nbsp;&nbsp;&nbsp;&nbsp;2021<br><strong>Xuất xứ thương hiệu:</strong>&nbsp;&nbsp;&nbsp;&nbsp;Nhật Bản</h4><p>&nbsp;</p><h2>Top những câu hỏi thường gặp về xe Wave Alpha 110</h2><p>Dù trên&nbsp;thị trường hiện có khá nhiều các dòng xe máy với những trang bị hiện đại cùng&nbsp;thiết kế tiện dụng. Thế nhưng Wave Alpha vẫn là lựa chọn được sự ưa chuộng từ đông đảo người dùng nhờ mức giá rẻ cùng sự nhỏ gọn, linh hoạt. Nếu đang có ý định sở hữu mẫu xe này, đừng quên theo dõi những câu hỏi thường gặp về&nbsp;Honda Wave Alpha 110 được tổng hợp trong bài viết.</p><figure class="image"><img src="https://images.autofun.vn/file1/fc9aa3d9b43a4eaab54de38ee19a4d09_1200.jpg" alt="Top những câu hỏi thường gặp về xe Wave Alpha 110 01"><figcaption>Honda Wave Alpha mới nhất.</figcaption></figure><p>Honda Việt Nam chính thức giới thiệu đến khách hàng&nbsp;phiên bản Wave Alpha 2022&nbsp;với&nbsp;động cơ hoàn toàn mới 110cc cùng&nbsp;nhiều nâng cấp&nbsp;vượt trội về cả thiết kế, động cơ và tiện ích. Với&nbsp;những tinh chỉnh&nbsp;trong động cơ, công nghệ và&nbsp;thiết kế, đặc biệt là trong cách&nbsp;lắp đặt ống xả, mẫu xe số Honda tự tin&nbsp;đáp ứng tiêu chuẩn khí thải EURO 3 ra môi trường.</p><p>Phiên bản giới hạn mới Wave Alpha 110cc 2022 mang nhiều hi&nbsp;vọng nối tiếp sự thành công của dòng xe Wave huyền thoại.&nbsp;Từ lúc ra&nbsp;đời đến nay, giá xe Wave Alpha không có nhiều biến động như các mẫu xe khác cùng thương hiệu như <a href="https://www.autofun.vn/xe-may/honda/air-blade"><strong>Honda Air Blade</strong></a>&nbsp;hay Honda Lead.</p><h2>Honda Wave Alpha 2022 có những điểm mới nào?</h2><p>Về cơ bản, Honda Wave Alpha 2022 vẫn giữ nguyên thiết kế và trang thiết&nbsp;bị so với phiên bản cũ. Điểm mới dễ nhận thấy nhất&nbsp;trên xe Honda Wave Alpha 2022 là&nbsp;tùy chọn màu sắc và có thêm tem xe đa dạng hơn. Còn khi nhìn tổng thể cũng như trang bị của xe thì không có gì quá khác biệt.</p><figure class="image"><img src="https://images.autofun.vn/file1/2b72d4498e2f4b68a7f473a8e335273d_1200.png" alt="Top những câu hỏi thường gặp về xe Wave Alpha 110 01"><figcaption>Honda Wave Alpha nhiều phiên bản màu sắc, khác nhau.</figcaption></figure><p>Hiện tại, <a href="https://www.autofun.vn/xe-may/honda/wave-alpha-110"><strong>Honda Wave Alpha 110</strong></a> chỉ có một đối thủ duy nhất cạnh tranh&nbsp;trên thị trường là Yamaha Sirius. Tuy nhiên, Honda Wave Alpha có vẻ được lòng&nbsp;người dùng Việt Nam hơn&nbsp;khi liên tục đạt được doanh kỉ lục khi bán ra thị trường.</p><h2>Ưu điểm,&nbsp;nhược&nbsp;xe máy Honda Wave Alpha 110 là gì?</h2><h3>Ưu điểm&nbsp;</h3><ul><li>Giá xe Honda Wave Alpha được bán ra luôn phải chăng, tạo điều kiện cho&nbsp;khách hàng&nbsp;phổ thông dễ dàng sở hữu và&nbsp;tiếp cận.</li><li>Với trang bị động cơ 110 cc, Honda Wave Alpha rất êm ái&nbsp;và linh hoạt khi vận hành trên đường phố. Cũng vì trang bị động cơ dung tích xylanh nhỏ nên Honda Wave Alpha có khả năng tiết kiệm nhiên liệu một cách tối đa.</li></ul><h3>Nhược điểm</h3><ul><li>Giá xe rẻ trong phân khúc bình dân nên&nbsp;Honda Wave không hề có tiện ích nào đáng chú ý, các trang thiết&nbsp;bị trên xe rất cơ bản.</li><li>Mặc dù đã trải qua nhiều năm có mặt trên thị trường nhưng Honda Wave Alpha gần&nbsp;như không có thay đổi nào đáng kể về thiết kế, xe vẫn giữ nguyên ngoại hình đặc trưng của dòng xe số " quốc dân" giá rẻ từ nhiều năm nay.</li></ul><h2>Wave Alpha có dung tích bình xăng bao nhiêu lít? Xe tốn&nbsp;không?</h2><p>Theo công bố từ nhà sản xuất, bình xăng của xe Wave Alpha 110 hiện có dung tích khoảng&nbsp;&nbsp;3,7l. Trung bình xe tiêu thụ khoảng 1,5 - 1,6 lít/100km di chuyển. Đây được xem là dòng xe máy có khả năng tiết kiệm nhiên liệu tốt trên thị trường hiện nay.</p><h2>Wave Alpha 110 nặng bao nhiêu kg?</h2><p>Honda Wave Alpha 110 có trọng lượng khoảng 97kg, kích thước phù hợp với đại đa số vóc dáng người Việt Nam. Kích thước tổng thể&nbsp;Dài x Rộng x Cao của xe lần lượt là&nbsp;1.914mm x 688mm x 1.075mm.</p><h2>Giá xe Honda Wave Alpha 110 ra sao?</h2><p>Bên cạnh đó, giá xe cho 2 phiên bản gồm bản giới hạn và tiêu chuẩn lần lượt là&nbsp;18.390.000VNĐ và&nbsp;17.890.000VNĐ.&nbsp;&nbsp;Hiện mẫu xe này cũng cung cấp đa dạng màu sắc gồm:&nbsp;Màu Xanh ngọc / Màu Xanh lam đậm / Màu đen / Màu Đỏ / Màu Trắng / Màu Xanh da trời.</p><p>Giá xe lăn bánh xe máy còn tùy thuộc vào thuế của từng tỉnh thành. Trong đó,&nbsp;giá lăn bánh Wave Alpha 110&nbsp;dao động từ khoảng 21.150.000 VNĐ&nbsp;- 21.850.000 VNĐ tuỳ tỉnh thành.</p><figure class="image"><img src="https://images.autofun.vn/file1/22f78249d6554c85827969630451d731_1200.png" alt="Top những câu hỏi thường gặp về xe Wave Alpha 110 02"><figcaption>Honda Wave Alpha 110cc thực tế.&nbsp;</figcaption></figure><h2>Những tiện ích nổi bật của xe Honda Wave Alpha gồm những gì?&nbsp;</h2><p>Tối ưu hóa tiện ích được xem là một trong những yếu tố được quan tâm hàng đầu của <a href="https://www.autofun.vn/xe-may/honda"><strong>Honda</strong></a> khi phát triển dòng xe này. Nhờ vậy mà&nbsp;khách hàng luôn&nbsp;thoải mái lướt cùng Honda Wave Alpha 110 trên mọi nẻo đường.</p><ul><li>Ổ khóa đa năng 3 trong 1</li></ul><p>Ổ khóa xe Wave Alpha 2022 bao gồm:&nbsp; Khóa điện, khóa cổ và khóa từ, dễ dàng sử dụng và chống rỉ sét hiệu quả.</p><ul><li>&nbsp;Khoảng cách gương chiếu hậu hai bên đuọce bố trí&nbsp;hợp lý</li></ul><p>Hai gương chiếu hậu của xe&nbsp;được bố trí hợp lý với chiều rộng tay lái theo khoảng cách tương ứng, giúp việc điều khiển xe và quan sát phía sau trở nên thuận tiện&nbsp;hơn.</p><ul><li>Cốp xe rộng rãi</li></ul><p>Wave Alpha 110 phiên bản mới 2022 được trang bị cốp xe rộng tương ứng khoảng&nbsp;5 lít, để vừa áo mưa, găng tay hoặc các vật dụng cá nhân khác.</p><h2>Công suất xe Wave Alpha so với phiên bản trước đó như thế nào ?&nbsp;</h2><p>Công suất xe Alpha 110 phiên bản mới được khách hàng đánh giá là mạnh mẽ hơn. Điều là là nhờ được sử dụng hàng loạt cải tiến giúp&nbsp;giảm thiểu ma sát và tối ưu hoạt động của&nbsp;buồng đốt.</p><p>Bên cạnh đó,&nbsp;trọng lượng nhẹ hơn 1kg cùng công suất và mô-men xoắn vượt trội, tương đương&nbsp;với hơn 17% và 20% so với phiên bản trước (100cc),...cũng góp phần giúp Honda Wave Alpha 110 2022 mang lại khả năng tăng tốc vượt trội&nbsp;và vận hành êm ái hơn trên mọi địa hình di chuyển.</p><figure class="image"><img src="https://images.autofun.vn/file1/c8905b8f4ede465585d99042df439f26_1200.png" alt="Top những câu hỏi thường gặp về xe Wave Alpha 110 03"><figcaption>Công suất động cơ xe Wave Alpha 110 2022 được cải thiện đáng kể.&nbsp;</figcaption></figure><p>Nhìn chung, Honda Wave Alpha 2022 đã có những sự nâng cấp mạnh mẽ về mặt ngoại hình với thiết kế mới thay vì chỉ thay đổi tem xe như trước. Bên cạnh đó, Honda đã bổ sung nhiều phiên bản mới khác nhau nhằm tạo nên sự mới mẻ, hấp dẫn cho dòng xe số " quốc dân" được nhiều người yêu mến này .</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 27, N'otryilfc.png', CAST(N'2023-05-03T09:03:16.0000000' AS DateTime2), CAST(N'2023-05-13T20:56:06.2124573' AS DateTime2), NULL, 4)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (10, N'Sh150i 2022 ABS ', N'sh150i-2022-abs', N'<h4><strong>Độ cao yên:</strong>&nbsp;&nbsp;&nbsp; 799mm</h4><h4><strong>Khoảng cách trục bánh xe:</strong>&nbsp;&nbsp;&nbsp; 1353mm</h4><h4><strong>Độ cao gầm xe&nbsp;:</strong>&nbsp;&nbsp; 146mm</h4><h4><strong>Trọng lượng&nbsp;:</strong>&nbsp;&nbsp; 134kg</h4><h4><strong>Kích thước:&nbsp;</strong>&nbsp;&nbsp; 2090 x 739 x 1129mm</h4><h4><strong>Dung tích cốp:</strong>&nbsp;&nbsp;&nbsp; 28L</h4><h4><strong>Số chỗ ngồi:</strong>&nbsp;&nbsp;&nbsp;&nbsp;2<br><strong>Màu sắc:</strong>&nbsp;&nbsp;&nbsp; Đen, Đen Bạc, Đỏ, Trắng, Xám đen</h4><h4><strong>Năm ra mắt:</strong>&nbsp;&nbsp;&nbsp;&nbsp;2021<br><strong>Xuất xứ thương hiệu:</strong>&nbsp;&nbsp;&nbsp;&nbsp;Nhật Bản</h4><h4><i><strong>Kế thừa tinh hoa của dòng xe SH với những đường nét thanh lịch, sang trọng mang hơi thở Châu Âu cùng động cơ cải tiến đột phá và công nghệ tiên tiến, xe Honda SH 150i ABS 2021 mới bổ sung màu mới ấn tượng và nổi bật.</strong></i></h4><h2><strong>Vẻ đẹp của “ông hoàng xe ga” không lỗi thời</strong></h2><p>SH có phần trau chuốt, tinh tế hơn qua các chi tiết, góc cạnh so với có dòng xe tay ga khác. Còn về động cơ thì SH sở hữu động cơ mạnh mẽ; vận hành êm ái; bền bỉ lâu dài. Và khi so sánh với nhiều dòng tay ga khác thì SH vẫn khẳng định được vị thế của mình trong khoảng thời gian dài. Vẻ đẹp của “ông hoàng xe ga” vẫn bắt kịp với xu hướng hiện đại. Vì thế, đây cũng là một số những lý do mà SH được ưa chuộng như hiện nay.</p><figure class="image"><img src="https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-sh-y-cu-3.jpg" alt="Honda SH không lỗi thời" srcset="https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-sh-y-cu-3.jpg 1024w, https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-sh-y-cu-3-300x225.jpg 300w, https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-sh-y-cu-3-768x576.jpg 768w, https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-sh-y-cu-3-600x450.jpg 600w" sizes="100vw" width="1024"></figure><p>Điệp khúc xe giữ giá, không lỗi mốt lâu nay người Việt vẫn gắn cho các mẫu xe Nhật kể cả ô tô hay xe máy. Đó là một phần nguyên nhân khiến những chiếc xe của Honda dù có ngoại hình không mấy nổi bật nhưng được nhiều người ưa chuộng. Những xe Honda sau 10 năm, 20 năm vẫn có giá trị. Đơn cử các dòng xe như Wave hay Dream; Cub hiện nay còn được nhiều người sưu tầm với giá đắt đỏ. Honda SH cũng không ngoại lệ.</p><h2><strong>Trào lưu thể hiện đẳng cấp</strong></h2><p>Lần đầu ra mắt vào năm 2002, trải qua 17 năm có mặt tại Việt Nam, Honda SH nhanh chóng tạo ra vị thế có một không hai của mình trong lòng khách hàng. Cho đến nay thì mẫu xe này vẫn không có đối thủ trong cùng phân khúc khi mà Vespa, Piaggio Medley… chẳng thể nào cạnh tranh nổi.</p><figure class="image"><img src="https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-2-1567248903.jpg" alt="SH trào lưu thể hiện đẳng cấp" srcset="https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-2-1567248903.jpg 952w, https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-2-1567248903-300x158.jpg 300w, https://qkl.vn/wp-content/uploads/2021/03/nhung-ly-do-tai-sao-honda-sh-qua-dat-nhung-van-duoc-nhieu-nguoi-lua-chon-2-1567248903-768x403.jpg 768w" sizes="100vw" width="952"></figure><h3><strong>Xe hạng sang của dân Việt</strong></h3><p>Điều gì làm nên sự khác biệt đó? Đầu tiên phải nói đến đó là nhận thức về một chiếc xe máy hạng sang của dân Việt. SH trong ý nghĩ của họ đó là chiếc xe máy thể hiện sự thành công và đẳng cấp. Nó có thể nâng tầm của chủ nhân lên rất nhiều so với các xe khác.</p><p>Vì vậy mà rất dễ bắt gặp những “hội” SH tập kết giao lưu với các tay lái trẻ. Hay những cặp đôi vi vu quanh hồ Hoàn Kiếm trên những chiếc SH mới cóng. Cho đến những bậc trung niên đèo vợ con đi chơi cuối tuần. Ai sở hữu SH chứng tỏ người đó không phải dân chơi thì cũng hàng “đại gia” trong mắt người đi đường. Vì vậy, người Việt Nam vốn thích được khen; hoặc không giàu nhưng cố tỏ ra là mình có tiền đều đặt chỉ tiêu mua SH; nếu không muốn hoặc không đủ chi phí sắm ô tô.</p><h3><strong>Phù hợp với nhiều đối tượng, nổi bật khi ngồi lên</strong></h3><p>Tất nhiên, để có thể tạo ra một “trào lưu” như vậy thì bản thân SH cũng có rất nhiều ưu điểm mà các đối thủ khó theo kịp. Có thể nói, với thiết kế theo phong cách Châu Âu, chiếc xe này có thể phù hợp bất kể thành phần nào; từ già; trẻ; gái; trai ai cũng có thể “nổi bật” khi ngồi lên đó. Chưa kể, nếu đã “chán chê” khi sử dụng một thời gian; khách hàng có thể bán lại với giá khá cao. Việc giữ giá của chiếc xe này vô cùng tốt. Rồi khách mua lại cũng rất nhiều chứ chẳng phải chờ đợi lâu hay qua các cò mồi trung gian.</p><h3><strong>Tính năng không nổi trội</strong></h3><p>Chất lượng cũng như các tính năng trên SH thì khỏi phải bàn cãi nhiều. Mẫu xe này rất an toàn với hệ thống phanh ABS; giúp người điều khiển không mất lái và bị trượt bánh. Hệ thống đèn LED thông minh; tiết kiệm điện. Cốp xe dạng U-box có thể chứa rất nhiều đồ vật cho chị em. Bên cạnh đó, rất nhiều tính năng ưu việt được tích hợp trên thiết bị điều khiển <a href="https://vi.wikipedia.org/wiki/FOB_(Incoterm)#:~:text=FOB%20l%C3%A0%20m%E1%BB%99t%20thu%E1%BA%ADt%20ng%E1%BB%AF,l%C3%A0%20%22%20Giao%20l%C3%AAn%20t%C3%A0u%22.&amp;text=N%C3%B3%20l%C3%A0%20t%C6%B0%C6%A1ng%20t%E1%BB%B1%20v%E1%BB%9Bi,t%C3%A0u%20t%E1%BA%A1i%20c%E1%BA%A3ng%20x%E1%BA%BFp%20h%C3%A0ng.">FOB</a> bao gồm chức năng mở; tắt xe từ xa; hệ thống xác định vị trí xe thông minh và hệ thống báo động chống trộm mang lại sự tiện lợi vượt trội và trải nghiệm giống như sử dụng cho ô tô.</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 63, N'5ysb1gim.png', CAST(N'2023-05-03T09:08:53.0000000' AS DateTime2), CAST(N'2023-05-13T20:56:16.0434838' AS DateTime2), NULL, 4)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (11, N'Cb1000 2022 ', N'cb1000-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 9, N'ksijp0jp.png', CAST(N'2023-05-03T09:35:09.0000000' AS DateTime2), CAST(N'2023-05-03T09:36:15.4277246' AS DateTime2), NULL, 4)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (12, N'ShMode 2022 ', N'shmode-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 1, N'wgyittku.png', CAST(N'2023-05-03T09:36:32.0000000' AS DateTime2), NULL, NULL, 4)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (13, N'Winner X 2022 ', N'winner-x-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 1, N'x3yvjehy.png', CAST(N'2023-05-03T09:37:55.0000000' AS DateTime2), NULL, NULL, 4)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (14, N'R15 2022', N'r15-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 1, N'uldn0o1j.png', CAST(N'2023-05-03T09:39:29.0000000' AS DateTime2), NULL, NULL, 5)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (15, N'Exiter 2022', N'exiter-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'fqpsowv1.png', CAST(N'2023-05-03T09:41:03.0000000' AS DateTime2), NULL, NULL, 5)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (16, N'NVX 2022', N'nvx-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 1, N'3xamnjvd.png', CAST(N'2023-05-03T09:42:40.0000000' AS DateTime2), NULL, NULL, 5)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (17, N'Sirius 2022', N'sirius-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'32sjn2kj.png', CAST(N'2023-05-03T09:43:35.0000000' AS DateTime2), NULL, NULL, 5)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (18, N'MT-15 2022', N'mt-15-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'ev25skfv.png', CAST(N'2023-05-03T09:44:38.0000000' AS DateTime2), NULL, NULL, 5)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (19, N'Star SR 170 ABS', N'star-sr-170-abs', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'ogclcerv.png', CAST(N'2023-05-03T09:46:15.0000000' AS DateTime2), NULL, NULL, 7)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (20, N'New Galaxy', N'new-galaxy', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'hgohep4m.png', CAST(N'2023-05-03T09:47:25.0000000' AS DateTime2), NULL, NULL, 7)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (21, N'New Attila 125', N'new-attila-125', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'4w5rpkxe.png', CAST(N'2023-05-03T09:48:22.0000000' AS DateTime2), NULL, NULL, 7)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (22, N'Passing 50', N'passing-50', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 1, N'5fbjiuku.png', CAST(N'2023-05-03T09:50:09.0000000' AS DateTime2), NULL, NULL, 7)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (23, N'Wave  RSX 2022 ', N'wave-rsx-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'auqxhajb.png', CAST(N'2023-05-03T09:51:12.0000000' AS DateTime2), NULL, NULL, 4)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (24, N'Future 2022', N'future-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'0komrfem.png', CAST(N'2023-05-03T09:52:25.0000000' AS DateTime2), NULL, NULL, 4)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (25, N'Address 2022', N'address-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'r4vlrywv.png', CAST(N'2023-05-03T09:53:20.0000000' AS DateTime2), NULL, NULL, 6)
INSERT [dbo].[Product] ([Id], [ProductName], [Slug], [ProductDetails], [Price], [Trending], [Status], [Views], [Thumbnail], [CreateAt], [UpdateAt], [DeleteAt], [ShopId]) VALUES (26, N'Raider 2022', N'raider-2022', N'<p>Chưa cập nhật</p>', CAST(0 AS Decimal(18, 0)), 1, 0, 0, N'aalqos55.png', CAST(N'2023-05-03T09:54:16.0000000' AS DateTime2), NULL, NULL, 6)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'15d3c789-ab99-45fc-ab24-10c998531df9', 9, 1, 1, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'15d3c789-ab99-45fc-ab24-10c998531df9', 10, 1, 0, NULL, CAST(N'2023-05-13T15:02:31.0513799' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'15d3c789-ab99-45fc-ab24-10c998531df9', 11, 1, 1, NULL, CAST(N'2023-05-13T15:09:21.6082355' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'4da82fce-957c-449f-881f-97d4ebe172af', 9, 1, 0, NULL, CAST(N'2023-05-03T09:05:38.4392800' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'4da82fce-957c-449f-881f-97d4ebe172af', 10, 1, 0, NULL, CAST(N'2023-05-03T09:34:55.1290852' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'4da82fce-957c-449f-881f-97d4ebe172af', 22, 1, 0, NULL, CAST(N'2023-05-03T09:55:32.0800703' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'adb88806-f7fa-48aa-95e4-7a493844f9e6', 9, 1, 0, N'Xe chạy tốt', CAST(N'2023-05-13T20:56:38.7612149' AS DateTime2), CAST(N'2023-05-13T20:59:11.1790385' AS DateTime2), CAST(N'2023-05-13T21:03:10.0080431' AS DateTime2), NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'adb88806-f7fa-48aa-95e4-7a493844f9e6', 10, 1, 0, NULL, CAST(N'2023-05-13T20:59:32.4065812' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'adb88806-f7fa-48aa-95e4-7a493844f9e6', 11, 1, 1, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', 10, 1, 1, N'Xe vừa rẻ vừa đẹp', CAST(N'2023-05-07T09:57:37.5573897' AS DateTime2), CAST(N'2023-05-07T09:57:48.4469294' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'b2554fb7-e0cd-4efa-aa0f-6d9e5ee1ae40', 11, 1, 0, NULL, CAST(N'2023-05-07T09:41:06.1970479' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'c8bdec4a-bc26-403d-a3bf-901c9371d04e', 9, 1, 0, NULL, CAST(N'2023-05-06T13:10:33.7794256' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'c8bdec4a-bc26-403d-a3bf-901c9371d04e', 10, 1, 0, NULL, CAST(N'2023-05-08T21:20:11.3988733' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'c8bdec4a-bc26-403d-a3bf-901c9371d04e', 11, 1, 0, NULL, CAST(N'2023-05-08T21:20:14.0102992' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Reviews] ([UserId], [ProductId], [Viewd], [IsWishList], [ReviewsDetails], [DateView], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (N'c8bdec4a-bc26-403d-a3bf-901c9371d04e', 12, 1, 0, NULL, CAST(N'2023-05-08T21:20:16.9457974' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Shop] ON 

INSERT [dbo].[Shop] ([Id], [ShopName], [Slug], [Trending], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (4, N'Honda', N'honda', 1, CAST(N'2023-05-03T08:54:01.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Shop] ([Id], [ShopName], [Slug], [Trending], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (5, N'Yamaha', N'yamaha', 0, CAST(N'2023-05-03T08:54:12.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Shop] ([Id], [ShopName], [Slug], [Trending], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (6, N'Suzuki', N'suzuki', 0, CAST(N'2023-05-03T08:54:21.0000000' AS DateTime2), NULL, NULL)
INSERT [dbo].[Shop] ([Id], [ShopName], [Slug], [Trending], [CreateAt], [UpdateAt], [DeleteAt]) VALUES (7, N'SYM', N'sym', 1, CAST(N'2023-05-03T09:46:06.0000000' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Shop] OFF
GO
ALTER TABLE [dbo].[Carts] ADD  DEFAULT (N'') FOR [Color]
GO
ALTER TABLE [dbo].[DatLich] ADD  DEFAULT (N'') FOR [GhiChu]
GO
ALTER TABLE [dbo].[DatLich] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [NgayHen]
GO
ALTER TABLE [dbo].[DatLich] ADD  DEFAULT (N'') FOR [TrangThai]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'') FOR [Address]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'') FOR [PhoneNumber]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'') FOR [Type]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'') FOR [Status]
GO
ALTER TABLE [dbo].[Reviews] ADD  DEFAULT (CONVERT([bit],(0))) FOR [Viewd]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AppUser_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AppUser_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AppUser_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AppUser_UserId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_AppUser_UserId]
GO
ALTER TABLE [dbo].[Carts]  WITH CHECK ADD  CONSTRAINT [FK_Carts_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carts] CHECK CONSTRAINT [FK_Carts_Product_ProductId]
GO
ALTER TABLE [dbo].[ChiTietBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBaoHanh_BaoHanh_BaoHanhId] FOREIGN KEY([BaoHanhId])
REFERENCES [dbo].[BaoHanh] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietBaoHanh] CHECK CONSTRAINT [FK_ChiTietBaoHanh_BaoHanh_BaoHanhId]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap_PhieuNhapId] FOREIGN KEY([PhieuNhapId])
REFERENCES [dbo].[PhieuNhap] ([MaPhieu])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap_PhieuNhapId]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Product_ProductId]
GO
ALTER TABLE [dbo].[DatLich]  WITH CHECK ADD  CONSTRAINT [FK_DatLich_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DatLich] CHECK CONSTRAINT [FK_DatLich_Product_ProductId]
GO
ALTER TABLE [dbo].[GiaXe]  WITH CHECK ADD  CONSTRAINT [FK_GiaXe_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiaXe] CHECK CONSTRAINT [FK_GiaXe_Product_ProductId]
GO
ALTER TABLE [dbo].[Medias]  WITH CHECK ADD  CONSTRAINT [FK_Medias_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medias] CHECK CONSTRAINT [FK_Medias_Product_ProductId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Product_ProductId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AppUser_UserId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Shop_ShopId] FOREIGN KEY([ShopId])
REFERENCES [dbo].[Shop] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Shop_ShopId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_AppUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AppUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_AppUser_UserId]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Product_ProductId]
GO
