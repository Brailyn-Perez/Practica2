using Practica2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la Calculadora Genérica");

        Console.Write("Seleccione el tipo de dato (1: int, 2: double, 3: decimal): ");
        string tipoDato = Console.ReadLine();

        switch (tipoDato)
        {
            case "1":
                EjecutarCalculadora<int>();
                break;
            case "2":
                EjecutarCalculadora<double>();
                break;
            case "3":
                EjecutarCalculadora<decimal>();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void EjecutarCalculadora<T>() where T : struct
    {
        var calculadora = new CalculadoraGenerica<T>();

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar número");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Restar");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("5. Dividir");
            Console.WriteLine("6. Mostrar lista de números");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            try
            {
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese un número: ");
                        T numero = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                        calculadora.AgregarNumero(numero);
                        Console.WriteLine("Número agregado.");
                        break;
                    case "2":
                        Console.WriteLine("Resultado de la suma: " + calculadora.RealizarOperacion((a, b) => (dynamic)a + b));
                        break;
                    case "3":
                        Console.WriteLine("Resultado de la resta: " + calculadora.RealizarOperacion((a, b) => (dynamic)a - b));
                        break;
                    case "4":
                        Console.WriteLine("Resultado de la multiplicación: " + calculadora.RealizarOperacion((a, b) => (dynamic)a * b));
                        break;
                    case "5":
                        Console.WriteLine("Resultado de la división: " + calculadora.RealizarOperacion((a, b) =>
                        {
                            if ((dynamic)b == 0) throw new DivideByZeroException("No se puede dividir por cero.");
                            return (dynamic)a / b;
                        }));
                        break;
                    case "6":
                        Console.WriteLine("Lista de números: " + string.Join(", ", calculadora.ObtenerNumeros()));
                        break;
                    case "7":
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}