using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadTDDApp
{
    public class Funciones
    {
        /// <summary>Devuelve n! o -1 si n es negativo.</summary>
        public static long CalcularFactorial(int n)
        {
            if (n < 0) return -1;

            long resultado = 1;
            for (int i = 2; i <= n; i++)
                resultado *= i;

            return resultado;
        }

        private const int LongitudMinima = 8;
        private const char CaracterObligatorio = '#';

        /// <summary>Válida si no es null/vacía, tiene 8+ caracteres y contiene '#'.</summary>
        public static bool EsContrasenyaValida(string contrasenya)
        {
            return !string.IsNullOrEmpty(contrasenya)
                && contrasenya.Length >= LongitudMinima
                && contrasenya.Contains(CaracterObligatorio);
        }
    }
}
