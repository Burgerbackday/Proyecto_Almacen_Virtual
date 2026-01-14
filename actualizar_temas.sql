-- Actualizar temas según el área de cada pregunta

-- Introducción
UPDATE PREGUNTA 
SET Tema = 'Conceptos Generales y Tipos de Almacenes' 
WHERE Area = 'Introducción';

-- Unidad 1
UPDATE PREGUNTA 
SET Tema = 'Almacenes y Métodos de Gestión' 
WHERE Area = 'Unidad 1';

-- Unidad 2
UPDATE PREGUNTA 
SET Tema = 'Elementos del Diseño del Almacén' 
WHERE Area = 'Unidad 2';

-- Unidad 3
UPDATE PREGUNTA 
SET Tema = 'Técnicas de Control y Operación del Almacén' 
WHERE Area = 'Unidad 3';

-- Unidad 4
UPDATE PREGUNTA 
SET Tema = 'Costos de Almacenaje' 
WHERE Area = 'Unidad 4';