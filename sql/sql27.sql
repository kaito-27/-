SELECT workname �^�C�g��, broadcast_from �����J�n, broadcast_to �����I��
FROM anime_tbl a
LEFT JOIN manga_tbl m ON a.manga_id = m.id
WHERE (broadcast_to - broadcast_from) >= 730
