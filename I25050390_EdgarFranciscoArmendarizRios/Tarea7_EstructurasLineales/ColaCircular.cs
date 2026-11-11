
using System;

namespace EstructurasLineales
{
    public class ColaCircular
    {
        private int[] buffer;
        private int cabeza, cola, capacidad, tamanio;

        public ColaCircular(int capacidad)
        {
            this.capacidad = capacidad;
            buffer = new int[capacidad];
            cabeza = 0;
            cola = -1;
            tamanio = 0;
        }

        public void Encolar(int v)
        {
            if (tamanio < capacidad)
            {
                cola = (cola + 1) % capacidad;
                buffer[cola] = v;
                tamanio++;
                Console.WriteLine($"\n[Éxito] Encolado: {v}");
            }
            else
            {
                Console.WriteLine("\n[Error] Cola circular llena.");
            }
        }

        public void Desencolar()
        {
            if (tamanio > 0)
            {
                Console.WriteLine($"\n[Éxito] Desencolado: {buffer[cabeza]}");
                cabeza = (cabeza + 1) % capacidad;
                tamanio--;
            }
            else
            {
                Console.WriteLine("\n[Error] Cola circular vacía.");
            }
        }

        public void Mostrar()
        {
            Console.Write("\nEstado actual de la Cola Circular: ");
            if (tamanio == 0)
            {
                Console.WriteLine("Vacía");
                return;
            }
            for (int i = 0; i < tamanio; i++)
            {
                int index = (cabeza + i) % capacidad;
                Console.Write(buffer[index] + " ");
            }
            Console.WriteLine();
        }

        public static void Ejecutar()
        {
            ColaCircular cc = new ColaCircular(3);
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ: COLA CIRCULAR ===");
                Console.WriteLine("1. Encolar (Insertar)");
                Console.WriteLine("2. Desencolar (Eliminar)");
                Console.WriteLine("3. Mostrar Cola");
                Console.WriteLine("4. Regresar al menú principal");
                Console.Write("\nSelecciona una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingresa el valor entero a encolar: ");
                            if (int.TryParse(Console.ReadLine(), out int val))
                            {
                                cc.Encolar(val);
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido.");
                            }
                            break;
                        case 2:
                            cc.Desencolar();
                            break;
                        case 3:
                            cc.Mostrar();
                            break;
                        case 4:
                            Console.WriteLine("Regresando...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 4);
        }
    }
}