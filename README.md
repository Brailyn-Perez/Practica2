Calculadora Genérica en C#
Propósito del Proyecto
Este proyecto implementa una calculadora genérica que permite realizar operaciones matemáticas sobre una lista de números de diferentes tipos de datos (int, double, decimal). Utiliza genéricos, delegados y control de excepciones, proporcionando flexibilidad y seguridad en la manipulación de datos numéricos.

Características
Lista Genérica: Manejo de números genéricos para realizar operaciones.
Operaciones Matemáticas: Suma, resta, multiplicación y división.
Control de Excepciones: Manejo de errores como entrada inválida, división por cero, y lista con pocos elementos.
Interfaz de Usuario en Consola: Menú interactivo para agregar números y seleccionar operaciones.
Requisitos Previos
.NET SDK 6.0 o superior.
Editor de texto o IDE como Visual Studio o Visual Studio Code.
Cómo Ejecutar el Programa
Clona el repositorio:
bash
Copiar
Editar
git clone <URL-del-repositorio>
Abre el proyecto en tu IDE preferido.
Compila y ejecuta el proyecto.
Sigue las instrucciones en consola:
Selecciona el tipo de datos.
Agrega números a la lista.
Elige la operación matemática que deseas realizar.
Uso del Programa
Elegir tipo de dato: int, double o decimal.
Agregar números: Ingresa números a la lista uno por uno.
Realizar operaciones:
Suma: Sumar todos los números de la lista.
Resta: Restar los números en orden.
Multiplicación: Multiplicar todos los números.
División: Dividir los números en secuencia.
Manejo de Excepciones
Lista Vacía o con pocos elementos: Muestra un mensaje indicando que no se puede realizar la operación.
Entrada Inválida: Informa al usuario cuando la entrada no es un número válido.
División por Cero: Maneja este caso mostrando un mensaje específico.
Estructura del Código
CalculadoraGenerica<T>: Clase genérica para manejar operaciones sobre una lista.
Delegados: Usados para realizar operaciones matemáticas.
Program.cs: Contiene la lógica principal e interacción con el usuario.
Ejemplo de Uso
plaintext
Copiar
Editar
Bienvenido a la Calculadora Genérica
Seleccione el tipo de dato (1: int, 2: double, 3: decimal): 1

Menú:
1. Agregar número
2. Sumar
3. Restar
4. Multiplicar
5. Dividir
6. Mostrar lista de números
7. Salir
Seleccione una opción: 1

Ingrese un número: 10
Número agregado.
Créditos
Este proyecto fue desarrollado como parte de una tarea práctica del Instituto Tecnológico de las Américas.

Licencia
Este proyecto es de uso educativo y no tiene una licencia específica.
