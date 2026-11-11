using System;
using System.Collections.Generic;

namespace Tarea6_Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRUEBA DE ESTRUCTURAS DE DATOS ===");
            Console.Write("¿Cuántos números enteros deseas ingresar en las estructuras? ");
            

            if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
            {

                ColaCircular colaCirc = new ColaCircular(cantidad);
                Bicola bicola = new Bicola();
                ListaDoblementeEnlazada listaDoble = new ListaDoblementeEnlazada();
                ListaCircular listaCirc = new ListaCircular();
                ListaCircularDoble listaCircDoble = new ListaCircularDoble();


                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write($"Ingresa el número entero #{i + 1}: ");
                    
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        // Insertamos el número en cada una de las estructuras
                        colaCirc.Encolar(numero);
                        bicola.InsertarFinal(numero);
                        listaDoble.Agregar(numero);
                        listaCirc.Agregar(numero);
                        listaCircDoble.Insertar(numero);
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Se insertará un 0 por defecto.");
                        colaCirc.Encolar(0);
                        bicola.InsertarFinal(0);
                        listaDoble.Agregar(0);
                        listaCirc.Agregar(0);
                        listaCircDoble.Insertar(0);
                    }
                }

                Console.WriteLine("\n¡Números guardados exitosamente en todas las estructuras!\n");


                Console.WriteLine("--- RESULTADOS RÁPIDOS ---");
                
                Console.WriteLine($"Cola Circular: El primer elemento en salir es el {colaCirc.Desencolar()}");
                
                bicola.EliminarFrente();
                Console.WriteLine("Bicola: Se ha eliminado el primer elemento del frente.");
                
                Console.WriteLine($"Lista Doblemente Enlazada: El primer nodo (Cabeza) tiene el valor {listaDoble.Cabeza?.Valor}");
                
                Console.WriteLine($"Lista Circular: El primer nodo (Cabeza) tiene el valor {listaCirc.Cabeza?.Valor}");
                

                Console.WriteLine($"Lista Circular Doble: El último elemento ingresado es {listaCircDoble.Cabeza?.Anterior?.Valor}");
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido mayor a cero.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
    public class Bicola {
    private LinkedList<int> lista = new LinkedList<int>();

    public void InsertarFrente(int item) {
        lista.AddFirst(item);
    }

    public void InsertarFinal(int item) {
        lista.AddLast(item);
    }

    public void EliminarFrente() {
        if (lista.Count > 0) lista.RemoveFirst();
    }

    public void EliminarFinal() {
        if (lista.Count > 0) lista.RemoveLast();
    }
}
    
public class ColaCircular {
    private int[] elementos;
    private int frente, final, tamaño, capacidad;

    public ColaCircular(int cap) {
        capacidad = cap;
        elementos = new int[capacidad];
        frente = 0; final = -1; tamaño = 0;
    }

    public void Encolar(int item) {
        if (tamaño == capacidad) return; // Cola llena
        final = (final + 1) % capacidad;
        elementos[final] = item;
        tamaño++;
    }

    public int Desencolar() {
        if (tamaño == 0) return -1; // Cola vacía
        int item = elementos[frente];
        frente = (frente + 1) % capacidad;
        tamaño--;
        return item;
    }
}
    
 public class ListaCircularDoble {
    public NodoDoble Cabeza;

    public void Insertar(int valor) {
        NodoDoble nuevoNodo = new NodoDoble(valor);
        if (Cabeza == null) {
            Cabeza = nuevoNodo;
            Cabeza.Siguiente = Cabeza;
            Cabeza.Anterior = Cabeza;
        } else {
            NodoDoble cola = Cabeza.Anterior;
            
            cola.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = cola;
            
            nuevoNodo.Siguiente = Cabeza;
            Cabeza.Anterior = nuevoNodo;
        }
    }
}
 
 
 public class NodoDoble {
    public int Valor;
    public NodoDoble Siguiente;
    public NodoDoble Anterior;
    public NodoDoble(int v) { Valor = v; }
}

public class ListaDoblementeEnlazada {
    public NodoDoble Cabeza;

    public void Agregar(int valor) {
        NodoDoble nuevoNodo = new NodoDoble(valor);
        if (Cabeza == null) {
            Cabeza = nuevoNodo;
            return;
        }
        NodoDoble actual = Cabeza;
        while (actual.Siguiente != null) {
            actual = actual.Siguiente;
        }
        actual.Siguiente = nuevoNodo;
        nuevoNodo.Anterior = actual;
    }

    public void Eliminar(int valor) {
        // Lógica simplificada de eliminación
        NodoDoble actual = Cabeza;
        while (actual != null && actual.Valor != valor) {
            actual = actual.Siguiente;
        }
        if (actual != null) {
            if (actual.Anterior != null) actual.Anterior.Siguiente = actual.Siguiente;
            else Cabeza = actual.Siguiente;
            
            if (actual.Siguiente != null) actual.Siguiente.Anterior = actual.Anterior;
        }
    }
}
 
    public class ListaCircular {
    public NodoSimple Cabeza;
    public NodoSimple Cola;

    public void Agregar(int valor) {
        NodoSimple nuevoNodo = new NodoSimple(valor);
        if (Cabeza == null) {
            Cabeza = nuevoNodo;
            Cola = nuevoNodo;
            nuevoNodo.Siguiente = Cabeza;
        } else {
            Cola.Siguiente = nuevoNodo;
            Cola = nuevoNodo;
            Cola.Siguiente = Cabeza; // Cierra el círculo
        }
    }
}
}