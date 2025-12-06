CREATE TABLE PREGUNTA (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Texto TEXT NOT NULL,
    RespuestaCorrecta TEXT NOT NULL,
    Area TEXT,
    Puntuaje INTEGER NOT NULL
);

CREATE TABLE JUGADOR (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nombre TEXT NOT NULL,
    PuntuajeTotal INTEGER DEFAULT 0
);

CREATE TABLE RESPUESTA_JUGADOR (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    RespuestaTexto TEXT,
    JugadorId INTEGER NOT NULL,
    PreguntaId INTEGER NOT NULL,
    FOREIGN KEY (JugadorId) REFERENCES JUGADOR(Id),
    FOREIGN KEY (PreguntaId) REFERENCES PREGUNTA(Id)
);

-- INSERTS para tabla PREGUNTA - Cuestionario Almacén Virtual
-- Puntajes: Introducción=5, Unidad 1=10, Unidad 2=15, Unidad 3=20, Unidad 4=25

-- INTRODUCCION. CONCEPTOS GENERALES Y TIPOS DE ALMACENES (5 puntos)
INSERT INTO PREGUNTA (Texto, RespuestaCorrecta, Area, Puntuaje) VALUES
('¿Qué es un almacén dentro del contexto logístico?', 'c', 'Introducción', 5),
('¿Cuál de las siguientes funciones pertenece a un almacén?', 'b', 'Introducción', 5),
('Un almacén de materias primas se utiliza principalmente para:', 'b', 'Introducción', 5),
('¿Cuál es la principal característica de un almacén de productos terminados?', 'c', 'Introducción', 5),
('Un almacén de tránsito tiene como función principal:', 'a', 'Introducción', 5),
('Los almacenes públicos se caracterizan por:', 'b', 'Introducción', 5),
('¿Cuál de los siguientes tipos de almacén pertenece al sistema de distribución?', 'c', 'Introducción', 5),
('El principal objetivo de los almacenes automatizados es:', 'a', 'Introducción', 5),
('¿Qué tipo de almacén se utiliza para conservar productos que requieren condiciones especiales de temperatura o humedad?', 'c', 'Introducción', 5),
('El almacén de refacciones se utiliza para:', 'b', 'Introducción', 5),

-- UNIDAD 1. Almacenes y Métodos de Gestión (10 puntos)
('¿Qué caracteriza a un almacén interno?', 'b', 'Unidad 1', 10),
('Una ventaja de los almacenes externos es:', 'b', 'Unidad 1', 10),
('¿Cuál de los siguientes es un ejemplo de almacén interno?', 'c', 'Unidad 1', 10),
('Los almacenes externos suelen utilizarse cuando:', 'b', 'Unidad 1', 10),
('¿Qué define a un almacén especial?', 'b', 'Unidad 1', 10),
('Un almacén temporal se utiliza principalmente para:', 'b', 'Unidad 1', 10),
('¿Cuál de los siguientes ejemplos corresponde a un almacén especial?', 'a', 'Unidad 1', 10),
('Los almacenes temporales suelen instalarse:', 'c', 'Unidad 1', 10),
('El principio del sistema Justo a Tiempo (JIT) en los almacenes busca:', 'b', 'Unidad 1', 10),
('¿Qué papel cumple el sistema Kanban en el control de almacenes?', 'b', 'Unidad 1', 10),
('Una característica de los almacenes que aplican JIT es:', 'b', 'Unidad 1', 10),
('El principal objetivo de un centro de distribución (CEDIS) es:', 'b', 'Unidad 1', 10),
('Una ventaja de los centros de distribución es:', 'b', 'Unidad 1', 10),
('Los centros de distribución suelen ubicarse:', 'a', 'Unidad 1', 10),
('En la clasificación ABC, los productos tipo "A" se caracterizan por:', 'b', 'Unidad 1', 10),

