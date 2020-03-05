SELECT t.type_name ƒWƒƒƒ“ƒ‹, COUNT(t.type_name) ‰ñ”
FROM sales_details d
LEFT JOIN sales s ON d.sale_id = s.id
LEFT JOIN items i ON d.item_id = i.id
LEFT JOIN brands b ON i.brand_id = b.id
LEFT JOIN bevarage_types t ON b.type_id = t.id
WHERE s.order_date >= '2019-01-01'
GROUP BY t.id
ORDER BY ‰ñ” DESC
