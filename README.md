# MindBox
2-е задание:
SELECT Product.name as Product, (Select name FROM Category WHERE Product_Category.category_id = Category.id) as Category 
FROM Product LEFT JOIN Product_Category ON Product.id = Product_Category.product_id;

Структура БД и наполнение:
![image](https://user-images.githubusercontent.com/20929923/177143394-dcf0f757-7958-4efc-bd71-9a59e8801af5.png)

Результат запроса:
![image](https://user-images.githubusercontent.com/20929923/177142864-53cc03b7-ab8e-4385-b2e7-694ed6bf4cde.png)

