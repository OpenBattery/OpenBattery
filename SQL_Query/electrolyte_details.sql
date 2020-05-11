SELECT cell.id, cell_type.electrolyte_id, electrolyte.component_id, electrolyte_component.name, 
       electrolyte_component.created_date, electrolyte_component.component,
       electrolyte_component.smiles FROM cell_type 
    JOIN electrolyte
    ON cell_type.electrolyte_id = electrolyte.id
    JOIN electrolyte_component
    ON electrolyte.component_id = electrolyte_component.id
    JOIN cell
    ON cell_type.id = cell.cell_type_id;