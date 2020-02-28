SELECT workname, artist_tbl.name, company_tbl.name AS company
FROM doujo.manga_tbl LEFT JOIN doujo.artist_tbl ON doujo.manga_tbl.id = doujo.artist_tbl.id
LEFT JOIN doujo.company_tbl ON doujo.company_tbl.id = doujo.manga_tbl.id
