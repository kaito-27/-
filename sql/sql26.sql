SELECT workname 名前, broadcast_from 放送開始, broadcast_to 放送終了
FROM anime_tbl a
LEFT JOIN manga_tbl m ON a.manga_id = m.id
WHERE broadcast_from = (
SELECT max(broadcast_from)
FROM anime_tbl a2
WHERE a.manga_id = a2.manga_id
)
