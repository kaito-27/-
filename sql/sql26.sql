SELECT workname ���O, broadcast_from �����J�n, broadcast_to �����I��
FROM manga_tbl m
LEFT JOIN anime_tbl a ON a.id = m.artist_id
WHERE broadcast_from = (SELECT MAX(broadcast_from) FROM anime_tbl a2
WHERE  a.manga_id = a2.manga_id)
