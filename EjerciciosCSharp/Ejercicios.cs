using System;

namespace EjerciciosCSharp
{
    public class Ejercicios
    {
        /// <summary>
        /// Ejercicio 1: La Tabla de Multiplicar
        /// </summary>
        public static string TablaDeMultiplicar(int numero)
        {
            string resultado = "";
            
            // 1. Bucle 'for' de 1 a 12
            for (int i = 1; i <= 12; i++)
            {
                // 2. Multiplicar numero por contador
                int producto = numero * i;
                // 3 y 4. Construir resultado con el formato pedido
                resultado += $"{numero} x {i} = {producto}\n";
            }
            
            return resultado;
        }

        /// <summary>
        /// Ejercicio 2: Validador de Contraseña
        /// </summary>
        public static int ValidarContrasena(Func<string> obtenerInput)
        {
            string claveSecreta = "1234";
            int intentos = 0;
            string entrada = "";
            
            // 2 y 5. Bucle do-while para ejecutar al menos una vez
            do
            {
                entrada = obtenerInput(); // Simula el Console.ReadLine()
                intentos++;               // 4. Contar intentos
            } while (entrada != claveSecreta); // 3. Mientras NO sea igual
            
            return intentos;
        }

        /// <summary>
        /// Ejercicio 3: Suma Acumulativa
        /// </summary>
        public static int SumaAcumulativa(int[] numeros)
        {
            int suma = 0; // 1. Acumulador
            
            // 2. Bucle foreach para recorrer la lista
            foreach (int n in numeros)
            {
                // 3. Si es 0, detener el bucle
                if (n == 0)
                {
                    break;
                }
                // 4. Sumar al acumulador
                suma += n;
            }
            
            return suma; // 5. Retornar total
        }

        /// <summary>
        /// Ejercicio 4: El Contador de Pares
        /// </summary>
        public static string ContadorDePares()
        {
            string resultado = "";
            
            // 1 y 2. Bucle for incrementando de 2 en 2 (i += 2)
            for (int i = 0; i <= 50; i += 2)
            {
                // 3. Agregar número al string
                resultado += i.ToString();
                
                // 4. Agregar coma si no es el último número (50)
                if (i < 50)
                {
                    resultado += ", ";
                }
            }
            
            return resultado;
        }
    }
}