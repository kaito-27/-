SELECT c.name ‰µ”„æ, MAX(order_date) Å‹ß‚Ì’•¶“ú
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
GROUP BY s.customer_id
HAVING DATEDIFF(CURRENT_DATE(), MAX(order_date)) >= 365
