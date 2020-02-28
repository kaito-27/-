SELECT hometown, count(*)
FROM doujo.artist_tbl
GROUP BY hometown
ORDER BY count(*) DESC
