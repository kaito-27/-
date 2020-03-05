SELECT workname タイトル, broadcast_from 放送開始, broadcast_to 放送終了
FROM anime_tbl a
LEFT JOIN manga_tbl m ON a.manga_id = m.id
WHERE (broadcast_to - broadcast_from) >= 730
