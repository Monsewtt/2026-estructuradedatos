using System;
using System.Collections.Generic;

class Grafo<T>
{
    private Dictionary<T, List<T>> adyacencia = new Dictionary<T, List<T>>();

    public void AgregarVertice(T vertice)
    {
        if (!adyacencia.ContainsKey(vertice))
            adyacencia[vertice] = new List<T>();
    }

    public void AgregarArista(T origen, T destino)
    {
        AgregarVertice(origen);
        AgregarVertice(destino);
        adyacencia[origen].Add(destino);
    }

    public void BFS(T inicio)
    {
        var visitados = new HashSet<T>();
        var cola = new Queue<T>();

        cola.Enqueue(inicio);
        visitados.Add(inicio);

        while (cola.Count > 0)
        {
            var actual = cola.Dequeue();
            Console.Write(actual + " ");

            foreach (var vecino in adyacencia[actual])
            {
                if (!visitados.Contains(vecino))
                {
                    visitados.Add(vecino);
                    cola.Enqueue(vecino);
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Grafo<string> g = new Grafo<string>();

        g.AgregarArista("A", "B");
        g.AgregarArista("A", "C");
        g.AgregarArista("B", "D");
        g.AgregarArista("C", "E");

        g.BFS("A");
    }
}
