SELECT m.workname �^�C�g��, a.name ��Җ�, c.name �o�ŎЖ�
FROM manga_tbl m
LEFT JOIN artist_tbl a ON m.artist_id = a.id
LEFT JOIN company_tbl c ON m.company_id = c.id
