SELECT m.name ���[�J�[, b.name �u�����h, i.volume 
FROM items i
LEFT JOIN brands b ON i.brand_id = b.id
LEFT JOIN makers m ON b.maker_id = m.id
ORDER BY m.name, b.name
