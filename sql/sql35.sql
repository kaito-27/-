SELECT s.id, c.name ������
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
WHERE s.send_date > now()
