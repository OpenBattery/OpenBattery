SELECT cell.id, cell_type.separator_id, separator.component_id, separator_component.name, 
       separator_component.created_date, separator_component.component, 
       separator_component.smiles FROM cell_type
    JOIN separator
    ON cell_type.separator_id = separator.id
    JOIN separator_component
    ON separator.component_id = separator_component.id
    JOIN cell
    ON cell_type.id = cell.cell_type_id;