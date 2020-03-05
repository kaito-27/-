SELECT b.name ブランド, m.name メーカー
FROM brands b
LEFT JOIN makers m ON b.maker_id = m.id
