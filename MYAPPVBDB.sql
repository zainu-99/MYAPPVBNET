USE [master]
GO
/****** Object:  Database [MYAPP]    Script Date: 12/9/2020 8:26:32 AM ******/
CREATE DATABASE [MYAPP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MYAPP', FILENAME = N'E:\ProgramFile\SqlServer\MSSQL12.SQLEXPRESS\MSSQL\DATA\MYAPP.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MYAPP_log', FILENAME = N'E:\ProgramFile\SqlServer\MSSQL12.SQLEXPRESS\MSSQL\DATA\MYAPP_log.ldf' , SIZE = 5696KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MYAPP] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MYAPP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MYAPP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MYAPP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MYAPP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MYAPP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MYAPP] SET ARITHABORT OFF 
GO
ALTER DATABASE [MYAPP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MYAPP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MYAPP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MYAPP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MYAPP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MYAPP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MYAPP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MYAPP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MYAPP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MYAPP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MYAPP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MYAPP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MYAPP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MYAPP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MYAPP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MYAPP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MYAPP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MYAPP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MYAPP] SET  MULTI_USER 
GO
ALTER DATABASE [MYAPP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MYAPP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MYAPP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MYAPP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MYAPP] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MYAPP]
GO
/****** Object:  Table [dbo].[ChatMessage]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChatMessage](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Message] [text] NULL,
	[FileAttached] [varchar](250) NULL,
	[UserID] [bigint] NULL,
	[UserIDReciever] [bigint] NULL,
	[ReadStatus] [bit] NOT NULL CONSTRAINT [DF_ChatMessage_ReadStatus]  DEFAULT ((0)),
	[DeleteStatusUserSender] [bit] NOT NULL CONSTRAINT [DF_ChatMessage_DeleteStatusUserSender]  DEFAULT ((0)),
	[DeleteStatusUserReciever] [bit] NOT NULL CONSTRAINT [DF_ChatMessage_DeleteStatusUserReciever]  DEFAULT ((0)),
	[Created_At] [datetime] NULL,
 CONSTRAINT [PK_ChatMessage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ErrorReport]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ErrorReport](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](50) NULL,
	[MsgError] [text] NULL,
	[Datetime] [datetime] NULL,
	[Note] [text] NULL,
	[UserId] [bigint] NULL,
 CONSTRAINT [PK_ReportError] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GroupLevel]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GroupLevel](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_group] [bigint] NULL,
	[id_parent] [bigint] NULL,
	[remark] [varchar](250) NULL,
 CONSTRAINT [PK_GroupLevel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Groups](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[remark] [varchar](250) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kategori]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kategori](
	[id] [int] NOT NULL,
	[kategori] [varchar](30) NULL,
	[parent_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogApp]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogApp](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[TableName] [varchar](50) NULL,
	[DataBefore] [text] NULL,
	[DataAfter] [text] NOT NULL,
	[Datetime] [datetime] NULL,
	[UserID] [bigint] NULL,
	[Note] [varchar](250) NULL,
 CONSTRAINT [PK_LogApp] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MenuApp]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MenuApp](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MenuTag] [varchar](50) NULL,
	[MenuText] [nvarchar](50) NULL,
	[FormName] [varchar](50) NULL,
	[IDParentMenu] [int] NULL,
	[IconMenu] [image] NULL,
	[OrderSort] [int] NULL,
 CONSTRAINT [PK_MenuApp] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoleGroupLevel]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleGroupLevel](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_role] [bigint] NULL,
	[id_group_level] [bigint] NULL,
	[isView] [bit] NOT NULL CONSTRAINT [DF_RoleGroupLevel_isView]  DEFAULT ((1)),
	[isAdd] [bit] NOT NULL CONSTRAINT [DF_RoleGroupLevel_isAdd]  DEFAULT ((0)),
	[isEdit] [bit] NOT NULL CONSTRAINT [DF_RoleGroupLevel_isEdit]  DEFAULT ((0)),
	[isDelete] [bit] NOT NULL CONSTRAINT [DF_RoleGroupLevel_isDelete]  DEFAULT ((0)),
	[isPrint] [bit] NOT NULL CONSTRAINT [DF_RoleGroupLevel_isPrint]  DEFAULT ((0)),
	[isCustom] [bit] NOT NULL CONSTRAINT [DF_RoleGroupLevel_isCustom]  DEFAULT ((0)),
 CONSTRAINT [PK_GroupRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[remark] [varchar](250) NULL,
	[AccessView] [bit] NOT NULL CONSTRAINT [DF_Roles_AccessView]  DEFAULT ((0)),
	[AccessAdd] [bit] NOT NULL CONSTRAINT [DF_Roles_AccessAdd]  DEFAULT ((0)),
	[AccessEdit] [bit] NOT NULL CONSTRAINT [DF_Roles_AccessEdit]  DEFAULT ((0)),
	[AccessDelete] [bit] NOT NULL CONSTRAINT [DF_Roles_AccessDelete]  DEFAULT ((0)),
	[AccessPrint] [bit] NOT NULL CONSTRAINT [DF_Roles_AccessPrint]  DEFAULT ((0)),
	[AccessCustom] [bit] NOT NULL CONSTRAINT [DF_Roles_AccessCustom]  DEFAULT ((0)),
 CONSTRAINT [PK_Auth] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SettingApp]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SettingApp](
	[id] [int] NOT NULL,
	[name] [varchar](50) NULL,
	[remark] [varchar](250) NULL,
	[adjustment] [varchar](250) NULL,
 CONSTRAINT [PK_SettingApp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserGroupLevel]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroupLevel](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_user] [bigint] NULL,
	[id_group_level] [bigint] NULL,
 CONSTRAINT [PK_UserGroupLevel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[id_user] [bigint] NULL,
	[id_role] [bigint] NULL,
	[allow_view] [bit] NULL,
	[allow_add] [bit] NULL,
	[allow_update] [bit] NOT NULL,
	[allow_delete] [bit] NULL,
	[allow_print] [bit] NULL,
	[allow_custom_access] [int] NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/9/2020 8:26:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[userid] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[nohp] [varchar](50) NULL,
	[address] [varchar](250) NULL,
	[avatar] [image] NULL,
	[gender] [varchar](50) NULL,
	[status] [bit] NOT NULL CONSTRAINT [DF_Users_status]  DEFAULT ((0)),
	[online_offline] [bit] NOT NULL CONSTRAINT [DF_Users_online_offline]  DEFAULT ((0)),
	[password_noencrypt] [varchar](50) NULL,
	[password] [varchar](250) NULL,
	[token] [varchar](250) NULL,
	[created_at] [datetime] NULL CONSTRAINT [DF_myTable_createdat]  DEFAULT (getdate()),
	[updated_at] [datetime] NULL CONSTRAINT [DF_myTable_updatedAt]  DEFAULT (getdate()),
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ChatMessage] ON 

INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (48, N'dsf', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:39:52.353' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (49, N'e', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:41:49.443' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (50, N'd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:42:01.780' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (51, N's', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:42:44.180' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (52, N'qwer', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:48:18.000' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (53, N'f', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:48:27.467' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (54, N'gfdf', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:48:42.437' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (55, N'd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:51:52.080' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (56, N'dd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:52:09.820' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (57, N'sss', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:52:23.953' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (58, N'ddd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:54:30.540' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (59, N'ddd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:54:41.390' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (60, N'werwe', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:55:20.827' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (61, N'kkk', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:56:59.160' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (62, N'lll', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 05:57:03.747' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (63, N'rwrwer', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:20.120' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (64, N'fasdf', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:35.887' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (65, N'fasd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:36.527' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (66, N'fasdf', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:37.050' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (67, N'fasd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:37.610' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (68, N'fsda', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:38.157' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (69, N'fasd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:38.710' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (70, N'fasd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:39.210' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (71, N'fasd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:39.867' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (72, N'fasd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:40.443' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (73, N'fasd', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:40.967' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (74, N'fff', N'-', 16, 17, 1, 0, 0, CAST(N'2020-11-23 06:07:42.877' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (75, N'fsdfsd', N'-', 17, 16, 1, 0, 0, CAST(N'2020-11-23 06:09:16.287' AS DateTime))
INSERT [dbo].[ChatMessage] ([ID], [Message], [FileAttached], [UserID], [UserIDReciever], [ReadStatus], [DeleteStatusUserSender], [DeleteStatusUserReciever], [Created_At]) VALUES (76, N'rwerw', N'-', 17, 16, 1, 0, 0, CAST(N'2020-11-23 06:55:15.263' AS DateTime))
SET IDENTITY_INSERT [dbo].[ChatMessage] OFF
SET IDENTITY_INSERT [dbo].[ErrorReport] ON 

INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (247, N'getDataSet', N'Incorrect syntax near the keyword ''and''.', CAST(N'2020-12-05 17:48:33.543' AS DateTime), N'Annajiyah:192.168.56.1 - FormRoleGroup - ', 16)
INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (248, N'getDataSet', N'Incorrect syntax near '')''.', CAST(N'2020-12-05 18:39:12.280' AS DateTime), N'Annajiyah:192.168.56.1 - FormGroupLevel - ', 16)
INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (249, N'getDataSet', N'Incorrect syntax near '')''.', CAST(N'2020-12-05 18:43:29.633' AS DateTime), N'Annajiyah:192.168.56.1 - FormGroupLevel - ', 16)
INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (250, N'getDataSet', N'Incorrect syntax near the keyword ''from''.
Incorrect syntax near ''b''.', CAST(N'2020-12-05 19:15:21.610' AS DateTime), N'Annajiyah:192.168.56.1 - FormUser - ', 16)
INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (251, N'getDataSet', N'Incorrect syntax near the keyword ''from''.
Incorrect syntax near ''b''.', CAST(N'2020-12-05 19:15:29.150' AS DateTime), N'Annajiyah:192.168.56.1 - FormUser - ', 16)
INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (252, N'getDataSet', N'Incorrect syntax near the keyword ''from''.
Incorrect syntax near ''b''.', CAST(N'2020-12-05 19:16:49.987' AS DateTime), N'Annajiyah:192.168.56.1 - FormUserGroup - ', 16)
INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (253, N'getDataSet', N'Incorrect syntax near the keyword ''from''.
Incorrect syntax near ''b''.', CAST(N'2020-12-05 19:18:31.363' AS DateTime), N'Annajiyah:192.168.56.1 - FormUserGroup - ', 16)
INSERT [dbo].[ErrorReport] ([ID], [Action], [MsgError], [Datetime], [Note], [UserId]) VALUES (254, N'getDataSet', N'Incorrect syntax near the keyword ''group''.
Invalid usage of the option NEXT in the FETCH statement.', CAST(N'2020-12-06 05:28:37.540' AS DateTime), N'Annajiyah:192.168.56.1 - FormMain - ', 16)
SET IDENTITY_INSERT [dbo].[ErrorReport] OFF
SET IDENTITY_INSERT [dbo].[GroupLevel] ON 

INSERT [dbo].[GroupLevel] ([id], [id_group], [id_parent], [remark]) VALUES (18, 2, NULL, N'Group Admin')
INSERT [dbo].[GroupLevel] ([id], [id_group], [id_parent], [remark]) VALUES (19, 3, 18, N'Group Staff')
SET IDENTITY_INSERT [dbo].[GroupLevel] OFF
SET IDENTITY_INSERT [dbo].[Groups] ON 

INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (2, N'Admin', N'Admin', NULL, CAST(N'2020-11-21 01:34:42.000' AS DateTime))
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (3, N'Staff', N'Staff', CAST(N'2020-11-21 07:23:00.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (4, N'Leader', N'Leader', CAST(N'2020-11-21 07:23:11.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (5, N'Supervisor', N'Supervisor', CAST(N'2020-11-21 07:23:20.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (6, N'Manager', N'Manager', CAST(N'2020-11-21 07:23:30.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (7, N'Director', N'Director', CAST(N'2020-11-21 07:23:54.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (8, N'HR', N'Department', CAST(N'2020-11-21 07:24:32.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (9, N'GA', N'Department', CAST(N'2020-11-21 07:25:17.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (10, N'IT', N'Department', CAST(N'2020-11-21 07:25:27.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (11, N'Finance', N'Department', CAST(N'2020-11-21 07:25:44.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (12, N'Sales', N'Department', CAST(N'2020-11-21 07:25:57.000' AS DateTime), NULL)
INSERT [dbo].[Groups] ([id], [name], [remark], [created_at], [updated_at]) VALUES (13, N'RnD', N'Department', CAST(N'2020-11-21 07:26:17.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Groups] OFF
SET IDENTITY_INSERT [dbo].[LogApp] ON 

INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6641, N'Login', N'-', N'-', N'-', CAST(N'2020-11-22 21:12:45.940' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6642, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-22 21:13:10.807' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6643, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:39:38.487' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6644, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 05:41:52.070' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6645, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:41:53.537' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6646, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 05:42:33.433' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6647, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:42:36.713' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6648, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 05:42:46.337' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6649, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:42:52.213' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6650, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:48:10.797' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6651, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:51:28.383' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6652, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:51:45.970' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6653, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:53:28.230' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6654, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:54:24.617' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6655, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:55:14.847' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6656, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 05:56:52.937' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6657, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 05:57:21.517' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6658, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:07:09.727' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6659, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:08:14.900' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6660, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:08:20.650' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6661, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:08:47.907' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6662, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:08:53.787' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6663, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:09:00.487' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6664, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:09:04.440' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6665, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:09:18.557' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6666, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:09:23.287' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6667, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:12:31.263' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6668, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:21:52.737' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6669, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:27:33.820' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6670, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:27:47.037' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6671, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:27:54.537' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6672, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:29:38.710' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6673, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:46:47.827' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6674, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:50:09.610' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6675, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:50:34.273' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6676, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:50:39.270' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6677, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:52:09.597' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6678, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:52:25.640' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6679, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:52:30.237' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6680, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:54:57.737' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6681, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:55:03.707' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6682, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:55:07.747' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6683, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:55:21.277' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6684, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:55:24.920' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6685, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:55:35.800' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6686, N'Login', N'-', N'-', N'-', CAST(N'2020-11-23 06:55:42.447' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6687, N'Logout', N'-', N'-', N'-', CAST(N'2020-11-23 06:55:48.403' AS DateTime), 17, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6688, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 17:47:45.930' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6689, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 17:49:45.630' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6690, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 17:51:13.063' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6691, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:19:21.697' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6692, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:20:28.850' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6693, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:21:07.647' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6694, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 18:24:08.903' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6695, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:25:07.860' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6696, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 18:26:24.033' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6697, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:26:48.563' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6698, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:28:33.697' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6699, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:30:26.837' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6700, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:31:09.910' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6701, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:32:19.910' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6702, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:39:00.607' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6703, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:40:04.373' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6704, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:42:00.430' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6705, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:43:19.280' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6706, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 18:43:32.803' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6707, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:44:49.490' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6708, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:46:06.870' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6709, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:47:05.713' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6710, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 18:47:27.697' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6711, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:48:47.103' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6712, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:50:11.620' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6713, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 18:54:12.537' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6714, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 18:59:55.130' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6715, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:06:51.087' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6716, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 19:07:01.383' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6717, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:11:01.833' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6718, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:15:12.087' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6719, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:16:30.447' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6720, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:18:17.660' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6721, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:18:49.960' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6722, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:19:36.387' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6723, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:20:33.453' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6724, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:20:58.953' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6725, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:22:20.203' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6726, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 19:22:47.457' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6727, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:23:03.890' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6728, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:24:42.957' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6729, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:27:29.203' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6730, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 19:27:44.750' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6731, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:31:01.663' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6732, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:31:36.637' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6733, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:32:52.580' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6734, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 19:34:25.650' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6735, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:34:50.443' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6736, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:36:03.080' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6737, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:38:27.470' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6738, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:40:42.953' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6739, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:42:07.103' AS DateTime), 16, N'Annajiyah:192.168.56.1')
GO
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6740, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 19:42:51.323' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6741, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 19:43:35.443' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6742, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 19:51:00.360' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6743, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 20:53:04.147' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6744, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 20:54:42.430' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6745, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 20:55:58.590' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6746, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 20:56:11.110' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6747, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 20:59:42.950' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6748, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:00:24.437' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6749, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:02:08.997' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6750, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:02:58.980' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6751, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:03:28.453' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6752, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:04:00.460' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6753, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:04:20.690' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6754, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:06:57.503' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6755, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:07:10.460' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6756, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:07:54.437' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6757, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:08:33.023' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6758, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:09:13.013' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6759, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:09:21.410' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6760, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:10:46.513' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6761, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:11:12.200' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6762, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:12:05.353' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6763, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:12:23.603' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6764, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:12:41.447' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6765, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:12:53.010' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6766, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:17:34.677' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6767, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:17:53.090' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6768, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:18:45.240' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6769, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:18:53.290' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6770, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:19:05.167' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6771, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:19:27.933' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6772, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:21:56.623' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6773, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:22:45.943' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6774, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:23:33.767' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6775, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:24:06.690' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6776, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:25:06.057' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6777, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:28:07.820' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6778, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:28:50.833' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6779, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:29:19.967' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6780, N'Login', N'-', N'-', N'-', CAST(N'2020-12-05 21:29:55.187' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6781, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-05 21:31:12.137' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6782, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:25:26.380' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6783, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:26:03.103' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6784, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:28:25.937' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6785, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:29:02.570' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6786, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:29:16.550' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6787, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:30:20.870' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6788, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:30:32.943' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6789, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:40:37.230' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6790, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:41:32.733' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6791, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:41:46.210' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6792, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:43:11.273' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6793, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:45:31.817' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6794, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:49:26.997' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6795, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:49:50.130' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6796, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:50:26.183' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6797, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:51:55.903' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6798, N'Login', N'-', N'-', N'-', CAST(N'2020-12-06 05:51:58.273' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6799, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-06 05:53:17.743' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6800, N'Login', N'-', N'-', N'-', CAST(N'2020-12-09 08:24:41.000' AS DateTime), 16, N'Annajiyah:192.168.56.1')
INSERT [dbo].[LogApp] ([ID], [Action], [TableName], [DataBefore], [DataAfter], [Datetime], [UserID], [Note]) VALUES (6801, N'Logout', N'-', N'-', N'-', CAST(N'2020-12-09 08:25:14.000' AS DateTime), 16, N'Annajiyah:192.168.56.1')
SET IDENTITY_INSERT [dbo].[LogApp] OFF
SET IDENTITY_INSERT [dbo].[MenuApp] ON 

INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (1, N'Sistem Admin', N'Sistem Admin', N'', NULL, 0x89504E470D0A1A0A0000000D49484452000000300000003008060000005702F9870000000467414D410000B18F0BFC61050000038D494441546843ED985D4853611CC6FD20F4C2BB0AEAC2D268F32A0A5660D9701F89E4DA9C8558D8855A1468574114A9155D291919F4E1C7454A647E4006893A14AC6D2A75535010EBA2CC4A0A8A40A65B98FEFBBFEBBF7176CE6BBAB9BD5BB0077E7838E77D9FE779CF79CF619894504209454E3A9D2EC368341E37180CBDC81BE41B027EF47A7D1E0D8D3F61B962645A5A580E5E1FA1E1F1252C56CF2BBC0CAF9106AD56BB99A6C75658E6BCA45C28B871E147C82636C23D9F8B451664C542E1372EC24876E285059ECA0A85C39446A3594796E284774EC329C3A5BCC4086D170AC175CFE4FBCB19534AB6E2849FCBAB9C22012A4B0F40475D217CB86F02183207C1CE4BC7A25727D98A13062BB68FF44ECB4BCB913D8917642B4EB8857CDFFC7FDDE995903C8929B215270C9D63E1BC62A1400B7093AD385130B75428F87DC8569CFEEB0540B7EAD0D9F27DF3915AC0C58A3C373C5017917DF4050FD5D38B5D3970EB5C615099B6136A683F9913744E0AEF3AFB1A2D75A9013DC5BDC818F619092AC268A954416B95F2BC9F65AF332FBC29641F7DB12D84815F60D0B4A4281332E8C16E88C82DE4170C595CFC5221F196ECC40BC35B65654267D87C87ECC40B6C96026EA95018341BC82E36C212A38A52ABC74636B113BE0739B80D7E72CAADC40F18B66C279BD80AB741BEAF10BF288FEF306CD2D2F4F8100C98B641FF5E5ED9601EE502D8CCD9342DBE042D49001D1B01FA76013C31E20B8A3FB119ECB86F2740275EC331343CFEE45BC02AA0E1F1275E591E343C3E54FCECD78ECCBA91C98C533DDE574D5BBDBCC2525E366579334E777BD91C36976CC4CBE29CDB5DECF08C2290593F02C965ED905F53BBC02B2D25BFBA76818DDD726914D85CE66175CC69C836FAD28D413A86B6218B5400F6F77CF42D8071B30E5F584E7146335EF38FD3F67EF22F80B16871785A0F0E421AC544474563EE4D183629090EA06A7006CA1DAEA9067BA30ADCB7D37CB0E39233D581EBEAC609C57C1F76CF04CBA0B8C8CA3C36BB01435C8A503F760F161B87142AC923F52896BF86E5712CD7E32FAE92E7B3EB2936420248C6501B274C81AE7F06F65CEE82ACAAEB907EECAE8F6C3C66E7F48F67B87314383D03941C1959ED9E0A6E503471CE9751FCDA54DA0BA968F85E111065AC0ECFBB2B002954237C599CDE025E8008F0C9AFFD5FEF56C77C33CF5C0416BBF706D5085F68C4FD6C0A629C6A842F34F92A3315C90CD5085F68E295998AC44335124A2821AE9292FE0033E77EFE2E69F73D0000000049454E44AE426082, 0)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (10, N'Master Data', N'Master Data', N'', NULL, 0x89504E470D0A1A0A0000000D49484452000000300000003008060000005702F9870000000467414D410000B18F0BFC6105000002F1494441546843ED98CF6BD36018C7EB41BDF92FAC49A7A083896EE26178F1E60F0405F5E6C193E0C1BB82173D8807C16193461177B0EAA620EC6415DC9C1DA8203A4114655346952D6D297DD3A253DCEBF3B64FBBB7ED9BCEBEC99B55C8073E90E54D9E7CDF923779B248484848488852DE4C670FCCA417E7401AB0B3EFD2F67E8C21CF4C7A615E503C28BF620C790445031563C8232A1AA418431E51D120C518F2888A0629C6904754344831863CA2A2418A31E4812299E6A2C1B9308F31E4C117D9B7D6E2CACDF8F2220B596BC25EC89B612F144EC0AB18431E5151D52653D9FA36C690872FACDAB7E0F987791A339CFA3E8C210F7F0195BE9AB2E9893B05AA4178666D3FC690078A28EF859E3CB5E9DE5BC57AF89509FC07BDD0ED4739DA6F9186F0CCED16F9D367912F9A4146A271E778DF18DD8091BA8768BC7406C2FE6E0EEFE26C8F490EE3A9DD418713602E83172294AEC312ABA3BA171A7D9CA53BAFB7DE42EDD48DD2258CB73A41F442131336DD37D2B888A79F2DD2B154EE3B6C5BE02F7E0C5CD64D721023B647744115BE7E6ED353F7C48FD198511E807D6C32FC243E0D58747D25643BF88BF8E103B86526276DE118F3F2789E6E3649FD6F8C11E931CB3B20F452D3248EE2B03B7C713F3C79B740076F107A1F26221A672653B9FA36C6A8A0C59DABFC04A28693C42177F8C27EB8E76675C16E815FF9CAF84A5037314685E8B5E26E7E0230A10F38E48EA8A817B7595C00F0C594F8B89A18A342EF707E137F2E58C421774445BDB835D11080BEF436018243EE40115F7BA121BC856AB2F780E8B8AA8DBD50CC2443FCB9E0471C72C7EF5E88EF3899A7470BC2E3C096FF0BE98663F2E7FED322F61BCD748EF121C09F9A51EAC76157A41FA37EC3BA4AB8F0673E08FCB21916100F69C1D38B4C05D0221F8200AC31E3032DE97127A127CA83BDC37423538F9777C17E6FAD842AE0197EAE29540792B358660D819618D6C3457140573B6FA75503B7CD1158C4734D414576DF074D0D76BFB3CF46F6F9080BFA3D84FDC1AC6EB7FBA48C44FE02735DA7AFBB4B61040000000049454E44AE426082, 1)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (11, N'User', N'User', N'FormUser', 1, 0x89504E470D0A1A0A0000000D4948445200000018000000180806000000E0773DF80000000467414D410000B18F0BFC61050000016E49444154484BCDD5314B846018C0714FC3A236C7F6C6D6863E43CADD9837049151E0E07D839696FA0E2244144535B4C68938E92C4435A477D3E122A4D141698FBD0F479D39DCFB0AF587E3501F7E2FE88B727F9A24492DD3340F0CC358C053CD258A225714C535FCCAEE7BBDDE3C5E6A2640EF883DE949D7F545BCCC569AA6B7884EF7A8699A8863F4C1024B08FE56D8ED76D917C9B2AC5CE49D9895069D4E87FD990C87C365C0DE885929926599FD990441B0025846CC4AA1A228EC8BF8BEBF0AD80B312B3DB7DB6DF6DBE5BAEE1A60758B84AAAACEE1287DB66DAF03F64ACC4A0F38465FBFDFDF01E883783F1B8FC737384697E338FBE0E484AB74896374799EB707481D7ECEF37C0B47670FB6E92E2075F829BC14791C9DBD288AB601A9C32D261CDE475B80D4E1278220D0DF16C037119A2E87DD728563F4C102472546CC497992246CBBE57B001E96E8170DFF711C9FE1A566C24FE671898F46A30B3CDD6CF0D1E72CCBDAC0C3FF18C77D021ADE2D75DE3971BB0000000049454E44AE426082, 1)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (12, N'Master Group', N'Group', N'FormGroup', 10, 0x89504E470D0A1A0A0000000D4948445200000018000000180806000000E0773DF80000000467414D410000B18F0BFC61050000016E49444154484BCDD5314B846018C0714FC3A236C7F6C6D6863E43CADD9837049151E0E07D839696FA0E2244144535B4C68938E92C4435A477D3E122A4D141698FBD0F479D39DCFB0AF587E3501F7E2FE88B727F9A24492DD3340F0CC358C053CD258A225714C535FCCAEE7BBDDE3C5E6A2640EF883DE949D7F545BCCC569AA6B7884EF7A8699A8863F4C1024B08FE56D8ED76D917C9B2AC5CE49D9895069D4E87FD990C87C365C0DE885929926599FD990441B0025846CC4AA1A228EC8BF8BEBF0AD80B312B3DB7DB6DF6DBE5BAEE1A60758B84AAAACEE1287DB66DAF03F64ACC4A0F38465FBFDFDF01E883783F1B8FC737384697E338FBE0E484AB74896374799EB707481D7ECEF37C0B47670FB6E92E2075F829BC14791C9DBD288AB601A9C32D261CDE475B80D4E1278220D0DF16C037119A2E87DD728563F4C102472546CC497992246CBBE57B001E96E8170DFF711C9FE1A566C24FE671898F46A30B3CDD6CF0D1E72CCBDAC0C3FF18C77D021ADE2D75DE3971BB0000000049454E44AE426082, 1)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (13, N'Role', N'Role', N'FormRole', 10, 0x89504E470D0A1A0A0000000D4948445200000018000000180806000000E0773DF80000000467414D410000B18F0BFC61050000016E49444154484BCDD5314B846018C0714FC3A236C7F6C6D6863E43CADD9837049151E0E07D839696FA0E2244144535B4C68938E92C4435A477D3E122A4D141698FBD0F479D39DCFB0AF587E3501F7E2FE88B727F9A24492DD3340F0CC358C053CD258A225714C535FCCAEE7BBDDE3C5E6A2640EF883DE949D7F545BCCC569AA6B7884EF7A8699A8863F4C1024B08FE56D8ED76D917C9B2AC5CE49D9895069D4E87FD990C87C365C0DE885929926599FD990441B0025846CC4AA1A228EC8BF8BEBF0AD80B312B3DB7DB6DF6DBE5BAEE1A60758B84AAAACEE1287DB66DAF03F64ACC4A0F38465FBFDFDF01E883783F1B8FC737384697E338FBE0E484AB74896374799EB707481D7ECEF37C0B47670FB6E92E2075F829BC14791C9DBD288AB601A9C32D261CDE475B80D4E1278220D0DF16C037119A2E87DD728563F4C102472546CC497992246CBBE57B001E96E8170DFF711C9FE1A566C24FE671898F46A30B3CDD6CF0D1E72CCBDAC0C3FF18C77D021ADE2D75DE3971BB0000000049454E44AE426082, 3)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (15, N'Menu', N'Menu', N'FormMenuApp', 10, 0x89504E470D0A1A0A0000000D4948445200000018000000180806000000E0773DF80000000467414D410000B18F0BFC61050000016E49444154484BCDD5314B846018C0714FC3A236C7F6C6D6863E43CADD9837049151E0E07D839696FA0E2244144535B4C68938E92C4435A477D3E122A4D141698FBD0F479D39DCFB0AF587E3501F7E2FE88B727F9A24492DD3340F0CC358C053CD258A225714C535FCCAEE7BBDDE3C5E6A2640EF883DE949D7F545BCCC569AA6B7884EF7A8699A8863F4C1024B08FE56D8ED76D917C9B2AC5CE49D9895069D4E87FD990C87C365C0DE885929926599FD990441B0025846CC4AA1A228EC8BF8BEBF0AD80B312B3DB7DB6DF6DBE5BAEE1A60758B84AAAACEE1287DB66DAF03F64ACC4A0F38465FBFDFDF01E883783F1B8FC737384697E338FBE0E484AB74896374799EB707481D7ECEF37C0B47670FB6E92E2075F829BC14791C9DBD288AB601A9C32D261CDE475B80D4E1278220D0DF16C037119A2E87DD728563F4C102472546CC497992246CBBE57B001E96E8170DFF711C9FE1A566C24FE671898F46A30B3CDD6CF0D1E72CCBDAC0C3FF18C77D021ADE2D75DE3971BB0000000049454E44AE426082, 2)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (17, N'Setting', N'Setting', N'', NULL, 0x89504E470D0A1A0A0000000D49484452000000300000003008060000005702F987000000017352474200AECE1CE90000000467414D410000B18F0BFC610500000462494441546843ED58ED8B54551C7E7CCD504391500CD48430F09B1F24644583326C759C178612138C0A7A234341B00FE2D752097A83D4757645916D5D4110EB2F884805114424CD3267667785FA20B5F9B6A7E777EE6FF5CEB967DCE9EEBDD7057DE061E69EFB9CF33CE7DEF33683C7781461BEC304D38901D238FC5525631BA603733DE18577A4732A1BBB3007B0C4133EE03ECC56D9C3873984A74C05AF9B8398AA45303B319E651F7BC3076C57A905B533C84DE4142DCA0E0CF38D86FA93FC9421569A2E9CD5B266BC4B4D07DFD232EABFE6F50D2DDFA1CD660386586AC34403C6E520DFE4B3DA7CBA3006E368F8A31320091E538B7441A3F58EB18FDD7CA26DE630665A56B09C653D8E264A0E43B5490F343A1A310EB30B1FAA3402DEDBECAD33CC0AF6A8343D702D9F46B30311F380DD2A6B0A76A2D7536F88DCC5B627AB2C7D30C86B4E0823C3466F3705352B9C7A837CF22FEBED6CE104910EDCDB139A41DF60B8DEDF7A2B7BD0FC9F8630AD74A003D31BEA3CAC0ED0781539180A127F0875619DDE4E1F32D168BA9B9489170E228C3B89853D9C0B7354961E68F4B963DCC8D12CA3591CB965B3F118BB0C36321ED294AD6D645C4AD5263EFA7398DD5FC2C230AFE630576F5BD0E890639C04AFC90AA516F1502BE1F95A017749E3B25EC00A95C950788686C327C9A4B8419B8F8F5A11055F78CB22DE5699050D77A8B174E42B7B440E76E8914EA997F80056F3732B79C59655F0931C12B5E9F860D08F22C18759C4272AB3B063BB136FF27386165930DC1A1BCAC72EEC35DF62924A83DFCF15ACE57C49E6285D2DE0336F78B29EC7172ABB07B31213FBD6369ACBCF466FF8806FA92C3EEA653CCD40FDE4098EF9570C30EE5A01B3EA457CC9B21BC3813D94B9D1532B63DE954D98C20EBDC7EBCBE4CD6A0E8BB4F9E06765276E3BC10356F0AACAE283867BC970B00B64CD297B10FF22EB4ED9F7DABC05C39E8B84EFC4BFECC0732A8987BE225EA0D990639E0CF328A94D3A90574BA33311E3E478B56FD5C887B9D8E02AB2D1631A212772373FDB7E6FC74C616D1D96F3BA27AC69C66A1EDBD42E7930D82E9F69980CD0F41CC321B2D95727C4216E761FA83C7998322630C4761ADD728C2DE5C9ABB429A8EB75EB29EBB2A2A92C5D70F95B4AC3DF9C00C211CFF2729CF0D43B2D4BB34AB201831C7183B4320107CA98E6D66BE5CD250E1A4786422B1DB89EC374B75EE61D909D97C627DC2064DC21F4B3744C25E98243600E27F20F9E10A39DC4E738B716A82C1DF0ACF3228D061CE3068E7219EDE75EB344E5C983067B1C432FE54DF0B34D0E6CC2FFB391915BD42E79D85DB580EB8E6192BC78BE9CF25F833479D7314D8CD522726A931EEC812E8F53BE00A3E449B5481F3A99C5F40ED96B97C63CDEE0F73E2D6F4A6AABD4E6D946BBAE667234BF5D2F61B1369F0DAA25BCC41563BE5E5AFC51C6930C783C1CB88145ECFF65359E50B985FE8B31E2FE9119388E774682DFE73B2A1BBBE0D078DF13DC92CB6B767FC0C605C775C9175E283F4755367621073AE904E742394C76A0287FA1A8EC315A03F01F44120F6FE80E50120000000049454E44AE426082, 7)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (25, N'Log', N'Logs', N'FormLog', NULL, 0x89504E470D0A1A0A0000000D49484452000000300000003008060000005702F9870000000467414D410000B18F0BFC6105000002D7494441546843ED97BF4F53511886E9E8E4A82EFE058E6E2EA09B98F047A8A32C22C644233AF823A9B18B0B8B891143EA600A8912814082A9D58154D0CD8231615063A2D29612E07EDE73EF7BDAE3E1BBEDE19EDB43D5BEC9933487F27ECF07072EF474D34D37FF49326F3769BF80825DB8625740C12E5CB12BA06017AED81550B00B57EC0A28D8852B760514ECC215BB020A76D14B8F0C2FD5893A8F8BDA2780825DF4D2A881EA795CD43E0114ECA297460D54CFE3A2F609A06017BDD42550B00B57EC0A28D8852B760514ECA29746DD59F53C2E6A9F000A76D14BA306AAE77151FB0450B08B5E1A35503D8F8BDA2780825DF4529740C12E5CB12BA06017AED81550B08B5E1A7567D573138EDE59DBC5C5998D3F80825D54495D34EADC847F66810B67FA6201BDD6512593447E95393913A0D73ADCF02450AF8AE0DEE05923A0651E6E7812FCF50B48E402F469C2086899871B9A2497666AC10295D20B5658E31BB4CCC30D4D92ABF3E17720BFB418487A6F46682B9DF2E90129F20AD7E5020FA0D53C27C72AE402B1C0ED7C788DAECDADD3AFD25420BA931BA82FB0F3AC5FCAAF51297B108ACDC30D6B07FA77E1E1EBCFE409D9D51C6D8F9F0810AF7D798F562706A0D73ADCB07620174817366968365C627A7139FC8A7F7C1A122E340235B370C3DA815C4070175749305F7C27AF8DCF641A5AE6E186B5036E81219F8562B1B1C0EA6486885250338B5FFE531FD60ED2855A202FAE90FC755ABF422A7BBE424F2ACBDCC0A4B9B950A3FBFE0257E642F9FA0FF16EF6FA435CCE70039366F0658D6EE543F91BF33F6863A5F130DB993E17A02CF19D567287A0D83CBDD9F2617FC0177D60D29C1EAFD0307EFBC80799C07B75397880050F31FFB5B284D9834CA4F7D1FAB1536395297F50551F9C24FDD92A9D7F5EA532FE94F0DE8FD256E640FD41265E7B1F46E5025FA1D77981206D3F3EDE9007E24C7E1C6FEFBC707F3A73E0ED9D174E96036FEF9C70FF2E9A804FDFFF7072ADE9A3DF18ABCC8AA4D2E3BB0000000049454E44AE426082, 5)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (30, N'Akun', N'Akun', N'FormAccount', 17, 0x89504E470D0A1A0A0000000D4948445200000018000000180806000000E0773DF80000000467414D410000B18F0BFC61050000016E49444154484BCDD5314B846018C0714FC3A236C7F6C6D6863E43CADD9837049151E0E07D839696FA0E2244144535B4C68938E92C4435A477D3E122A4D141698FBD0F479D39DCFB0AF587E3501F7E2FE88B727F9A24492DD3340F0CC358C053CD258A225714C535FCCAEE7BBDDE3C5E6A2640EF883DE949D7F545BCCC569AA6B7884EF7A8699A8863F4C1024B08FE56D8ED76D917C9B2AC5CE49D9895069D4E87FD990C87C365C0DE885929926599FD990441B0025846CC4AA1A228EC8BF8BEBF0AD80B312B3DB7DB6DF6DBE5BAEE1A60758B84AAAACEE1287DB66DAF03F64ACC4A0F38465FBFDFDF01E883783F1B8FC737384697E338FBE0E484AB74896374799EB707481D7ECEF37C0B47670FB6E92E2075F829BC14791C9DBD288AB601A9C32D261CDE475B80D4E1278220D0DF16C037119A2E87DD728563F4C102472546CC497992246CBBE57B001E96E8170DFF711C9FE1A566C24FE671898F46A30B3CDD6CF0D1E72CCBDAC0C3FF18C77D021ADE2D75DE3971BB0000000049454E44AE426082, 0)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (32, N'UI', N'UI', N'FormUI', 17, 0x89504E470D0A1A0A0000000D4948445200000018000000180806000000E0773DF80000000467414D410000B18F0BFC61050000016E49444154484BCDD5314B846018C0714FC3A236C7F6C6D6863E43CADD9837049151E0E07D839696FA0E2244144535B4C68938E92C4435A477D3E122A4D141698FBD0F479D39DCFB0AF587E3501F7E2FE88B727F9A24492DD3340F0CC358C053CD258A225714C535FCCAEE7BBDDE3C5E6A2640EF883DE949D7F545BCCC569AA6B7884EF7A8699A8863F4C1024B08FE56D8ED76D917C9B2AC5CE49D9895069D4E87FD990C87C365C0DE885929926599FD990441B0025846CC4AA1A228EC8BF8BEBF0AD80B312B3DB7DB6DF6DBE5BAEE1A60758B84AAAACEE1287DB66DAF03F64ACC4A0F38465FBFDFDF01E883783F1B8FC737384697E338FBE0E484AB74896374799EB707481D7ECEF37C0B47670FB6E92E2075F829BC14791C9DBD288AB601A9C32D261CDE475B80D4E1278220D0DF16C037119A2E87DD728563F4C102472546CC497992246CBBE57B001E96E8170DFF711C9FE1A566C24FE671898F46A30B3CDD6CF0D1E72CCBDAC0C3FF18C77D021ADE2D75DE3971BB0000000049454E44AE426082, 2)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (39, N'Error Report', N'Error Report', N'FormErrorReport', NULL, 0x89504E470D0A1A0A0000000D49484452000000300000003008060000005702F9870000000467414D410000B18F0BFC610500000337494441546843ED994B6B135114C7E30B173ED08D820ABA702D429D99B6E9629849035D4BF50BD86D5D745141B075A1B5AE127CA0E007105B9F1B117C54BF81C5AD0BD14A6989AF649249D2F67AEE78A6A477CE4DE695C481FCE04F2973CEB9FF33B9775E37D5A3478FE8B0E9D4F6B271462D99CA44C9D41EC2DFC55246FDB145A6FA118F4D58A6A2F01C4CEF1E655D3B06C66641DF402CA0BE960C6DA66C0C1CC5729DE3D7D0D0412BA3DE0213B6602A8CA08696FFA99F3E80E5DB4B31A39C2B19EA0A6124AA968B19ED2C0E133FACAF6F57D154EE1303C72ACBD4EEF0B170D87858D1F5BDB0105F5103B6492F59F6D41E1C3E1A6CE4E46E98320BC4206D96F28E8F8D36C26319EA5D7A804E48CBA38D70C09C3F4F17EE9C422F6C6B387D040AFC160B7641856276F010DAF20F243E100A754D4553BD87B6FC51D1FB4F40625D2C24D5703FAB5C1CA38F11726221873A2651AD620C1E477BADE1B778A208ADEC00AB7F78CBD8C606B37337E898065573B34E6CFDFD1B27978AA104BFC235B4D71CA6EB3B2161592C408A9B07239BB468C235EF525F781DA00965898D8EEE409B72FE18CA205DC0ABCAF81863EBEB680781FFEDEB573CB1F6CC14195B1EBFE08995893FF1A24D3970DDBF4C25CB645FBD04A7B28E8E1038CBFC6CBB31E29977801C7B7A724BAD9632D449B42907E6DA5332B9899A35119B7910BC47CCA34D3910F8494CF4236EC8D3042726F3FFA42CA24D391058F026FA93B4099748E61DADA24D391054159202C969425CAC1CBEB8A399E7B2D1A61C08AA09498144CE790EAE092A27807C35107A0A49CDBB446FC2D7140AB588ABF99B5EF36B6B3075408D446AC2C722E6972A3A592ED23C2E587261876CC2CAA88FD0A69CA037B266E6DD98D89AF073234BFCA304FF6206C15FC46452198DD59ECFA11B809FF929F9A552FC256ACFE69C1A54AC287842F8CC52A96D68B339811EA779132FE65B9A77E536C11BF76B9ECBF7E334075EA60F4352592C2255FB5F68ACC0AF957035BA4D14EA92941CDAF24F6144DB0FC9DFBDC53A2D6569359DDE87B68291E8CF2A2E89FEB0C5E1EFA1700578420FD03E5986F638B64D90447FDC7549F4E7F54612BBC1D148A2B7981A49EC269F88749BD535FBBF6EB3F6E8917852A9BF22732553EE10F3BD0000000049454E44AE426082, 6)
INSERT [dbo].[MenuApp] ([ID], [MenuTag], [MenuText], [FormName], [IDParentMenu], [IconMenu], [OrderSort]) VALUES (43, N'Group', N'Group', N'FormGroupLevel', 1, 0x89504E470D0A1A0A0000000D4948445200000018000000180806000000E0773DF80000000467414D410000B18F0BFC61050000016E49444154484BCDD5314B846018C0714FC3A236C7F6C6D6863E43CADD9837049151E0E07D839696FA0E2244144535B4C68938E92C4435A477D3E122A4D141698FBD0F479D39DCFB0AF587E3501F7E2FE88B727F9A24492DD3340F0CC358C053CD258A225714C535FCCAEE7BBDDE3C5E6A2640EF883DE949D7F545BCCC569AA6B7884EF7A8699A8863F4C1024B08FE56D8ED76D917C9B2AC5CE49D9895069D4E87FD990C87C365C0DE885929926599FD990441B0025846CC4AA1A228EC8BF8BEBF0AD80B312B3DB7DB6DF6DBE5BAEE1A60758B84AAAACEE1287DB66DAF03F64ACC4A0F38465FBFDFDF01E883783F1B8FC737384697E338FBE0E484AB74896374799EB707481D7ECEF37C0B47670FB6E92E2075F829BC14791C9DBD288AB601A9C32D261CDE475B80D4E1278220D0DF16C037119A2E87DD728563F4C102472546CC497992246CBBE57B001E96E8170DFF711C9FE1A566C24FE671898F46A30B3CDD6CF0D1E72CCBDAC0C3FF18C77D021ADE2D75DE3971BB0000000049454E44AE426082, 2)
SET IDENTITY_INSERT [dbo].[MenuApp] OFF
SET IDENTITY_INSERT [dbo].[RoleGroupLevel] ON 

INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (34, 9, 18, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (35, 13, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (36, 15, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (39, 16, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (50, 10, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (52, 11, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (53, 7, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (54, 8, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (67, 26, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (68, 27, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (69, 28, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (75, 32, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (87, 33, 18, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (90, 37, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (101, 38, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (102, 41, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (104, 29, 18, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (105, 29, 19, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (106, 37, 19, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (107, 26, 19, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (108, 15, 19, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[RoleGroupLevel] ([id], [id_role], [id_group_level], [isView], [isAdd], [isEdit], [isDelete], [isPrint], [isCustom]) VALUES (109, 9, 19, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[RoleGroupLevel] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (7, N'Sistem Admin', N'Akses Menu Sistem Admin', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (8, N'User', N'Akses Menu Sistem Admin>User', 1, 1, 1, 1, 1, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (9, N'Master Group', N'Akses Menu Master Data>Group', 1, 1, 1, 1, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (10, N'User Access', N'Akses Menu Sistem Admin>User Access', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (11, N'Role', N'Akses Menu Master Data>Role', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (13, N'Group', N'Akses Menu Sistem Admin>Group', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (15, N'Master Data', N'Akses Menu Master Data', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (16, N'Setting', N'Akses Menu Setting', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (26, N'Log', N'Akses Menu Log', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (27, N'Akun', N'Akses Menu Setting>Akun', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (28, N'Tema', N'Akses Menu Setting>Tema', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (29, N'Chatting', N'Akses Menu Chatting', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (32, N'UI', N'Akses Menu Setting>UI', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (33, N'Menu', N'Akses Menu Master Data>Menu', 1, 1, 1, 1, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (37, N'Error Report', N'Akses Menu Error Report', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (38, N'Role Group', N'Akses Menu Sistem Admin>Group>Role Group', 1, 0, 0, 0, 0, 0)
INSERT [dbo].[Roles] ([id], [name], [remark], [AccessView], [AccessAdd], [AccessEdit], [AccessDelete], [AccessPrint], [AccessCustom]) VALUES (41, N'User Group', N'Akses Menu Sistem Admin>User>User Group', 1, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[Roles] OFF
SET IDENTITY_INSERT [dbo].[UserGroupLevel] ON 

INSERT [dbo].[UserGroupLevel] ([id], [id_user], [id_group_level]) VALUES (83, 16, 18)
INSERT [dbo].[UserGroupLevel] ([id], [id_user], [id_group_level]) VALUES (88, 17, 18)
INSERT [dbo].[UserGroupLevel] ([id], [id_user], [id_group_level]) VALUES (89, 17, 19)
INSERT [dbo].[UserGroupLevel] ([id], [id_user], [id_group_level]) VALUES (91, 16, 19)
SET IDENTITY_INSERT [dbo].[UserGroupLevel] OFF
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (67, 16, 26, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (69, 16, 15, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (74, 16, 16, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (75, 16, 7, 1, 0, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (76, 16, 10, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (77, 16, 9, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (78, 16, 13, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (79, 16, 11, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (81, 16, 8, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (90, 16, 27, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (91, 16, 28, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (92, 16, 29, 1, 1, 1, 1, 1, 1000)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (94, 16, 32, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (103, 16, 33, 1, 1, 1, 1, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (112, 16, 37, 1, 1, 1, 1, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (183, 16, 38, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (184, 16, 41, 1, 0, 0, 0, 1, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (185, 17, 29, 1, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (186, 17, 37, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (187, 17, 26, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (188, 17, 15, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (189, 17, 9, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (190, 17, 33, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (191, 17, 11, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (192, 17, 16, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (193, 17, 27, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (194, 17, 28, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (195, 17, 32, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (196, 17, 7, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (197, 17, 13, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (198, 17, 38, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (199, 17, 8, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (200, 17, 10, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[UserRole] ([id], [id_user], [id_role], [allow_view], [allow_add], [allow_update], [allow_delete], [allow_print], [allow_custom_access]) VALUES (201, 17, 41, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[UserRole] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [userid], [name], [email], [nohp], [address], [avatar], [gender], [status], [online_offline], [password_noencrypt], [password], [token], [created_at], [updated_at]) VALUES (16, N'Admin', N'Admin', N'-', N'-', N'-', 0x89504E470D0A1A0A0000000D49484452000001000000010008060000005C72A8660000000467414D410000B18F0BFC6105000000097048597300000B1300000B1301009A9C18000020DD49444154785EED9D6DD01E5579C7751C3FF0211FFCC41766F864444D6BA3D251AC0C9321901720857152464C6D7452CD142C6D238946A906CD43432094A805CB9B4E30E32834388D0C56885522D55463CC84E814505A6D8D451B35BC84E8B3BDFEFBEC3E9CFBDCFFDD7B77EF7DDFFFCEFC669EE7BAF7E59C735DD7D9F3729DB32FB9F0EA8B448759BA35386DD52DC14263A5B1D6D860CC1877187B8CFDC611E309E39871DC78D6083C20C36F3807E7E21A5C8B7BE05EDB0DDC1BCFC0B316E1D92C4DA23B50A1681791932F36AE30E0DCBB0D38279CD577E4BA411A9016A40969431A17AB72E80654289AC39C678171AE81B72D9C0A6FE2530673BE3683341F359007E405795AC0F22C9A830A458D5C1F9C6E8EB1DAD8691C34BAE8EC5941DE9047E47535F24ECB44D406158AEA889AF3E843EF30F076678E32245006288B95EA36D40F158A7259BE2D38C30C7CBDB1D7600370620E940DCA683DCA8C95A528172A14D3B3627B70A61932FABE18209B3598C18B64506628BB0D284B56C6627AA85014C30CF51566B078D3CBE9CB25AE0CD6A38C59D98B6250A1C88E19E44BCD30971818ED3E69300316E5813246592F41D9339D88EC50A1C8C0DCE8FD26E3718319AAA81E94FD26CD2614870A4532667008C8D965F479BAAE6B4017D0C962A633910C158A51A2663EA6EEF619CC00457B808E56AA7B900D2A14732CBF2178B9191362DFE3F97A0DECB59F5847D0D95AE890E956CC4185432772FC75C68F226312DD053A5CA78A80438543256AEA63318B06F6FA07747A85BA06A350E11031E358661C8E8C45F417E87819B38121428543C28C016BE9117ECA8C45F417E87C21B38921418543C09A8288DAC326170ADE192ED0FD76D802B3912140857D26EAE76380AF0D9B698876005B5837C4F1012AEC2BA66434F735972F92806D0CAA5B40857DE3E21DC1CB4CB19B0D2DC51593808D6C86CD305BEA1B54D8274C9908DDD5E8BEC80B6CE66C66537D820AFB40F4D6DF6228665F1405B6B3A5CFAD012AEC3AA634F4F50F444A14625A604BBD1C1BA0C22E638A5A639C8814274459C0A6D6329BEB3254D8454C39D84E1B4B4299F284280BD8586FB637A7C2AE610A41931F7BD03385095136B0B55E7409A8B04B9822B0A7BE9AFCA26E6073AB994D76092AEC02D1283F3E45A535FAA229607B335D9E25A0C2B663858EFEBE16F088B6005BECE4B80015B6991573FBED2BB047B48DC3B04D66B36D860ADB8A15F2D98616F1883682EE006CB353D18354D846AC60B1618706FB44DB818D7666C3112A6C1B56A008EE5148AFE80AB0D535CC96DB0615B6092BC8AB0C8DF48BAE019BBD8AD9749BA0C2B660058825BCAC7085E80A9B996DB7052A6C03567058C9C70A5488AEB185D9781BA0C2A6B10243800F2B4821BACA0CB3F5A6A1C226B182D29B5FF495D6B504A8B029AC80AEF50A4C88BE712DB3FDA6A0C226B082C1683F2B3021FA466B6607A8B06EAC40F0392E4DF589A1005BBF82F942DD50619D584120C24F1FE710430336BF8AF9449D50615D580120B65FE1BD62A8C0F61B5D3B408575B07C5B7086655E0B7BC4D039065F603E52075458359669ACE7D7925E21E6802F34B29F00155649F46DBE3D4EE68510E6134DEC2C448555621955A08F109CDA0385A8B02A2C832B0D4DF795CC253B4E05176CFE6170EE7B1E08DE74F91DC1E2F33F14FCFE5BFF3238EB757F12BCEAB59706AF7CE505F32C7CD58A50FEDAB3D786E7E0DC3FBC6C6770CE3B7605E75DF970B0F403478215334FD3E79401EE8DE7BCF1E26D611AF03C76DE40816FAC64BE531554580596316CDD7D3CCAA89892F3AF39143A3B9C184EED3A7919E09E70D0D79DF7FED059F12C54304BFEE6DB6165B3FCBA9F06176DFB7558F9B8E9820C2CFBC853611ADD4A09158FFF9C372CBB6EE47A11FA486D5B8E5361D92CDD1A9C6699D2A0DF94C0F9E08CFE5BBDCB2C7CF5C5C125379DA4F91D3087E133CC97CA860ACBC632A42FF614044D66BC41D9DBB32FA81B40D9C57CA96CA8B04C2C236BBD8C890CA0998DE6F1AB165E489DA64FA09BC0CA4054FF2D422A2C0BCB00FAFD8AF4CB011C1FFD65E6287DE58FDE751F2D0B11FA4EA5E301545806CB6F085E6E89D727BA33824135F4EF9983F41DCC40B032112107E04BCCC7CA800ACBC012AEF9FE0C60000C0E50C5487E57500B602295C50750E1B45882B1C847DB784F00D364986A634E31241017C0CA47CC035FAA64D110154E43D4F4D7945F0A78EB23F88639C310C1F4262B2731C2912ABA0254380D965035FD5358F6B73FD25BDF0365C2CA4A8C517A57800A8B62095C64A8E99F00A6BB10F8C29C60A860ECC38F261489C0B71631DF2B0A1516215AE5B7DF49AC888081ABC9CF4128332B3391C87EF81AF3C1225061112C61EBBC840A0371F188A767C63F7410E4A4198042AC633E58042ACC8BD548AFB04469771F0F84F12E7AF37BA9F18B3910FFC0CA4EA4720C3EC77C312F5498174BD00E2F818307ABE15EB3F80A6AF4620EB4003020AA4AA0103B982FE6850AF3600941B8AF06FE1CE0FC7D5EBC533658DDA8A9C0DCC0E7A60E13A6C23C5822F63A891A3C72FEE2282438377B994FE6810AB36209C09EFE2C6183047D7E35FBA7030BA12EDA7E8296AFA02C63BE99152ACC4234EDA788BF088CF62BC0A71C30705AE5B6643DE3F034D3825498057BF01A2F218305F3FC98CF66C62C8A816E94220433B386F96816A8701251BCFF935E2206CB5097F1560D0607B55B50269E2CBA4E800A27610F54D04F04C27B99F18A7240E834564DB2B21723140A0EA2C234F0F1027B98DEFE0646FC15DB5F3DAA0432F164910F8B50611AF620EDF167A0DFAF28BFFA4025A0EEC04472EF214885494423FF47BC870E12C4B0334315D58131010D0CA67224EF8C001526610FD0BCBF81292A35FD9B0171169A224C25575C0015266137DFE73D6C9068696FB3A0EBA58F8924B28FF96E1254C8B01B2FF61E3448B07065C81B78B6054CBD32FD8890C5CC871954C8B09BEAEB3E86E6FCDB833E289248E6AF0A51E118D707A7DB4D07BFE22FECFBEBEDDF1A300EA3A5C49453F059EACB1E54E86337DCE43D609060B51A3344D11CDA522C914DCC977DA8D0259AFA7BDCBBF9E0C0BCBF96F9B6136D2B46793CCB942015BAD88D9678371E24D8B082199F681EC407686A90B284F9B40B15BAD84D767B371D241AFC6B379A15A0EC663EED428531D684C0669F27BD9B0E1235FFDB0FD66630DD0D9893F061E6DB315418633758EFDD709060210A3338D12EDEB0EC3AAABF81B39EF9760C15C6D8C5FAD087F1A6CBEFA00627DA875A0163A446065221B0A6C39976F1AC77B341A20F7B74078469331D0E98D9B498002A0476E106EF4683450B7FBA036604B4A9E81857311F075408EC2235FF0D342999A189F6A210E131F6331F0754B87C5B70865DA4E6BF71DE950F532313ED055B8B335D0E9859F834F3F53101B00B34FA1FA1F0DFEE81F51AD8A69DE973C0D0D9803101B093F778170F1605007513B4DC983E07CC1EE6EB638268CBEF13DEC58305CD496660A2DD6836608C136CEBF0917F809DA8D87F076DFC590EEBDFF1EEF06BC0ECB72AC0579A983E07CED8DA80917F809DB4DDBB68D0E85B7FD373DE5B2E0D9E3D7857F0D5CF6C0DCE39FB127A4E15681C608CEDBEBF8FFC03EC247DEFCF01F3CACCB844766EFBD8C6E0E4F7EF0E796ADFA7823F5E76393DAF6CF42D81310EFBFE3EF24FB4F30FBB70B02808683A5EF77B2B82FFFDE6A7E72B00F0EBEFDC115CF39EEABB56DA27601C3F2A70A402B01356FB170C1D6658223BB77C78C388F3BBECBAF143C16B5EBD8C5E372D186FD0402065B5EBF37E05B0D33B79F030E312D9407FFFFFBE7D3B75FE986F7D617B65E3025A1D48D9E9FABC5F011CF44E1E3CCCB04436EEFF878F52A7F7F99F6FDC1AFCE9656BE83DA641FB05520EBA3EEF3AFF0263F03BFFFA30C31293C1B41F73F624304B70FDFBAFA6F72A0A6670984E070E7C7C01AB00CE754E1211CCB04432E87B63E00F6F75E6E89340AB01D7B37BE705BB38319D8A17E301DC0A40CB7F09CCB0443A98EF67CE9D951F3C704B70C1796FA3F7CE03A670994E45B0815500DAFC93C00C4B249336EA9F070C1EA21BC19E9107A653F1E266A16E0570D43B4918CCA804E7CFDFFEAEB02FCF1CBA1087EE0E3EF9916BA60A21663A15C1D1910A60E9D6E034136A0090C08C4A8CF3B6956F9F38E55794AFDF737DE1A942A653119C82CFCF570026D0977F13604625465979FEEAB168BFB2291A42CC742A42C22F08C715C015DE8F228219950BE2DC997C28E0CD5FB5F3C79CF8EE9DB94388994E45C81AB70298F17E1411CCA85C6098E8A7B2DFFA0E8277AA6AF6A791278498E95484CCB815806600126046E5E21A659DEBDD9B066F622CEA711DB34E0EFED34DE13263963617A6531112CE04C415804280136046E5E21AE53483555D0195DC9D331F18C97753A0EBC1D2E8C2742A42C290E0B80238EEFD28229851B9F84689C12AF48BD9B95D076F5C2CDEF1F3DC242C9D2E4CA722E4785801441F006527088319950B334ACC85635CA0AAA5AE4D80267F13FDFD49B0B4BA309D8A39E0FB78FB2FF27F102FC28CCA8519650C425AAB58E5562708C945D786E5AF0DB034BB309D8A7916A10258E9098503332A1766943E888DC75C39BBBEAD60410E5A31987A63796A0B2CED2E4CA7629E95A800D67A42E1C08CCA85192503DD02AC746B7B4500C7C7B2DCBAE6F6A785E5C185E954CCB31615C0664F281C9851B930A34CE5D0DC6C01E2E6DB346D88D90B2CE429BA8CB729585E5C984EC53C9B5101681BB0149851B930A3CC0A660CD0CC6EAA55800A086314689994BA88A74658BE5C984EC53C3B50012808280566542ECC288B800143540670C82A670F706F3C03814B5D7BDB33581E5D984EC53CBB5001ECF584C28119950B33CA69C1741BBA096892634D3CE6DF8B7617702DEE817BE19E4D46EF5501CBB30BD3A998672F2A80FD9E503830A37261465905705CB41230A380263B1621C1A9316007D07A800C6F769C8373DB386F5F364C272E4CA7629EFDA800F425A0149851B930A3AC944311ECB701C274E2C2742AE6398C0AE0294F281C9851B930A314F5C174E2C2742AE6790A15C0314F281C9851B930A314F5C174E2C2742AE639860A400B8152708D0973E53357BE377868E707831F7D716BF08B2FDF408D52D4077470E49EEB429D4037FE6A4CA65331CF715400273CA170881DFF0B5B370427BEBA2378F6A19B46604629EAC3D70774045DC51501D3A998E7042A00F68388C09C39DE32BEA1C530A314F5C17402A033E88EE954BC882A80143E75CFF7E85BDF8519A5A80FA69318E80E3A64BA1573A80248E0A3773D31D1F90133CA32C02A3CECBC83CD45B04007E06FCCF3B771851ED284B4F9E9451EAA4C2FD3890B74085D321D0B55009477DFFA9BE017FFF2096A503ECC28A7056B04D2D607E0379CC3AE6D8226D3CB74E2035D42A74CD74347838084AFDEF7656A480C6694D38088BF2C8B83B0477E1BC27A91862CFBF5234F55A497E984019D325D0F9C701050D3800E78536469FAC730A39C063499990331DAB03967D3E9653A6140A76A058C114E032A10C8E1F6CF1DA006940433CA69C8B3A128CE65F7A893A6D3CB74920474CB743E60C2402085023B7CEBFE7BA9F124C18C721AF22C05C6B9EC1E75D2747A994E92806E99CE074C180AACC5400E3F7DF0D3D478926046390D791C0A23EDEC1E75D2747A994E92806E99CE074CB81848CB811DF2F4FF0133CA695017201F4C274940B74CE703265C0EAC0D411C9AAE003408980FA6932454018C116E08A22DC11C9AEE0260AA0C7BF1330772A96A5A2D2F484396694BE4A9C96940A02EC018E19660DA14D4A1E94140A040A0EC309D24A141C031C24D41B52DB8C39D9FFB36359E2498514ECDA1B9372B9ACCE837D7195A5B94A4D065C8AA6CA9309D2401DD329D0F98705B707D18C401C122CC7892604629EA83E9240905028D117E18449F06F368321458E483E984A150604AF869307D1CD4036F8A26170389EC309DF8683150228BF479F004FEEE333FA0C6E4C38C52D407D3890F74C9743C74C2CF835F78F5456805684110019B49308372614629EA83E9C4451B8224721CBE1F570007BD1F4504369348EB0E30A314F5C17402A0336D0492CA41B7025030500AE83F260D0C32A314F5E1EB03D17ED095FAFC13D9ED560033DE8F8200A3C25C32024A10550663634629EA033A802EA013E8468E9F9919B70258E3FD2832C28C52D407D389C8C41AB70258ECFD2832C28C52D407D389C8C4E2F90A60E9D6E03413CC7A27880C30A314F5C1742226720A3E3F5F0144AD80A3DE492203CC28453D3C73E8B3542762224763BF772B00CD0414E05707EFA1C629AAE797DFDD4D75222612CE00F815C006EF24918163FFFE796A9CA2620EDD1D963DD38998C80656019CEB9D2432F01F8F7E891BA8A81C943DD38998C8B9631540341078D23B514CE0D1AF3D448D53540FCA9EE944A472321E001CA90080FDA80D4273F2A507FE8D1A675BF123E77CD8356D0565CF742252D9EFFABC5F016CF74E1613B8F5DEA3D438DBCA738F7C923A3EC06FEC9AB682B2673A11A96C777DDEAF005679278B097CE0B33FA3C6D95ABE7727757E80DFE8352D0565CF74225259E5FAFC480570E1F5C1E9E40291C2E59F7A811A67AB3147775B02E19BBF63CE8F5900943DD38948063EEEFAFC680560D849FA52504E3413503F9A0128C461DFDF47FE017692C60172D2B581C03EA001C0428CF4FFC1C83FC04E5AE25D242630B3FBC7D4484575A0CC992E442A4B7C7F1FF9072CBF2178B99D78C2BB50A480BE28E2D299A18AF24159ABFF9F9B13F06DDFDF47FE89B193F778178B092820A83E140054883DCCD7C704C04E5EEF5D2C26A06E407DA8F95F88F5CCD7C70460F9B6E00CBB40FB03E4E0B29DBF0B57A73183AD92E7BF737B70E2819B8313FFBC23786EFF6DF49C32C133F02C3C13CF66E75409CA1865CD74201299854F335F1F13C4D8450A0BCEC917F71EA0465B25CF7CE596E037F7DF38CFF307FE919E5706B8B7FB2C3C9B9D57251AFD2FC448F8AF0B1502BB48CB8373820D29EB1E0CF42B00BC992B09EAB17BE2DEEEB3EAAE0050B6EFBDFDD7B4EC452A57311F075408566C0FCEB40BD50DC8C9BE87FE951A6F553CFFADDB469C72DE310FF1F30B61F7F22B1A50656B8381B265652E5299F5A3FF5CA830C62E563720277843D5DD0A78F6E19D63CE19560265B404EC1ECCF99FFBDA27F8F915A1B77F61F631DF8EA1C218BB58B3010578F02B8F5023AE0C7B43FBCD73100ED44DF196C6B5ECBEA5B73032A0BE7F61E8E87F0C15C6441F0ED5262139F9B35B9FAD7FAF40D2478F410B21CF883DCE65AD0A80675432C69002CA1265CACA5AA472123ECC7C3B860A5DEC26DA2CB40077ED394C8DB952129AEB31F80D2BFFC256019C186F71607F4386DF265D5FB7F30394252B633191F9CD3F93A04217BB89D606140073D58DAC12348746FF9C39F034847DFE9A9BFD0065A879FFC28CC5FEFB50A18B35215E6A377ADCBBB1C8401303823149FDF7BC4C3B8E300D28BBF7DDF94B5AB662228FC377994FBB50A18FDD6C9377739191A6B70CC334615AB33E095C836BD93DEB424DFFA9D8C47CD9870AC798DB29E894F7009191BA630328D67747182F06F7F05647386FECEC71682F7E0BC3891BE8E78F605D0D2DF8998A536973FF2E54C8B09BEEF21E223282A5ABDA35283B282B2DF79D8A5DCC871954C8B09BEA0BC25380692C7D456832282305FC4C4DF8E5DF2C50611276E37DDE83440EFEFAAEA71B5931D81530DF8F3262652732931AF9E7438549D8CD97790F1339B9E6333FD70745092813940D2B33918B65CC7793A0C224A229C123DE03454E60E86A09BC089C5F7BFC97C2912C537F2E5498863D64ADF7505100CC6F6B4C60AECFAFB9FED258CB7C360D2A4CE3E21DC1CBEC414F7A0F1605C0FE01439E1D40DE5106AC6C446E9E649B7E4E820A27610F5BE73D5C1404D35DAD8813A819E459537DA5B28EF9EA24A87012D1D6E16A05940822069B0A1BAE13E4511FF52C9D426F7F408559B087AEF11221A6047DE13E77099037F5F72B610DF3D12C506116A219017D47B064B0F20D31F07D6A0D60941F79D2AABE4A389C77E4DF850AB3620F575C40456070AC0F6303C88306FA2A25D7BCBF0F15E6C112B0D74B9028113499C38AE048B78287B09847517D95B397F9641EA8300F96888586560A96CCC53707C1F91F0F82B77C3008B6DF1B04B3A79E0B7EFB93EFB6BB22B0B49D7AE2A160F6995F846946DA9107E485E5514C057C6E21F3C93C50615E2C213B9C848982C44EFFE68D41B0F8CA20F883BF98E3B1A782178FD9D9E0774F3F1EBCF0C3FBB8133600D2F2DB9F3D165652F18134C7E9475E90275506A5B283F9625EA8302F2BE6360F3DE6255064E4C26D736F4BD7E963966C8A3C2A3EAC02880FBC6DC34D3B9A58BF8F7D04EDD94843D2B1D4F2E4E70779445E916756162213C7E073CC17F3428545B0442938280778132EF96810BCF1AFC69DC465D39D913791E38527BE113CFBD04D73ECBB7974C34FE6B4D300878F360EC5B3E2E7220D4907D2CEF21483BCA30CD42AC84DA1A01F061516219A16D4874426B0F2A62038F7C341F086F771A7F0B9675FE44DE418A9007CA20A21AC14EC4D0DE70DB70647E5E06FEE19ED0C1C3AB99D139E6BD7C4D7BB0EEF93560120ED2C4F3E280B9409CA8695991861FF34D37E3E5458144BDC2243038204187752333F8D478E44DE448ED40AA026D22A00A49DE52989B87BA08A2011F8D622E67B45A1C269B0046E71123C78D0BCC5DB2DAFE3C7FCE7CF236F2247DB2B00A49DE56912282B9499BA0663CC309F9B062A9C86689DC0E0F70C88FBF8451D3FE699E7236F2247DB2B00A49DE5292B283B8D11CC73A468BC7F1A54382D96D8B38DC176052E98993CB89795B4A3ED15000E96A7BCA02C51A6ACAC07027CE96CE66BD342856560091E5C5720EEE733232E4ADA81C020E694758234241D2F9CE2792ACA80C707B6301F2B032A2C83A82B70C0CB486F41904BD691FD3C2476016667C3E01BE694758234241DBF7A86E7691A50C6E816301DF494035534FD63A8B02C2CF108133EE164A677A07F8A283766AC65903608F8BBE3FF4D9DB24E9086A4A3E820601650E603181B80EF4C1DEE9B0615968965A0B77B08A25F5AC55BDF256D1A10AD007CCD8739662DD8B3DDC844FFC83B0D9817947DCFC70672EFF197172A2C1BCB48EF3E318E662833CAB2490B04C271F27BF771E7AC013C3BEDC81A08342D3DED1264FEBACF345061D92CDD1A9C6619EAC5E6215537F97DD242817134390E90D6FFC7312914B84C7AD625380C9F61BE543654580596298C071C7732D93930025DD6F45E56C61603F98735C1C38F7E1207AD123C33ADF98F832D06AA12E8A607B304F0914AFBFD2E54581596B155C66C94D14E81D56B55F7F79318590E4C8E26A603D3A6FF70B8CB81EB043AEAF04A43F8C62AE63B554185556219EC5C7C00069AA68DE89B066CAE917AD89BF8F903F75047AD023C6BD2DB1F696679A903E8AAA3838395CDF727418555127D58A433DB88617EBF49E707E759FF164135690776E179EE6B9FA00E5B2678069E957620AD4833CB4B5D4067D01DD3694BD90BDF603E532554583596D90546EB07056140CCB89A60D26C000EEC14C49CB634F6DD1C3E63D251D7E87F163A5209C01716305FA91A2AAC8315DB83332DD3ADDD45A84DCE0F30A096B630283EC24A2065FD7E611EDE99C9F991C6BA07FF26D1F24A00BBFB9CC97CA40EA8B02E2CF35834D4BA48C1A6FBFC49FCFDFD91974D38109D57E6CC00EE9516F1E71E48234B7B93B4784C00B65FC9229FAC50619D58016066A0352B07DBEAFC0023DC47FF2BF2B4090736E87CE1B107A943E701F77037FB4C3B90B6A6664A26019DB66C7600365FEB883F830AEBC60A029F196B7C7A1073C86D75FE984B3E92AD2B101F18B00B2B823CDD023B3774FC09837DEE8134216D2CCD6D0195534BE20460EB853FE7552654D8045620573905543B8822AB3BC8A72857DF661E37611A6EFE88CE0BBF2BF0B3C742C7C634DEFC5E7F46B86FA0C9F01BCEC9FAC69F3FEC1948134B6BDB808E5B10317815F38126A0C2A6B082B9D62BA8DAA833BCB70C3EB63B72BE161C480B4B635B81AE990DD4C4B5CCF69B820A9BC40AA8F64021EC3FC70CA5ED849540D6964015873DBB6BCE1F039D335BA898DA037D2641854D630535E3155C6560D08F19485740D33BCF984059079ED995667F1235CF0C94BEA1671950611BB002ABBC258001A1B68E5AE701836F596707CA387EF89320B8EC3A9E962E51E3A060EBDEFC3154D816ACE0367B05592A5DEBF7A70163C61CFCA490E1690EDC1BCFE843A51953C378C06666DB6D810ADB84152066074A9F22AC6B438FBA41141E4271CBEC16E05EB867DB22FCCAA2A20D4560B3AD19ED4F820ADB861524E2044A0B16EAC27CFFB460310E56E44D5A4A9C76E05ADCA3E9853D55035B28B92B005B6DC53CFF24A8B08D5881AE344A091BEE53D33F0BD85404BBF3E02D8E7DFA7E7C6C6EC75E34E901FE860CBFE11C9C8B6BD8BDFA4A895D01D8E84A66C36D840ADB8A152CD60E4CB580A8EBA3FEA23A4A9815806D361ADB9F172A6C33D12AC2C24B89BB12ED27EA07B6C16C2623879B5CD557142A6C3B56D8D84F20F7A6227D1DF813E551704010B6D8C87AFE69A1C22E10ED2C8480A14C330488FFEED3F495A806D8488EB502B0BD992676F2290B2AEC12A680D5C6C4C141BDFD455632B6026073AB994D76092AEC1AA68845C6D1483163E8ED2FF290A115005B5BC46CB16B5061173185605C6057A4A011F4F61779496905C0C63AD9DF6750619731E5E05B84235D028DFC8BBC901901D854E5DFEAAB1B2AEC3AA6287C8528FC34B9E6FD45519CB800D8526D5FEBA9132AEC03F8A6BA296DCB399B82534CB9424CE29C8D6148EF962ABFCFDF3454D8274C91AF37BEEF2A56880CC0665ECF6CAA4F5061DF400D6ECADC689C8C942B4412B0918D7D7EEBBB50615F31C59E657C3D52B4103EB08DB398EDF4152AEC332BB6072F3525AF379E8E942E046C613D6C83D94C9FA1C22160CA7E8529FD4643DD82E102DDDF085B60363204A870489801A05BF0606410623840E7836AEE33A8708898312C37345BD07FA0E3E5CC068608150E15ACEA32E378A7F144642CA23F40A7EFECF2CABD2AA0C2A1134D1BA2227832321ED15DA0C3770E655A2F2F5428E6702A82C7226312DD013A93E34F800AC528D1D421C6083458D87EA0A3E5439CD22B02158A64CCB8105A7CB7A1E9C3F6005D4027BD0FDD2D1B2A1419B83E38DD0C0EE1C51A306C0E94FD46E882EA484C840A453ECC08D13DF8BCA15641F5A08C51D66AE69700158A6244D1850833DE6FCC1ACC80457E509628D3F57ADB970B158A62B86F24FBFB4C335874111E8D0C9819B648066586B2DB88B274CB599407158A7259BE2D38C30C192D038C50AB9B900CCA0665B41E65C6CA52940B158AEA58754BB0C00C1C63065888A4F882B93240592C47D9B03213D54185A27AE6BB0B73B30997464EF04DA3CF2D04E40DCD7AE4F552B73FEF769F447D50A1688EA55B83D3CC39DE6A60FC00A3DD784376710C016946DA9107E4E5ADC81BCBB3680E2A14ED22AA14108084B0E48F1B702AB416DAB0A909D280B4204D481BD2F87A397B37A042D11DA2CA017B1A605C01CE87B72D9AD8888C8353629B2BBC8911340367056E8B027FA3691EFF86C5333817D7E05ADC03F7C23D716F3C03CF3A4B4EDE752E7AC9FF0336BAE690CDF7CADC0000000049454E44AE426082, N'M', 1, 0, N'123', N'202CB962AC59075B964B07152D234B70', N'-', CAST(N'2019-10-02 14:45:55.550' AS DateTime), CAST(N'2019-10-10 13:49:25.800' AS DateTime))
INSERT [dbo].[Users] ([id], [userid], [name], [email], [nohp], [address], [avatar], [gender], [status], [online_offline], [password_noencrypt], [password], [token], [created_at], [updated_at]) VALUES (17, N'IT009', N'Jay', N'-', N'-', N'-', 0x89504E470D0A1A0A0000000D49484452000001000000010008060000005C72A8660000000467414D410000B18F0BFC6105000000097048597300000B1300000B1301009A9C18000020DD49444154785EED9D6DD01E5579C7751C3FF0211FFCC41766F864444D6BA3D251AC0C9321901720857152464C6D7452CD142C6D238946A906CD43432094A805CB9B4E30E32834388D0C56885522D55463CC84E814505A6D8D451B35BC84E8B3BDFEFBEC3E9CFBDCFFDD7B77EF7DDFFFCEFC669EE7BAF7E59C735DD7D9F3729DB32FB9F0EA8B448759BA35386DD52DC14263A5B1D6D860CC1877187B8CFDC611E309E39871DC78D6083C20C36F3807E7E21A5C8B7BE05EDB0DDC1BCFC0B316E1D92C4DA23B50A1681791932F36AE30E0DCBB0D38279CD577E4BA411A9016A40969431A17AB72E80654289AC39C678171AE81B72D9C0A6FE2530673BE3683341F359007E405795AC0F22C9A830A458D5C1F9C6E8EB1DAD8691C34BAE8EC5941DE9047E47535F24ECB44D406158AEA889AF3E843EF30F076678E32245006288B95EA36D40F158A7259BE2D38C30C7CBDB1D7600370620E940DCA683DCA8C95A528172A14D3B3627B70A61932FABE18209B3598C18B64506628BB0D284B56C6627AA85014C30CF51566B078D3CBE9CB25AE0CD6A38C59D98B6250A1C88E19E44BCD30971818ED3E69300316E5813246592F41D9339D88EC50A1C8C0DCE8FD26E3718319AAA81E94FD26CD2614870A4532667008C8D965F479BAAE6B4017D0C962A633910C158A51A2663EA6EEF619CC00457B808E56AA7B900D2A14732CBF2178B9191362DFE3F97A0DECB59F5847D0D95AE890E956CC4185432772FC75C68F226312DD053A5CA78A80438543256AEA63318B06F6FA07747A85BA06A350E11031E358661C8E8C45F417E87819B38121428543C28C016BE9117ECA8C45F417E87C21B38921418543C09A8288DAC326170ADE192ED0FD76D802B3912140857D26EAE76380AF0D9B698876005B5837C4F1012AEC2BA66434F735972F92806D0CAA5B40857DE3E21DC1CB4CB19B0D2DC51593808D6C86CD305BEA1B54D8274C9908DDD5E8BEC80B6CE66C66537D820AFB40F4D6DF6228665F1405B6B3A5CFAD012AEC3AA634F4F50F444A14625A604BBD1C1BA0C22E638A5A639C8814274459C0A6D6329BEB3254D8454C39D84E1B4B4299F284280BD8586FB637A7C2AE610A41931F7BD03385095136B0B55E7409A8B04B9822B0A7BE9AFCA26E6073AB994D76092AEC02D1283F3E45A535FAA229607B335D9E25A0C2B663858EFEBE16F088B6005BECE4B80015B6991573FBED2BB047B48DC3B04D66B36D860ADB8A15F2D98616F1883682EE006CB353D18354D846AC60B1618706FB44DB818D7666C3112A6C1B56A008EE5148AFE80AB0D535CC96DB0615B6092BC8AB0C8DF48BAE019BBD8AD9749BA0C2B660058825BCAC7085E80A9B996DB7052A6C03567058C9C70A5488AEB185D9781BA0C2A6B10243800F2B4821BACA0CB3F5A6A1C226B182D29B5FF495D6B504A8B029AC80AEF50A4C88BE712DB3FDA6A0C226B082C1683F2B3021FA466B6607A8B06EAC40F0392E4DF589A1005BBF82F942DD50619D584120C24F1FE710430336BF8AF9449D50615D580120B65FE1BD62A8C0F61B5D3B408575B07C5B7086655E0B7BC4D039065F603E52075458359669ACE7D7925E21E6802F34B29F00155649F46DBE3D4EE68510E6134DEC2C448555621955A08F109CDA0385A8B02A2C832B0D4DF795CC253B4E05176CFE6170EE7B1E08DE74F91DC1E2F33F14FCFE5BFF3238EB757F12BCEAB59706AF7CE505F32C7CD58A50FEDAB3D786E7E0DC3FBC6C6770CE3B7605E75DF970B0F403478215334FD3E79401EE8DE7BCF1E26D611AF03C76DE40816FAC64BE531554580596316CDD7D3CCAA89892F3AF39143A3B9C184EED3A7919E09E70D0D79DF7FED059F12C54304BFEE6DB6165B3FCBA9F06176DFB7558F9B8E9820C2CFBC853611ADD4A09158FFF9C372CBB6EE47A11FA486D5B8E5361D92CDD1A9C6699D2A0DF94C0F9E08CFE5BBDCB2C7CF5C5C125379DA4F91D3087E133CC97CA860ACBC632A42FF614044D66BC41D9DBB32FA81B40D9C57CA96CA8B04C2C236BBD8C890CA0998DE6F1AB165E489DA64FA09BC0CA4054FF2D422A2C0BCB00FAFD8AF4CB011C1FFD65E6287DE58FDE751F2D0B11FA4EA5E301545806CB6F085E6E89D727BA33824135F4EF9983F41DCC40B032112107E04BCCC7CA800ACBC012AEF9FE0C60000C0E50C5487E57500B602295C50750E1B45882B1C847DB784F00D364986A634E31241017C0CA47CC035FAA64D110154E43D4F4D7945F0A78EB23F88639C310C1F4262B2731C2912ABA0254380D965035FD5358F6B73FD25BDF0365C2CA4A8C517A57800A8B62095C64A8E99F00A6BB10F8C29C60A860ECC38F261489C0B71631DF2B0A1516215AE5B7DF49AC888081ABC9CF4128332B3391C87EF81AF3C1225061112C61EBBC840A0371F188A767C63F7410E4A4198042AC633E58042ACC8BD548AFB04469771F0F84F12E7AF37BA9F18B3910FFC0CA4EA4720C3EC77C312F5498174BD00E2F818307ABE15EB3F80A6AF4620EB4003020AA4AA0103B982FE6850AF3600941B8AF06FE1CE0FC7D5EBC533658DDA8A9C0DCC0E7A60E13A6C23C5822F63A891A3C72FEE2282438377B994FE6810AB36209C09EFE2C6183047D7E35FBA7030BA12EDA7E8296AFA02C63BE99152ACC4234EDA788BF088CF62BC0A71C30705AE5B6643DE3F034D3825498057BF01A2F218305F3FC98CF66C62C8A816E94220433B386F96816A8701251BCFF935E2206CB5097F1560D0607B55B50269E2CBA4E800A27610F54D04F04C27B99F18A7240E834564DB2B21723140A0EA2C234F0F1027B98DEFE0646FC15DB5F3DAA0432F164910F8B50611AF620EDF167A0DFAF28BFFA4025A0EEC04472EF214885494423FF47BC870E12C4B0334315D58131010D0CA67224EF8C001526610FD0BCBF81292A35FD9B0171169A224C25575C0015266137DFE73D6C9068696FB3A0EBA58F8924B28FF96E1254C8B01B2FF61E3448B07065C81B78B6054CBD32FD8890C5CC871954C8B09BEAEB3E86E6FCDB833E289248E6AF0A51E118D707A7DB4D07BFE22FECFBEBEDDF1A300EA3A5C49453F059EACB1E54E86337DCE43D609060B51A3344D11CDA522C914DCC977DA8D0259AFA7BDCBBF9E0C0BCBF96F9B6136D2B46793CCB942015BAD88D9678371E24D8B082199F681EC407686A90B284F9B40B15BAD84D767B371D241AFC6B379A15A0EC663EED428531D684C0669F27BD9B0E1235FFDB0FD66630DD0D9893F061E6DB315418633758EFDD709060210A3338D12EDEB0EC3AAABF81B39EF9760C15C6D8C5FAD087F1A6CBEFA00627DA875A0163A446065221B0A6C39976F1AC77B341A20F7B74078469331D0E98D9B498002A0476E106EF4683450B7FBA036604B4A9E81857311F075408EC2235FF0D342999A189F6A210E131F6331F0754B87C5B70865DA4E6BF71DE950F532313ED055B8B335D0E9859F834F3F53101B00B34FA1FA1F0DFEE81F51AD8A69DE973C0D0D9803101B093F778170F1605007513B4DC983E07CC1EE6EB638268CBEF13DEC58305CD496660A2DD6836608C136CEBF0917F809DA8D87F076DFC590EEBDFF1EEF06BC0ECB72AC0579A983E07CED8DA80917F809DB4DDBB68D0E85B7FD373DE5B2E0D9E3D7857F0D5CF6C0DCE39FB127A4E15681C608CEDBEBF8FFC03EC247DEFCF01F3CACCB844766EFBD8C6E0E4F7EF0E796ADFA7823F5E76393DAF6CF42D81310EFBFE3EF24FB4F30FBB70B02808683A5EF77B2B82FFFDE6A7E72B00F0EBEFDC115CF39EEABB56DA27601C3F2A70A402B01356FB170C1D6658223BB77C78C388F3BBECBAF143C16B5EBD8C5E372D186FD0402065B5EBF37E05B0D33B79F030E312D9407FFFFFBE7D3B75FE986F7D617B65E3025A1D48D9E9FABC5F011CF44E1E3CCCB04436EEFF878F52A7F7F99F6FDC1AFCE9656BE83DA641FB05520EBA3EEF3AFF0263F03BFFFA30C31293C1B41F73F624304B70FDFBAFA6F72A0A6670984E070E7C7C01AB00CE754E1211CCB04432E87B63E00F6F75E6E89340AB01D7B37BE705BB38319D8A17E301DC0A40CB7F09CCB0443A98EF67CE9D951F3C704B70C1796FA3F7CE03A670994E45B0815500DAFC93C00C4B249336EA9F070C1EA21BC19E9107A653F1E266A16E0570D43B4918CCA804E7CFDFFEAEB02FCF1CBA1087EE0E3EF9916BA60A21663A15C1D1910A60E9D6E034136A0090C08C4A8CF3B6956F9F38E55794AFDF737DE1A942A653119C82CFCF570026D0977F13604625465979FEEAB168BFB2291A42CC742A42C22F08C715C015DE8F228219950BE2DC997C28E0CD5FB5F3C79CF8EE9DB94388994E45C81AB70298F17E1411CCA85C6098E8A7B2DFFA0E8277AA6AF6A791278498E95484CCB815806600126046E5E21A659DEBDD9B066F622CEA711DB34E0EFED34DE13263963617A6531112CE04C415804280136046E5E21AE53483555D0195DC9D331F18C97753A0EBC1D2E8C2742A42C290E0B80238EEFD28229851B9F84689C12AF48BD9B95D076F5C2CDEF1F3DC242C9D2E4CA722E4785801441F006527088319950B334ACC85635CA0AAA5AE4D80267F13FDFD49B0B4BA309D8A39E0FB78FB2FF27F102FC28CCA8519650C425AAB58E5562708C945D786E5AF0DB034BB309D8A7916A10258E9098503332A1766943E888DC75C39BBBEAD60410E5A31987A63796A0B2CED2E4CA7629E95A800D67A42E1C08CCA85192503DD02AC746B7B4500C7C7B2DCBAE6F6A785E5C185E954CCB31615C0664F281C9851B930A34CE5D0DC6C01E2E6DB346D88D90B2CE429BA8CB729585E5C984EC53C9B5101681BB0149851B930A3CC0A660CD0CC6EAA55800A086314689994BA88A74658BE5C984EC53C3B50012808280566542ECC288B800143540670C82A670F706F3C03814B5D7BDB33581E5D984EC53CBB5001ECF584C28119950B33CA69C1741BBA096892634D3CE6DF8B7617702DEE817BE19E4D46EF5501CBB30BD3A998672F2A80FD9E503830A37261465905705CB41230A380263B1621C1A9316007D07A800C6F769C8373DB386F5F364C272E4CA7629EFDA800F425A0149851B930A3AC944311ECB701C274E2C2742AE6398C0AE0294F281C9851B930A314F5C174E2C2742AE6790A15C0314F281C9851B930A314F5C174E2C2742AE639860A400B8152708D0973E53357BE377868E707831F7D716BF08B2FDF408D52D4077470E49EEB429D4037FE6A4CA65331CF715400273CA170881DFF0B5B370427BEBA2378F6A19B46604629EAC3D70774045DC51501D3A998E7042A00F68388C09C39DE32BEA1C530A314F5C17402A033E88EE954BC882A80143E75CFF7E85BDF8519A5A80FA69318E80E3A64BA1573A80248E0A3773D31D1F90133CA32C02A3CECBC83CD45B04007E06FCCF3B771851ED284B4F9E9451EAA4C2FD3890B74085D321D0B55009477DFFA9BE017FFF2096A503ECC28A7056B04D2D607E0379CC3AE6D8226D3CB74E2035D42A74CD74347838084AFDEF7656A480C6694D38088BF2C8B83B0477E1BC27A91862CFBF5234F55A497E984019D325D0F9C701050D3800E78536469FAC730A39C063499990331DAB03967D3E9653A6140A76A058C114E032A10C8E1F6CF1DA006940433CA69C8B3A128CE65F7A893A6D3CB74920474CB743E60C2402085023B7CEBFE7BA9F124C18C721AF22C05C6B9EC1E75D2747A994E92806E99CE074C180AACC5400E3F7DF0D3D478926046390D791C0A23EDEC1E75D2747A994E92806E99CE074CB81848CB811DF2F4FF0133CA695017201F4C274940B74CE703265C0EAC0D411C9AAE003408980FA6932454018C116E08A22DC11C9AEE0260AA0C7BF1330772A96A5A2D2F484396694BE4A9C96940A02EC018E19660DA14D4A1E94140A040A0EC309D24A141C031C24D41B52DB8C39D9FFB36359E2498514ECDA1B9372B9ACCE837D7195A5B94A4D065C8AA6CA9309D2401DD329D0F98705B707D18C401C122CC7892604629EA83E9240905028D117E18449F06F368321458E483E984A150604AF869307D1CD4036F8A26170389EC309DF8683150228BF479F004FEEE333FA0C6E4C38C52D407D3890F74C9743C74C2CF835F78F5456805684110019B49308372614629EA83E9C4451B8224721CBE1F570007BD1F4504369348EB0E30A314F5C17402A0336D0492CA41B7025030500AE83F260D0C32A314F5E1EB03D17ED095FAFC13D9ED560033DE8F8200A3C25C32024A10550663634629EA033A802EA013E8468E9F9919B70258E3FD2832C28C52D407D389C8C41AB70258ECFD2832C28C52D407D389C8C4E2F90A60E9D6E03413CC7A27880C30A314F5C1742226720A3E3F5F0144AD80A3DE492203CC28453D3C73E8B3542762224763BF772B00CD0414E05707EFA1C629AAE797DFDD4D75222612CE00F815C006EF24918163FFFE796A9CA2620EDD1D963DD38998C80656019CEB9D2432F01F8F7E891BA8A81C943DD38998C8B9631540341078D23B514CE0D1AF3D448D53540FCA9EE944A472321E001CA90080FDA80D4273F2A507FE8D1A675BF123E77CD8356D0565CF742252D9EFFABC5F016CF74E1613B8F5DEA3D438DBCA738F7C923A3EC06FEC9AB682B2673A11A96C777DDEAF005679278B097CE0B33FA3C6D95ABE7727757E80DFE8352D0565CF74225259E5FAFC480570E1F5C1E9E40291C2E59F7A811A67AB3147775B02E19BBF63CE8F5900943DD38948063EEEFAFC680560D849FA52504E3413503F9A0128C461DFDF47FE017692C60172D2B581C03EA001C0428CF4FFC1C83FC04E5AE25D242630B3FBC7D4484575A0CC992E442A4B7C7F1FF9072CBF2178B99D78C2BB50A480BE28E2D299A18AF24159ABFF9F9B13F06DDFDF47FE89B193F778178B092820A83E140054883DCCD7C704C04E5EEF5D2C26A06E407DA8F95F88F5CCD7C70460F9B6E00CBB40FB03E4E0B29DBF0B57A73183AD92E7BF737B70E2819B8313FFBC23786EFF6DF49C32C133F02C3C13CF66E75409CA1865CD74201299854F335F1F13C4D8450A0BCEC917F71EA0465B25CF7CE596E037F7DF38CFF307FE919E5706B8B7FB2C3C9B9D57251AFD2FC448F8AF0B1502BB48CB8373820D29EB1E0CF42B00BC992B09EAB17BE2DEEEB3EAAE0050B6EFBDFDD7B4EC452A57311F075408566C0FCEB40BD50DC8C9BE87FE951A6F553CFFADDB469C72DE310FF1F30B61F7F22B1A50656B8381B265652E5299F5A3FF5CA830C62E563720277843D5DD0A78F6E19D63CE19560265B404EC1ECCF99FFBDA27F8F915A1B77F61F631DF8EA1C218BB58B3010578F02B8F5023AE0C7B43FBCD73100ED44DF196C6B5ECBEA5B73032A0BE7F61E8E87F0C15C6441F0ED5262139F9B35B9FAD7FAF40D2478F410B21CF883DCE65AD0A80675432C69002CA1265CACA5AA472123ECC7C3B860A5DEC26DA2CB40077ED394C8DB952129AEB31F80D2BFFC256019C186F71607F4386DF265D5FB7F30394252B633191F9CD3F93A04217BB89D606140073D58DAC12348746FF9C39F034847DFE9A9BFD0065A879FFC28CC5FEFB50A18B35215E6A377ADCBBB1C8401303823149FDF7BC4C3B8E300D28BBF7DDF94B5AB662228FC377994FBB50A18FDD6C9377739191A6B70CC334615AB33E095C836BD93DEB424DFFA9D8C47CD9870AC798DB29E894F7009191BA630328D67747182F06F7F05647386FECEC71682F7E0BC3891BE8E78F605D0D2DF8998A536973FF2E54C8B09BEEF21E223282A5ABDA35283B282B2DF79D8A5DCC871954C8B09BEA0BC25380692C7D456832282305FC4C4DF8E5DF2C50611276E37DDE83440EFEFAAEA71B5931D81530DF8F3262652732931AF9E7438549D8CD97790F1339B9E6333FD70745092813940D2B33918B65CC7793A0C224A229C123DE03454E60E86A09BC089C5F7BFC97C2912C537F2E5498863D64ADF7505100CC6F6B4C60AECFAFB9FED258CB7C360D2A4CE3E21DC1CBEC414F7A0F1605C0FE01439E1D40DE5106AC6C446E9E649B7E4E820A27610F5BE73D5C1404D35DAD8813A819E459537DA5B28EF9EA24A87012D1D6E16A05940822069B0A1BAE13E4511FF52C9D426F7F408559B087AEF11221A6047DE13E77099037F5F72B610DF3D12C506116A219017D47B064B0F20D31F07D6A0D60941F79D2AABE4A389C77E4DF850AB3620F575C40456070AC0F6303C88306FA2A25D7BCBF0F15E6C112B0D74B9028113499C38AE048B78287B09847517D95B397F9641EA8300F96888586560A96CCC53707C1F91F0F82B77C3008B6DF1B04B3A79E0B7EFB93EFB6BB22B0B49D7AE2A160F6995F846946DA9107E485E5514C057C6E21F3C93C50615E2C213B9C848982C44EFFE68D41B0F8CA20F883BF98E3B1A782178FD9D9E0774F3F1EBCF0C3FBB8133600D2F2DB9F3D165652F18134C7E9475E90275506A5B283F9625EA8302F2BE6360F3DE6255064E4C26D736F4BD7E963966C8A3C2A3EAC02880FBC6DC34D3B9A58BF8F7D04EDD94843D2B1D4F2E4E70779445E916756162213C7E073CC17F3428545B0442938280778132EF96810BCF1AFC69DC465D39D913791E38527BE113CFBD04D73ECBB7974C34FE6B4D300878F360EC5B3E2E7220D4907D2CEF21483BCA30CD42AC84DA1A01F061516219A16D4874426B0F2A62038F7C341F086F771A7F0B9675FE44DE418A9007CA20A21AC14EC4D0DE70DB70647E5E06FEE19ED0C1C3AB99D139E6BD7C4D7BB0EEF93560120ED2C4F3E280B9409CA8695991861FF34D37E3E5458144BDC2243038204187752333F8D478E44DE448ED40AA026D22A00A49DE52989B87BA08A2011F8D622E67B45A1C269B0046E71123C78D0BCC5DB2DAFE3C7FCE7CF236F2247DB2B00A49DE56912282B9499BA0663CC309F9B062A9C86689DC0E0F70C88FBF8451D3FE699E7236F2247DB2B00A49DE5292B283B8D11CC73A468BC7F1A54382D96D8B38DC176052E98993CB89795B4A3ED15000E96A7BCA02C51A6ACAC07027CE96CE66BD342856560091E5C5720EEE733232E4ADA81C020E694758234241D2F9CE2792ACA80C707B6301F2B032A2C83A82B70C0CB486F41904BD691FD3C2476016667C3E01BE694758234241DBF7A86E7691A50C6E816301DF494035534FD63A8B02C2CF108133EE164A677A07F8A283766AC65903608F8BBE3FF4D9DB24E9086A4A3E820601650E603181B80EF4C1DEE9B0615968965A0B77B08A25F5AC55BDF256D1A10AD007CCD8739662DD8B3DDC844FFC83B0D9817947DCFC70672EFF197172A2C1BCB48EF3E318E662833CAB2490B04C271F27BF771E7AC013C3BEDC81A08342D3DED1264FEBACF345061D92CDD1A9C6619EAC5E6215537F97DD242817134390E90D6FFC7312914B84C7AD625380C9F61BE543654580596298C071C7732D93930025DD6F45E56C61603F98735C1C38F7E1207AD123C33ADF98F832D06AA12E8A607B304F0914AFBFD2E54581596B155C66C94D14E81D56B55F7F79318590E4C8E26A603D3A6FF70B8CB81EB043AEAF04A43F8C62AE63B554185556219EC5C7C00069AA68DE89B066CAE917AD89BF8F903F75047AD023C6BD2DB1F696679A903E8AAA3838395CDF727418555127D58A433DB88617EBF49E707E759FF164135690776E179EE6B9FA00E5B2678069E957620AD4833CB4B5D4067D01DD3694BD90BDF603E532554583596D90546EB07056140CCB89A60D26C000EEC14C49CB634F6DD1C3E63D251D7E87F163A5209C01716305FA91A2AAC8315DB83332DD3ADDD45A84DCE0F30A096B630283EC24A2065FD7E611EDE99C9F991C6BA07FF26D1F24A00BBFB9CC97CA40EA8B02E2CF35834D4BA48C1A6FBFC49FCFDFD91974D38109D57E6CC00EE9516F1E71E48234B7B93B4784C00B65FC9229FAC50619D58016066A0352B07DBEAFC0023DC47FF2BF2B4090736E87CE1B107A943E701F77037FB4C3B90B6A6664A26019DB66C7600365FEB883F830AEBC60A029F196B7C7A1073C86D75FE984B3E92AD2B101F18B00B2B823CDD023B3774FC09837DEE8134216D2CCD6D0195534BE20460EB853FE7552654D8045620573905543B8822AB3BC8A72857DF661E37611A6EFE88CE0BBF2BF0B3C742C7C634DEFC5E7F46B86FA0C9F01BCEC9FAC69F3FEC1948134B6BDB808E5B10317815F38126A0C2A6B082B9D62BA8DAA833BCB70C3EB63B72BE161C480B4B635B81AE990DD4C4B5CCF69B820A9BC40AA8F64021EC3FC70CA5ED849540D6964015873DBB6BCE1F039D335BA898DA037D2641854D630535E3155C6560D08F19485740D33BCF984059079ED995667F1235CF0C94BEA1671950611BB002ABBC258001A1B68E5AE701836F596707CA387EF89320B8EC3A9E962E51E3A060EBDEFC3154D816ACE0367B05592A5DEBF7A70163C61CFCA490E1690EDC1BCFE843A51953C378C06666DB6D810ADB84152066074A9F22AC6B438FBA41141E4271CBEC16E05EB867DB22FCCAA2A20D4560B3AD19ED4F820ADB861524E2044A0B16EAC27CFFB460310E56E44D5A4A9C76E05ADCA3E9853D55035B28B92B005B6DC53CFF24A8B08D5881AE344A091BEE53D33F0BD85404BBF3E02D8E7DFA7E7C6C6EC75E34E901FE860CBFE11C9C8B6BD8BDFA4A895D01D8E84A66C36D840ADB8A152CD60E4CB580A8EBA3FEA23A4A9815806D361ADB9F172A6C33D12AC2C24B89BB12ED27EA07B6C16C2623879B5CD557142A6C3B56D8D84F20F7A6227D1DF813E551704010B6D8C87AFE69A1C22E10ED2C8480A14C330488FFEED3F495A806D8488EB502B0BD992676F2290B2AEC12A680D5C6C4C141BDFD455632B6026073AB994D76092AEC1AA68845C6D1483163E8ED2FF290A115005B5BC46CB16B5061173185605C6057A4A011F4F61779496905C0C63AD9DF6750619731E5E05B84235D028DFC8BBC901901D854E5DFEAAB1B2AEC3AA6287C8528FC34B9E6FD45519CB800D8526D5FEBA9132AEC03F8A6BA296DCB399B82534CB9424CE29C8D6148EF962ABFCFDF3454D8274C91AF37BEEF2A56880CC0665ECF6CAA4F5061DF400D6ECADC689C8C942B4412B0918D7D7EEBBB50615F31C59E657C3D52B4103EB08DB398EDF4152AEC332BB6072F3525AF379E8E942E046C613D6C83D94C9FA1C22160CA7E8529FD4643DD82E102DDDF085B60363204A870489801A05BF0606410623840E7836AEE33A8708898312C37345BD07FA0E3E5CC068608150E15ACEA32E378A7F144642CA23F40A7EFECF2CABD2AA0C2A1134D1BA2227832321ED15DA0C3770E655A2F2F5428E6702A82C7226312DD013A93E34F800AC528D1D421C6083458D87EA0A3E5439CD22B02158A64CCB8105A7CB7A1E9C3F6005D4027BD0FDD2D1B2A1419B83E38DD0C0EE1C51A306C0E94FD46E882EA484C840A453ECC08D13DF8BCA15641F5A08C51D66AE69700158A6244D1850833DE6FCC1ACC80457E509628D3F57ADB970B158A62B86F24FBFB4C335874111E8D0C9819B648066586B2DB88B274CB599407158A7259BE2D38C30C192D038C50AB9B900CCA0665B41E65C6CA52940B158AEA58754BB0C00C1C63065888A4F882B93240592C47D9B03213D54185A27AE6BB0B73B30997464EF04DA3CF2D04E40DCD7AE4F552B73FEF769F447D50A1688EA55B83D3CC39DE6A60FC00A3DD784376710C016946DA9107E4E5ADC81BCBB3680E2A14ED22AA14108084B0E48F1B702AB416DAB0A909D280B4204D481BD2F87A397B37A042D11DA2CA017B1A605C01CE87B72D9AD8888C8353629B2BBC8911340367056E8B027FA3691EFF86C5333817D7E05ADC03F7C23D716F3C03CF3A4B4EDE752E7AC9FF0336BAE690CDF7CADC0000000049454E44AE426082, N'M', 1, 0, N'123', N'202CB962AC59075B964B07152D234B70', N'-', CAST(N'2020-11-21 20:02:57.803' AS DateTime), CAST(N'2020-11-21 20:02:57.803' AS DateTime))
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Index [RoleGroupLevel_groupLevel_Role]    Script Date: 12/9/2020 8:26:32 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleGroupLevel_groupLevel_Role] ON [dbo].[RoleGroupLevel]
(
	[id_role] ASC,
	[id_group_level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Roles]    Script Date: 12/9/2020 8:26:32 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Roles] ON [dbo].[Roles]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ErrorReport]  WITH CHECK ADD  CONSTRAINT [FK_ErrorReport_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ErrorReport] CHECK CONSTRAINT [FK_ErrorReport_Users]
GO
ALTER TABLE [dbo].[GroupLevel]  WITH CHECK ADD  CONSTRAINT [FK_GroupLevel_GroupLevel] FOREIGN KEY([id_parent])
REFERENCES [dbo].[GroupLevel] ([id])
GO
ALTER TABLE [dbo].[GroupLevel] CHECK CONSTRAINT [FK_GroupLevel_GroupLevel]
GO
ALTER TABLE [dbo].[GroupLevel]  WITH CHECK ADD  CONSTRAINT [FK_GroupLevel_Groups2] FOREIGN KEY([id_group])
REFERENCES [dbo].[Groups] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupLevel] CHECK CONSTRAINT [FK_GroupLevel_Groups2]
GO
ALTER TABLE [dbo].[LogApp]  WITH CHECK ADD  CONSTRAINT [FK_LogApp_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LogApp] CHECK CONSTRAINT [FK_LogApp_Users]
GO
ALTER TABLE [dbo].[MenuApp]  WITH CHECK ADD  CONSTRAINT [FK_MenuApp_MenuApp] FOREIGN KEY([IDParentMenu])
REFERENCES [dbo].[MenuApp] ([ID])
GO
ALTER TABLE [dbo].[MenuApp] CHECK CONSTRAINT [FK_MenuApp_MenuApp]
GO
ALTER TABLE [dbo].[RoleGroupLevel]  WITH CHECK ADD  CONSTRAINT [FK_RoleGroupLevel_GroupLevel] FOREIGN KEY([id_group_level])
REFERENCES [dbo].[GroupLevel] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleGroupLevel] CHECK CONSTRAINT [FK_RoleGroupLevel_GroupLevel]
GO
ALTER TABLE [dbo].[RoleGroupLevel]  WITH CHECK ADD  CONSTRAINT [FK_RoleGroupLevel_Roles] FOREIGN KEY([id_role])
REFERENCES [dbo].[Roles] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleGroupLevel] CHECK CONSTRAINT [FK_RoleGroupLevel_Roles]
GO
ALTER TABLE [dbo].[UserGroupLevel]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupLevel_GroupLevel] FOREIGN KEY([id_group_level])
REFERENCES [dbo].[GroupLevel] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGroupLevel] CHECK CONSTRAINT [FK_UserGroupLevel_GroupLevel]
GO
ALTER TABLE [dbo].[UserGroupLevel]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupLevel_Users] FOREIGN KEY([id_user])
REFERENCES [dbo].[Users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserGroupLevel] CHECK CONSTRAINT [FK_UserGroupLevel_Users]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Roles] FOREIGN KEY([id_role])
REFERENCES [dbo].[Roles] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Roles]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Users] FOREIGN KEY([id_user])
REFERENCES [dbo].[Users] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Users]
GO
USE [master]
GO
ALTER DATABASE [MYAPP] SET  READ_WRITE 
GO
