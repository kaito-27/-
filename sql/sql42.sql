SELECT c.name ������, MAX(order_date) �ŋ߂̒�����
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
GROUP BY s.customer_id

