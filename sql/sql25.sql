SELECT workname タイトル,
	CASE
		WHEN broadcast_to IS NULL THEN '放送中'
		ELSE '放送終了'
	END 放送中？
FROM anime_tbl a
LEFT JOIN manga_tbl m ON a.manga_id = m.id
