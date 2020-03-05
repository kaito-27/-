SELECT workname タイトル
FROM manga_tbl m
LEFT JOIN artist_tbl a ON m.artist_id = a.id
WHERE a.name = '冨樫義博'
