SELECT workname, serialize_to
FROM doujo.manga_tbl
WHERE serialize_to IS NULL
