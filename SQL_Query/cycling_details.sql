SELECT cell_type.name, cell_type.created_date, cell_type.vendor, 
       cycling.cell_id, cycling.data_table_name FROM cell_type
JOIN cell
ON cell_type.id = cell.cell_type_id
JOIN cycling
ON cycling.cell_id = cell.id;