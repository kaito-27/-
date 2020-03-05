SELECT workname 名前, broadcast_from 放送開始, broadcast_to 放送終了
FROM manga_tbl m
LEFT JOIN anime_tbl a ON a.id = m.artist_id
WHERE broadcast_from = (SELECT MAX(broadcast_from) FROM anime_tbl a2
WHERE  a.manga_id = a2.manga_id)
