SELECT c.name ������, MAX(order_date) �ŋ߂̒�����
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
GROUP BY s.customer_id
HAVING DATEDIFF(CURRENT_DATE(), MAX(order_date)) >= 365
