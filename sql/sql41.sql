SELECT d.sale_id, b.name, i.volume
FROM sales_details d
LEFT JOIN items i ON d.item_id = i.id
LEFT JOIN brands b ON i.brand_id = b.id
WHERE d.sale_id IN(
	SELECT c.name, s.order_date
	FROM sales s
	LEFT JOIN customers c ON s.customer_id = c.id
	WHERE name = '–ØŽRˆù—¿'
	ORDER BY order_date DESC
	LIMIT 5
)

