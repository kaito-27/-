SELECT c.name ‰µ”„æ, DATEDIFF(s.send_date, s.order_date) “ú” 
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
WHERE DATEDIFF(s.send_date, s.order_date) >= 7
