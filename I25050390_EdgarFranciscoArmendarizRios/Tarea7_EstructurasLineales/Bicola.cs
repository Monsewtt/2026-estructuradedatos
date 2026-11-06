using System;
using System.Collections.Generic;

namespace EstructurasLineales
{
    public class Bicola
    {
        private LinkedList<int> datos = new LinkedList<int>();

        public void InsertarFrente(int v)
        {
            datos.AddFirst(v);
            Console.WriteLine($"\n[Éxito] Insertado al frente: {v}");
        }

        public void InsertarFinal(int v)
        {
            datos.AddLast(v);
            Console.WriteLine($"\n[Éxito] Insertado al final: {v}");
        }

        public void EliminarFrente()
        {
            if (datos.Count > 0)
            {
                Console.WriteLine($"\n[Éxito] Eliminado del frente: {datos.First.Value}");
                datos.RemoveFirst();
            }
            else
            {
                Console.WriteLine("\n[Error] La bicola está vacía.");
            }
        }

        public void EliminarFinal()
        {
            if (datos.Count > 0)
            {
                Console.WriteLine($"\n[Éxito] Eliminado del final: {datos.Last.Value}");
                datos.RemoveLast();
            }
            else
            {
                Console.WriteLine("\n[Error] La bicola está vacía.");
            }
        }

        public void Mostrar()
        {
            Console.Write("\nEstado actual de la Bicola (Frente -> Final): ");
            Console.WriteLine(string.Join(" <-> ", datos));
        }

        public static void Ejecutar()
        {
            Bicola bicola = new Bicola();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENÚ: BICOLA ===");
                Console.WriteLine("1. Insertar al frente");
                Console.WriteLine("2. Insertar al final");
                Console.WriteLine("3. Eliminar del frente");
                Console.WriteLine("4. Eliminar del final");
                Console.WriteLine("5. Mostrar Bicola");
                Console.WriteLine("6. Regresar al menú principal");
                Console.Write("\nSelecciona una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Ingresa el valor: ");
                            if (int.TryParse(Console.ReadLine(), out int vf)) bicola.InsertarFrente(vf);
                            break;
                        case 2:
                            Console.Write("Ingresa el valor: ");
                            if (int.TryParse(Console.ReadLine(), out int vfi)) bicola.InsertarFinal(vfi);
                            break;
                        case 3:
                            bicola.EliminarFrente();
                            break;
                        case 4:
                            bicola.EliminarFinal();
                            break;
                        case 5:
                            bicola.Mostrar();
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