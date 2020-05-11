SELECT cell.id, cell_type.negative_electrode_id, negative_electrode.component_id, electrode_component.name, 
       electrode_component.created_date, electrode_component.component, electrode_component.smiles FROM cell_type
    JOIN negative_electrode
    ON cell_type.negative_electrode_id = negative_electrode.id
    JOIN electrode_component
    ON negative_electrode.component_id = electrode_component.id
    JOIN cell
    ON cell_type.id = cell.cell_type_id;