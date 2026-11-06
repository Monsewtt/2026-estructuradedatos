


using System;

namespace EstructurasLineales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("   MENÚ PRINCIPAL - TAREA 7 (ESTRUCTURAS) ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Cola Circular");
                Console.WriteLine("2. Bicola");
                Console.WriteLine("3. Lista Doblemente Enlazada");
                Console.WriteLine("4. Lista Circular");
                Console.WriteLine("5. Lista Circular Doble");
                Console.WriteLine("6. Salir");
                Console.Write("\nSelecciona una estructura a probar: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            ColaCircular.Ejecutar();
                            break;
                        case 2:
                            Bicola.Ejecutar();
                            break;
                        case 3:
                            ListaDoblementeEnlazada.Ejecutar();
                            break;
                        case 4:
                            ListaCircular.Ejecutar();
                            break;
                        case 5:
                            ListaCircularDoble.Ejecutar();
                            break;
                        case 6:
                            Console.WriteLine("\n¡Saliendo del programa. Hasta luego!");
                            break;
                        default:
                            Console.WriteLine("\nOpción no válida. Presiona una tecla para continuar.");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nPor favor, ingresa un número válido. Presiona una tecla...");
                    Console.ReadKey();
                }

            } while (opcion != 6);
        }
    }
}

