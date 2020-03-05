SELECT m.name ÉÅÅ[ÉJÅ[, SUM(i.volume)
FROM items i
LEFT JOIN brands b ON i.brand_id = b.id
LEFT JOIN makers m ON b.maker_id = m.id
GROUP BY m.name
