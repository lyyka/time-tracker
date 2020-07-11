USE [time_tracker]
GO
/****** Object:  Table [dbo].[contacts]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contacts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_contacts] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entries]    Script Date: 11-Jul-20 19:52:50 ******/
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
	[hourly_rate] [int] NULL,
	[currency] [varchar](50) NULL,
 CONSTRAINT [PK_Entries] PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  Table [dbo].[settings]    Script Date: 11-Jul-20 19:52:50 ******/
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
ALTER TABLE [dbo].[contacts] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[contacts] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[projects] ADD  CONSTRAINT [Project_CreatedAt_Default]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[settings] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[entries]  WITH CHECK ADD  CONSTRAINT [FK_Entries_Projects] FOREIGN KEY([project_id])
REFERENCES [dbo].[projects] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[entries] CHECK CONSTRAINT [FK_Entries_Projects]
GO
/****** Object:  StoredProcedure [dbo].[Contact_Delete]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Contact_Delete]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM contacts where id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Contact_GetAll]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Contact_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM contacts
END
GO
/****** Object:  StoredProcedure [dbo].[Contact_Insert]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Contact_Insert]
	-- Add the parameters for the stored procedure here
	@name varchar(100),
	@email varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into contacts(name, email) values(@name, @email);
END
GO
/****** Object:  StoredProcedure [dbo].[Contact_Update]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Contact_Update]
	-- Add the parameters for the stored procedure here
	@id int,
	@name varchar(100),
	@email varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update contacts set name = @name, email = @email where id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_Delete]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Entry_Delete]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM entries where id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_Filter]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Entry_Filter]
	-- Add the parameters for the stored procedure here
	@from_date datetime,
	@to_date datetime,
	@project_id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @project_id IS NOT NULL
		select * from entries where project_id = @project_id and start_time > @from_date and start_time < @to_date ORDER BY start_time ASC;
	IF @project_id IS NULL
		select * from entries where start_time > @from_date and start_time < @to_date ORDER BY start_time ASC;
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_FilterMain]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Entry_FilterMain]
	-- Add the parameters for the stored procedure here
	@from_date datetime,
	@to_date datetime,
	@project_id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--select * from entries 
	--where project_id = CASE WHEN @project_id IS NULL THEN project_id ELSE @project_id END AND 
	--start_time >= @from_date AND
	--start_time <= @to_date
	--ORDER BY id ASC;
	IF @project_id IS NOT NULL
		select * from entries where project_id = @project_id and start_time > @from_date and start_time < @to_date ORDER BY id ASC;
	IF @project_id IS NULL
		select * from entries where start_time > @from_date and start_time < @to_date ORDER BY id ASC;
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_GetAll]    Script Date: 11-Jul-20 19:52:50 ******/
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
	@sort_column varchar(50) = null,
	@sort_order varchar(5) = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @sort_column IS NOT NULL AND @sort_order IS NOT NULL
		select *
		from entries
		order by
			case
			when @sort_order <> 'ASC' then 0
			when @sort_column = 'id' then id
			end ASC,
			case
			when @sort_order <> 'DESC' then 0
			when @sort_column = 'id' then id
			end DESC
	IF @sort_column IS NULL AND @sort_order IS NULL
		select * from entries;
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_GetForReport]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Entry_GetForReport]
	-- Add the parameters for the stored procedure here
	@from_date datetime,
	@to_date datetime,
	@project_id int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @project_id IS NOT NULL
		select * from entries 
		where project_id = @project_id AND
		start_time >= @from_date AND
		start_time <= @to_date
		ORDER BY start_time DESC;
	IF @project_id IS NULL
		select * from entries 
		where start_time >= @from_date AND
		start_time <= @to_date
		ORDER BY start_time DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_Insert]    Script Date: 11-Jul-20 19:52:50 ******/
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
	@hourly_rate int,
	@currency varchar(50),
	@project_id int = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into entries(start_time, end_time, description, project_id, hourly_rate, currency) values(@start_time, @end_time, @description, @project_id, @hourly_rate, @currency);
END
GO
/****** Object:  StoredProcedure [dbo].[Entry_Update]    Script Date: 11-Jul-20 19:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Entry_Update]
	-- Add the parameters for the stored procedure here
	@id int,
	@start_time datetime,
	@end_time datetime,
	@description varchar(50),
	@hourly_rate int,
	@currency varchar(50),
	@project_id int = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update entries set start_time = @start_time, end_time = @end_time, description = @description, hourly_rate = @hourly_rate, currency = @currency, project_id = @project_id where id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Delete]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Project_GetAll]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Project_GetAllEntries]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Project_GetByID]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Project_GetByName]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Project_Insert]    Script Date: 11-Jul-20 19:52:50 ******/
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
	@project_name varchar(50),
	@hourly_rate int,
	@currency varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into projects(project_name, hourly_rate, currency) values(@project_name, @hourly_rate, @currency);
END
GO
/****** Object:  StoredProcedure [dbo].[Project_Update]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Settings_GetAll]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Settings_GetByName]    Script Date: 11-Jul-20 19:52:50 ******/
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
/****** Object:  StoredProcedure [dbo].[Settings_UpdateAll]    Script Date: 11-Jul-20 19:52:50 ******/
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
