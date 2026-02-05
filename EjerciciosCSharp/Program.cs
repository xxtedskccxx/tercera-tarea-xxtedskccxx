using System;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejercicios de C# - Bucles ===\n");

            // --- Ejercicio 1: Tabla de Multiplicar ---
            Console.WriteLine("Ingresa un número para ver su tabla de multiplicar:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int numero))
            {
                Console.WriteLine(Ejercicios.TablaDeMultiplicar(numero));
            }

            // --- Ejercicio 2: Validador de Contraseña ---
            Console.WriteLine("\n[Validación de Contraseña]");
            int intentos = Ejercicios.ValidarContrasena(() => Console.ReadLine());
            Console.WriteLine($"¡Correcto! Lo lograste en {intentos} intentos.");

            // --- Ejercicio 3: Suma Acumulativa ---
            Console.WriteLine("\nIngresa números para sumar (0 para terminar):");
            var listaNumeros = new System.Collections.Generic.List<int>();
            int n;
            do {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    listaNumeros.Add(n);
                }
            } while (n != 0);
            Console.WriteLine($"Suma total: {Ejercicios.SumaAcumulativa(listaNumeros.ToArray())}");

            // --- Ejercicio 4: Contador de Pares ---
            Console.WriteLine("\nNúmeros pares del 0 al 50:");
            Console.WriteLine(Ejercicios.ContadorDePares());
            
            Console.WriteLine("\n=== Presiona cualquier tecla para salir ===");
            Console.ReadKey();
        }
    }
}