SELECT c.name âµîÑêÊ, b.name ÉuÉâÉìÉhñº, i.volume óeó , s.order_date íçï∂ì˙
FROM sales_details d
LEFT JOIN sales s ON d.sale_id = s.id
LEFT JOIN customers c ON s.customer_id = c.id
LEFT JOIN items i ON d.item_id = i.id
LEFT JOIN brands b ON i.brand_id = b.id
WHERE b.id IN(
	SELECT *
	FROM(
		SELECT b.id
		FROM sales_details d
		LEFT JOIN sales s ON s.id = d.sale_id
		LEFT JOIN items i ON i.id = d.item_id
		LEFT JOIN brands b ON b.id = i.brand_id
		WHERE s.order_date BETWEEN '2019-01-01' AND '2019-12-31'
		GROUP BY b.id
		ORDER BY sum(d.unit_price * d.amount) DESC
		LIMIT 3
	) u
)
ORDER BY order_date DESC

