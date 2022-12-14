USE [userdb]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/11/2022 5:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[users] [varchar](max) NULL,
	[pass] [varchar](max) NULL,
	[icono] [image] NULL,
	[estado] [varchar](max) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[buscar_usuario]    Script Date: 12/11/2022 5:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_usuario]
@buscando varchar(50)
as
select * from users
where users Like '%' +@buscando +'%';
GO
/****** Object:  StoredProcedure [dbo].[editar_usuarios]    Script Date: 12/11/2022 5:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[editar_usuarios]
@idusuario int,
@users as varchar (max),
@pass varchar (max),
@icono image,
@estado varchar (max)
as
if Exists(select users from users where users=@users AND idusuario<>idusuario)
Raiserror('Usuario en uso, una otro nombre de por favor' ,16,1)
else
 update users set users=@users, pass=@pass,icono=@icono,estado=@estado
where idusuario=@idusuario
GO
/****** Object:  StoredProcedure [dbo].[eliminar_user]    Script Date: 12/11/2022 5:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_user]
@idusuario int
as 
delete from users where idusuario = idusuario
GO
/****** Object:  StoredProcedure [dbo].[insertar_user]    Script Date: 12/11/2022 5:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_user]
@users as varchar (max),
@pass varchar (max),
@icono image,
@estado varchar (max)
as
if Exists(select users from users where users=@users)
Raiserror('Usuario ya registrado' ,16,1)
else
insert into users
values (@users,@pass,@icono,@estado)
GO
/****** Object:  StoredProcedure [dbo].[mostar_usarios]    Script Date: 12/11/2022 5:09:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostar_usarios]
as
select * from users
GO
