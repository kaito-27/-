SELECT name ���O, COUNT(*) ��
FROM manga_tbl m
LEFT JOIN artist_tbl a ON m.artist_id = a.id
GROUP BY a.id
HAVING COUNT(*) >= 2
