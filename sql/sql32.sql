SELECT workname �^�C�g��
FROM manga_tbl
WHERE EXISTS(
	SELECT reader_name
	FROM read_manga_tbl
	WHERE workname = manga_title AND reader_name = '���c'
)

