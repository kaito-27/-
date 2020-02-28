SELECT name, SUM(circulation)
FROM doujo.manga_tbl
LEFT JOIN doujo.artist_tbl ON doujo.manga_tbl.artist_id = doujo.artist_tbl.id
GROUP BY doujo.manga_tbl.artist_id
ORDER BY SUM(circulation) desc

