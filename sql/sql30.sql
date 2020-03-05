SELECT SUM(circulation) ”­s•””, name o”ÅĞ
FROM manga_tbl m
LEFT JOIN company_tbl c ON m.company_id = c.id
GROUP BY m.company_id

