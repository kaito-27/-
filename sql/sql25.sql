SELECT workname �^�C�g��,
	CASE
		WHEN broadcast_to IS NULL THEN '������'
		ELSE '�����I��'
	END �������H
FROM anime_tbl a
LEFT JOIN manga_tbl m ON a.manga_id = m.id
