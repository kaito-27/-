SELECT c.name, s.order_date
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
WHERE name = '–ØŽRˆù—¿'
ORDER BY order_date DESC
LIMIT 5
