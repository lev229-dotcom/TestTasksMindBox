INSERT INTO [dbo].[Product] ([Name]) VALUES ('�����������'), ('�������'), ('���������'), ('����');

INSERT INTO [dbo].[Category] ([Name]) VALUES ('������� �������'), ('������� �������'), ('������� �������');

INSERT INTO [dbo].[ProductCategory] ([Product_ID],[Category_ID]) VALUES (1,1),(2,2),(2,3), (3,1), (4, null);
