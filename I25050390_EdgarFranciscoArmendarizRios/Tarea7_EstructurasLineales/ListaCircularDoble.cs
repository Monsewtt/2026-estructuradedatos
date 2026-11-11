using System;
using System.Collections.Generic;

namespace EstructurasLineales
{
    public class ListaCircularDoble
    {
        private List<int> elementos = new List<int>();

        public void Insertar(int v)
        {
            elementos.Add(v);
            Console.WriteLine($"\n[Éxito] Insertado: {v}");
        }

        public void Eliminar(int v)
        {
            if (elementos.Remove(v))
            {
                Console.WriteLine($"\n[Éxito] Eliminado: {v}");
            }
            else
            {
                Console.WriteLine($"\n[Error] Elemento {v} no encontrado.");
            }
        }

        public void Mostrar()
        {
            Console.Write("\nEstado de la Lista Circular Doble: ");
            if (elementos.Count == 0)
            {
                Console.WriteLine("Vacía");
                return;
            }
            Console.Write("Tail <-> ");
            foreach (var item in elementos)
            {
                Console.Write($"{item} <-> ");
            }
            Console.WriteLine($"(Head: {elementos[0]})");
        }

        public static void Ejecutar()
        {
            ListaCircularDoble lcd = new ListaCircularDoble();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ: LISTA CIRCULAR DOBLE ===");
                Console.WriteLine("1. Insertar elemento");
                Console.WriteLine("2. Eliminar elemento");
                Console.WriteLine("3. Mostrar Lista");
                Console.WriteLine("4. Regresar al menú principal");
                Console.Write("\nSelecciona una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Valor: ");
                            if (int.TryParse(Console.ReadLine(), out int v)) lcd.Insertar(v);
                            break;
                        case 2:
                            Console.Write("Valor a eliminar: ");
                            if (int.TryParse(Console.ReadLine(), out int ve)) lcd.Eliminar(ve);
                            break;
                        case 3:
                            lcd.Mostrar();
                            break;
                        case 4:
                            Console.WriteLine("Regresando...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
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