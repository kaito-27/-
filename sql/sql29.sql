SELECT ar.name –¼‘O
FROM anime_tbl a
LEFT JOIN manga_tbl m ON a.manga_id = m.id
LEFT JOIN artist_tbl ar ON m.artist_id = ar.id
GROUP BY m.id
HAVING COUNT(*) >= 2
