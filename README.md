# Shapes
Тестовое задание для Mindbox

SELECT product.name AS product_name, category.name AS category_name FROM product
	LEFT JOIN category ON product.category_id = category.id;
