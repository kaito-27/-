SELECT workname 作品名, serialize_to - serialize_from 連載年数
FROM manga_tbl
WHERE serialize_to - serialize_from >= 15
