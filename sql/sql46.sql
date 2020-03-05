SELECT s.id ID, c.name ������, s.order_date ������, SUM(d.unit_price * d.amount) ���v���z
FROM sales_details d
LEFT JOIN sales s ON d.sale_id = s.id
LEFT JOIN customers c ON s.customer_id = c.id
GROUP BY d.sale_id
HAVING ���v���z >= 100000
