SELECT c.name ������, DATEDIFF(s.send_date, s.order_date) ���� 
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
WHERE DATEDIFF(s.send_date, s.order_date) >= 7
