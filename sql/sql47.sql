SELECT maker_id,
	count(case type_id when 1 then 1 else null end) as type1,
	count(case type_id when 2 then 1 else null end) as type2,
	count(case type_id when 3 then 1 else null end) as type3,
	count(case type_id when 4 then 1 else null end) as type4,
	count(case type_id when 5 then 1 else null end) as type5,
	count(case type_id when 99 then 1 else null end) as type99
FROM brands
GROUP BY maker_id
