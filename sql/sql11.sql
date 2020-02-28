SELECT workname, serialize_from, serialize_to, serialize_to - serialize_from AS year
FROM doujo.manga_tbl
WHERE serialize_to - serialize_from >= 15
