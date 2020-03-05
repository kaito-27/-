SELECT workname ƒ^ƒCƒgƒ‹
FROM anime_tbl a
LEFT JOIN manga_tbl m ON a.manga_id = m.id
GROUP BY m.id
HAVING COUNT(m.id) > 1
