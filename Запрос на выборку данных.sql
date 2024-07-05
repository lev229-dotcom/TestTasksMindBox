select Product.Name as 'Название продукта', Category.Name as 'Название категории'
from [dbo].[ProductCategory] inner join  [dbo].[Product] on [Product_ID] = [ID_Product] 
left join [dbo].[Category] on [Category_ID] =[ID_Category];
