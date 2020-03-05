SELECT t.type_name í•Ê, COUNT(type_id) “o˜^”
FROM brands b
LEFT JOIN bevarage_types t ON b.type_id = t.id
GROUP BY t.id
