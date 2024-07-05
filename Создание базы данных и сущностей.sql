create database MindBox;
go

use MindBox;
go

create table [dbo].[Product]
(
	[ID_Product] [int] not null identity(1,1), 
	[Name] [varchar] (100) not null,
	
	constraint [PK_Product] primary key clustered 
	([ID_Product] ASC) on [PRIMARY]
)
go

create table [dbo].[Category]
(
	[ID_Category] [int] not null identity(1,1), 
	[Name] [varchar] (100) not null,
	
	constraint [PK_Category] primary key clustered 
	([ID_Category] ASC) on [PRIMARY]
)
go

create table [dbo].[ProductCategory](

	[ID_ProductCategory] [int] not null identity(1,1), 
	[Product_ID] [int] not null,
	[Category_ID] [int] null,

	constraint [PK_ProductCategory] primary key clustered 
	([ID_ProductCategory] ASC) on [PRIMARY],

	constraint [FK_Product_ProductCategory] foreign key ([Product_ID])
	references [dbo].[Product] ([ID_Product]),

	constraint [FK_Category_ProductCategory] foreign key ([Category_ID])
	references [dbo].[Category] ([ID_Category])

	
)
go
