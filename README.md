Cuestionario Interactivo con SQLite

Módulo independiente para futura integración en Unity

Este proyecto corresponde a un prototipo funcional de un sistema de cuestionarios basado en SQLite y desarrollado en .NET. Su objetivo es servir como módulo independiente para posteriormente integrarlo dentro de un proyecto mayor construido en Unity.

Actualmente el sistema permite:
	•	Cargar preguntas desde una base de datos SQLite.
	•	Seleccionar preguntas en orden aleatorio.
	•	Registrar respuestas del jugador.
	•	Calcular puntaje basado en los valores asignados a cada pregunta.
	•	Probar todo el flujo desde una aplicación de consola en .NET.

Estructura del proyecto

El prototipo contiene los siguientes componentes principales:
	•	Models: Clases de datos para Jugador, Pregunta y RespuestaJugador.
	•	Database.cs: Manejador de conexiones a SQLite y consultas básicas.
	•	QuizService.cs: Lógica principal del cuestionario, selección aleatoria y verificación de respuestas.
	•	Program.cs: Punto de entrada para pruebas directas en consola.

Objetivo del módulo

Este prototipo está diseñado para ser utilizado más adelante dentro de Unity como una función global del proyecto principal. Su diseño modular permitirá integrarlo sin modificar la lógica central del juego.

Estado del desarrollo

El sistema ya ejecuta:
	•	Lectura desde SQLite
	•	Generación dinámica de cuestionarios
	•	Flujo de preguntas y evaluación básica

Aún se espera incorporar:
	•	Integración completa con Unity
	•	Interfaz visual del formulario dentro del juego
	•	Registro persistente de jugadores
	•	Más tablas y campos dentro de la base de datos
	•	Manejo avanzado de puntajes y estadísticas
	•	Control de estados del cuestionario dentro del motor de juego

Notas adicionales

Este repositorio recibirá más archivos y mejoras conforme avance la implementación en Unity. El prototipo actual está orientado exclusivamente a pruebas lógicas y validación preliminar del sistema.
