SELECT m.workname タイトル, a.name 作者名, c.name 出版社名
FROM manga_tbl m
LEFT JOIN artist_tbl a ON m.artist_id = a.id
LEFT JOIN company_tbl c ON m.company_id = c.id
