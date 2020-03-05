SELECT b.name, i.volume, MAX(d.unit_price) - MIN(d.unit_price) ç∑äz
FROM sales_details d
LEFT JOIN items i ON d.item_id = i.id
LEFT JOIN brands b ON i.brand_id = b.id
GROUP BY d.item_id
