SELECT workname 作品名, serialize_from 連載開始年
FROM manga_tbl
WHERE serialize_to IS NULL
