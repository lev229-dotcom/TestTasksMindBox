INSERT INTO [dbo].[Product] ([Name]) VALUES ('Холодильник'), ('Ноутбук'), ('Телевизор'), ('Шкаф');

INSERT INTO [dbo].[Category] ([Name]) VALUES ('Бытовая техника'), ('Игровая техника'), ('Офисная техника');

INSERT INTO [dbo].[ProductCategory] ([Product_ID],[Category_ID]) VALUES (1,1),(2,2),(2,3), (3,1), (4, null);
