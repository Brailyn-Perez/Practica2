using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{

    public delegate T OperacionMatematica<T>(T a, T b);


    public class CalculadoraGenerica<T> where T : struct
    {
        private List<T> numeros = new List<T>();


        public void AgregarNumero(T numero)
        {
            numeros.Add(numero);
        }


        public T RealizarOperacion(OperacionMatematica<T> operacion)
        {
            if (numeros.Count < 2)
                throw new InvalidOperationException("La lista debe contener al menos dos números para realizar esta operación.");

            T resultado = numeros[0];
            for (int i = 1; i < numeros.Count; i++)
            {
                resultado = operacion(resultado, numeros[i]);
            }
            return resultado;
        }


        public List<T> ObtenerNumeros()
        {
            return new List<T>(numeros);
        }
    }
}
