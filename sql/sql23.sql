SELECT name, SUM(circulation) ���s����
FROM manga_tbl m
LEFT JOIN artist_tbl a ON m.artist_id = a.id
GROUP BY name
ORDER BY SUM(circulation) desc

