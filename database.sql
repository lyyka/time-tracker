USE [time_tracker]
GO
/****** Object:  Table [dbo].[entries]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[start_time] [datetime] NOT NULL,
	[end_time] [datetime] NOT NULL,
	[description] [varchar](50) NULL,
	[project_id] [int] NULL,
 CONSTRAINT [PK_Entries] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projects](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[project_name] [varchar](50) NULL,
	[created_at] [datetime] NULL,
	[hourly_rate] [int] NULL,
	[currency] [varchar](50) NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[settings]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[settings](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[value] [varchar](50) NOT NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[entries]  WITH CHECK ADD  CONSTRAINT [FK_Entries_Projects] FOREIGN KEY([project_id])
REFERENCES [dbo].[projects] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[entries] CHECK CONSTRAINT [FK_Entries_Projects]
GO
/****** Object:  StoredProcedure [dbo].[Entry_GetAll]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Entry_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from entries
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_Insert]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Entry_Insert]
	-- Add the parameters for the stored procedure here
	@start_time datetime,
	@end_time datetime,
	@description varchar(50),
	@project_id int = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into entries(start_time, end_time, description, project_id) values(@start_time, @end_time, @description, @project_id);
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Delete]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Project_Delete]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM projects where id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Project_GetAll]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Project_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM projects
END
GO
/****** Object:  StoredProcedure [dbo].[Project_GetAllEntries]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Project_GetAllEntries]
	-- Add the parameters for the stored procedure here
	@project_id int -- Project id to be found in entries table
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from entries where project_id = @project_id
END
GO
/****** Object:  StoredProcedure [dbo].[Project_GetByID]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Project_GetByID]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from projects where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[Project_GetByName]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Project_GetByName]
	-- Add the parameters for the stored procedure here
	@project_name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from projects where project_name = @project_name
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Insert]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Project_Insert]
	-- Add the parameters for the stored procedure here
	@project_name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into projects(project_name) values(@project_name);
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Update]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Project_Update]
	-- Add the parameters for the stored procedure here
	@id int,
	@project_name varchar(50),
	@hourly_rate int,
	@currency varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update projects set project_name = @project_name, hourly_rate = @hourly_rate, currency = @currency where id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Settings_GetAll]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Settings_GetAll]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from settings
END
GO
/****** Object:  StoredProcedure [dbo].[Settings_GetByName]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Settings_GetByName]
	-- Add the parameters for the stored procedure here
	@name varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from settings WHERE name = @name
END
GO
/****** Object:  StoredProcedure [dbo].[Settings_UpdateAll]    Script Date: 06-Jul-20 22:11:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Settings_UpdateAll]
	-- Add the parameters for the stored procedure here
	@id int,
	@name varchar(50),
	@value varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update settings set name = @name, value = @value where id = @id;
END
GO
