using System;

namespace ListaCircularEjemplo
{
    public class JugadorNodo
    {
        public string Nombre { get; set; }
        public JugadorNodo? Siguiente { get; set; }

        public JugadorNodo(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
        }
    }

    public class RuedaDeTurnos
    {
        private JugadorNodo? cabeza = null;
        private JugadorNodo? turnoActual = null;

        public void AgregarJugador(string nombre)
        {
            JugadorNodo nuevoNodo = new JugadorNodo(nombre);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cabeza.Siguiente = cabeza;
                turnoActual = cabeza;
            }
            else
            {
                JugadorNodo actual = cabeza;
                while (actual.Siguiente != cabeza)
                {
                    actual = actual.Siguiente!;
                }

                actual.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = cabeza;
            }
        }

        public string SiguienteTurno()
        {
            if (cabeza == null || turnoActual == null) return "No hay jugadores.";

            string jugadorActualNombre = turnoActual.Nombre;
            turnoActual = turnoActual.Siguiente; // Da el salto circular al siguiente
            return jugadorActualNombre;
        }

        public void MostrarListaCompleta()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            JugadorNodo actual = cabeza;
            Console.Write("\nOrden de integrantes: ");
            do
            {
                Console.Write($"{actual.Nombre} , ");
                actual = actual.Siguiente!;
            } while (actual != cabeza);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            RuedaDeTurnos partida = new RuedaDeTurnos();

            Console.WriteLine("=== SISTEMA DE TURNOS CIRCULAR (Listas Circulares ===");
            Console.Write("¿Cuántos jugadores van a participar?: ");

            if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
            {
                Console.WriteLine();
                for (int i = 1; i <= cantidad; i++)
                {
                    Console.Write($"Escribe el nombre del jugador {i}: ");
                    string? nombre = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(nombre))
                    {
                        partida.AgregarJugador(nombre.Trim());
                    }
                    else
                    {
                        partida.AgregarJugador($"Jugador_{i}");
                    }
                }

                partida.MostrarListaCompleta();

                Console.WriteLine("Inicio");
                Console.WriteLine("Presiona Enter para pasar al siguiente turno (o escribe 'salir' y presiona Enter para terminar).\n");

                int numeroTurno = 1;
                while (true)
                {
                    Console.Write($"Turno {numeroTurno}, Presiona Enter para continuar: ");
                    string? entrada = Console.ReadLine();

                    if (entrada != null && entrada.Trim().ToLower() == "salir")
                    {
                        Console.WriteLine("\n Partida Terminada");
                        break;
                    }

                    string jugadorEnTurno = partida.SiguienteTurno();
                    Console.WriteLine($"Es el turno de: {jugadorEnTurno}\n");
                    numeroTurno++;
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Reinicia la aplicación.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para cerrar la ventana...");
            Console.ReadKey();
        }
    }
}