SELECT s.id ID, c.name ‰µ”„æ, s.order_date ”­’“ú, SUM(d.unit_price * d.amount) ‡Œv‹àŠz
FROM sales_details d
LEFT JOIN sales s ON d.sale_id = s.id
LEFT JOIN customers c ON s.customer_id = c.id
GROUP BY d.sale_id
HAVING ‡Œv‹àŠz >= 100000
