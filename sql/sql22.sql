SELECT name, count(*)
FROM doujo.manga_tbl 
LEFT JOIN doujo.artist_tbl ON doujo.artist_tbl.id = doujo.manga_tbl.artist_id
GROUP BY artist_id
HAVING COUNT(*) >= 2


