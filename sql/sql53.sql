SELECT u.name âµîÑêÊ, sum('2016') 2016îN, sum('2017')2017îN, sum('2018') 2018îN
FROM(
SELECT c.name, c.id,
CASE WHEN s.order_date BETWEEN '2016-01-01' AND '2016-12-31' THEN d.unit_price * d.amount ELSE 0 END '2016',
CASE WHEN s.order_date BETWEEN '2017-01-01' AND '2017-12-31' THEN d.unit_price * d.amount ELSE 0 END '2017',
CASE WHEN s.order_date BETWEEN '2018-01-01' AND '2018-12-31' THEN d.unit_price * d.amount ELSE 0 END '2018'
FROM sales_details d
LEFT JOIN sales s ON d.sale_id = s.id
LEFT JOIN customers c ON s.customer_id = c.id
) u
GROUP BY u.id
