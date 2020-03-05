SELECT name 名前, workname タイトル
FROM manga_tbl m
LEFT JOIN artist_tbl a ON m.artist_id = a.id
ORDER BY name

