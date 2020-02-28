SELECT name, workname
FROM doujo.manga_tbl
RIGHT JOIN doujo.artist_tbl ON doujo.manga_tbl.artist_id = doujo.artist_tbl.id
ORDER BY name