-- UNIDAD 2. Elementos del Diseño del Almacén (15 puntos)
('¿Cuál es el primer paso para diseñar un almacén eficiente?', 'c', 'Unidad 2', 15),
('¿Qué elemento del diseño del almacén permite optimizar el uso del espacio disponible?', 'b', 'Unidad 2', 15),
('La elección de los equipos de manutención depende principalmente de:', 'b', 'Unidad 2', 15),
('¿Qué aspecto se considera fundamental en el diseño del flujo de materiales dentro del almacén?', 'b', 'Unidad 2', 15),
('El área de recepción dentro del almacén debe estar diseñada para:', 'b', 'Unidad 2', 15),
('¿Cuál de los siguientes elementos influye directamente en la seguridad del almacén?', 'b', 'Unidad 2', 15),
('En el diseño del almacén, la zona de despacho o expedición se utiliza para:', 'b', 'Unidad 2', 15),
('¿Qué factor se debe considerar para seleccionar el tipo de estantería adecuada?', 'b', 'Unidad 2', 15),
('El sistema de información en un almacén bien diseñado permite:', 'a', 'Unidad 2', 15),
('Un diseño de almacén eficiente debe buscar principalmente:', 'c', 'Unidad 2', 15),

-- UNIDAD 3. Técnicas de Control y Operación del Almacén (20 puntos)
('¿Cuál es el objetivo principal del flujo de materiales en el almacén?', 'b', 'Unidad 3', 20),
('Un flujo de materiales eficiente se caracteriza por:', 'b', 'Unidad 3', 20),
('El control de recibos de materiales busca principalmente:', 'b', 'Unidad 3', 20),
('¿Qué documento es fundamental para el control del recibo de materiales?', 'c', 'Unidad 3', 20),
('El control de envíos en el almacén tiene como función principal:', 'b', 'Unidad 3', 20),
('¿Qué herramienta apoya el control de envíos en almacenes modernos?', 'a', 'Unidad 3', 20),
('¿Qué significa RGA en el contexto del almacén?', 'b', 'Unidad 3', 20),
('El control de recibo de RGA permite:', 'a', 'Unidad 3', 20),
('El método FIFO (First In, First Out) se aplica para:', 'a', 'Unidad 3', 20),
('¿En qué tipo de productos es más recomendable aplicar el método FIFO?', 'b', 'Unidad 3', 20),
('El método LIFO (Last In, First Out) consiste en:', 'b', 'Unidad 3', 20),
('El conteo cíclico en un almacen tiene como objetivo:', 'b', 'Unidad 3', 20),
('Una ventaja del conteo cíclico es:', 'b', 'Unidad 3', 20),
('El control de productos perecederos debe enfocarse principalmente en:', 'b', 'Unidad 3', 20),
('La correcta operación de equipos y recursos del almacén permite:', 'b', 'Unidad 3', 20),

-- UNIDAD 4. Costos de Almacenaje (25 puntos)
('¿Qué representa el costo del edificio en un almacén?', 'b', 'Unidad 4', 25),
('En el control de costos de almacén, el presupuesto del edificio debe incluir:', 'b', 'Unidad 4', 25),
('Los insumos en el almacén se refieren a:', 'b', 'Unidad 4', 25),
('¿Qué acción ayuda a controlar los costos de insumos del almacén?', 'b', 'Unidad 4', 25),
('Los indicadores de higiene y seguridad permiten:', 'c', 'Unidad 4', 25),
('Un ejemplo de indicador de seguridad en almacén es:', 'b', 'Unidad 4', 25),
('El costo del personal de almacén incluye:', 'b', 'Unidad 4', 25),
('Una estrategia para controlar los costos de personal es:', 'c', 'Unidad 4', 25),
('En el rubro de seguros, los costos se destinan principalmente a:', 'b', 'Unidad 4', 25),
('Un presupuesto de seguros de almacén debe considerar:', 'b', 'Unidad 4', 25),
('¿Qué representan los costos financieros del inventario?', 'b', 'Unidad 4', 25),
('El costo financiero del inventario se reduce principalmente al:', 'b', 'Unidad 4', 25),
('Un inventario sobredimensionado provoca:', 'b', 'Unidad 4', 25),
('¿Qué indicador ayuda a evaluar el costo financiero del inventario?', 'b', 'Unidad 4', 25),
('Un exceso de inventario genera impacto directo sobre:', 'a', 'Unidad 4', 25),
('Los costos de operación del almacén comprenden:', 'b', 'Unidad 4', 25),
('Un ejemplo de costo variable de operación es:', 'c', 'Unidad 4', 25),
('¿Qué técnica permite controlar los costos de operación?', 'a', 'Unidad 4', 25),
('Un indicador útil para evaluar la eficiencia operativa del almacén es:', 'a', 'Unidad 4', 25),
('La optimización de los costos de operación debe enfocarse en:', 'c', 'Unidad 4', 25);