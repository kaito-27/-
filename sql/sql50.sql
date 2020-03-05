SELECT c.name, SUM(d.unit_price * d.amount) ”Ì”„Šz
FROM sales_details d
LEFT JOIN sales s ON d.sale_id = s.id
LEFT JOIN customers c ON s.customer_id = c.id
GROUP BY c.id
