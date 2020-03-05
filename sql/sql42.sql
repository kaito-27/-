SELECT c.name 卸売先, MAX(order_date) 最近の注文日
FROM sales s
LEFT JOIN customers c ON s.customer_id = c.id
GROUP BY s.customer_id

