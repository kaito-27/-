SELECT m.name, SUM(d.unit_price * d.amount) ”„ãŠz
FROM sales_details d
LEFT JOIN items i ON d.item_id = i.id
LEFT JOIN brands b ON i.brand_id = b.id
LEFT JOIN makers m ON b.maker_id = m.id
GROUP BY m.id
HAVING ”„ãŠz > (SELECT AVG(u.sum)
FROM ( SELECT sum(unit_price * amount) sum
FROM sales_details d
LEFT JOIN items i ON d.item_id = i.id
LEFT JOIN brands b ON i.brand_id = b.id
LEFT JOIN makers m ON b.maker_id = m.id
GROUP BY m.id
) u)
