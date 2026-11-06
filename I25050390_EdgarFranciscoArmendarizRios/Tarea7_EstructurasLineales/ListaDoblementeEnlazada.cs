using System;
using System.Collections.Generic;

namespace EstructurasLineales
{
    public class ListaDoblementeEnlazada
    {
        private LinkedList<int> lista = new LinkedList<int>();

        public void InsertarInicio(int v)
        {
            lista.AddFirst(v);
            Console.WriteLine($"\n[Éxito] Insertado al inicio: {v}");
        }

        public void InsertarFinal(int v)
        {
            lista.AddLast(v);
            Console.WriteLine($"\n[Éxito] Insertado al final: {v}");
        }

        public void EliminarInicio()
        {
            if (lista.Count > 0)
            {
                Console.WriteLine($"\n[Éxito] Eliminado del inicio: {lista.First.Value}");
                lista.RemoveFirst();
            }
            else
            {
                Console.WriteLine("\n[Error] La lista está vacía.");
            }
        }

        public void EliminarFinal()
        {
            if (lista.Count > 0)
            {
                Console.WriteLine($"\n[Éxito] Eliminado del final: {lista.Last.Value}");
                lista.RemoveLast();
            }
            else
            {
                Console.WriteLine("\n[Error] La lista está vacía.");
            }
        }

        public void Mostrar()
        {
            Console.Write("\nRecorrido (Frente <-> Final): ");
            if (lista.Count == 0)
            {
                Console.WriteLine("Vacía");
                return;
            }
            foreach (var val in lista)
            {
                Console.Write($"{val} <-> ");
            }
            Console.WriteLine("null");
        }

        public static void Ejecutar()
        {
            ListaDoblementeEnlazada lde = new ListaDoblementeEnlazada();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ: LISTA DOBLEMENTE ENLAZADA ===");
                Console.WriteLine("1. Insertar al inicio");
                Console.WriteLine("2. Insertar al final");
                Console.WriteLine("3. Eliminar del inicio");
                Console.WriteLine("4. Eliminar del final");
                Console.WriteLine("5. Mostrar Lista");
                Console.WriteLine("6. Regresar al menú principal");
                Console.Write("\nSelecciona una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Valor: ");
                            if (int.TryParse(Console.ReadLine(), out int vi)) lde.InsertarInicio(vi);
                            break;
                        case 2:
                            Console.Write("Valor: ");
                            if (int.TryParse(Console.ReadLine(), out int vf)) lde.InsertarFinal(vf);
                            break;
                        case 3:
                            lde.EliminarInicio();
                            break;
                        case 4:
                            lde.EliminarFinal();
                            break;
                        case 5:
                            lde.Mostrar();
                            break;
                        case 6:
                            Console.WriteLine("Regresando...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (opcion != 6);
        }
    }
}