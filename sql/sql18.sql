SELECT name ���O, workname �^�C�g��
FROM manga_tbl m
LEFT JOIN artist_tbl a ON m.artist_id = a.id
ORDER BY name

