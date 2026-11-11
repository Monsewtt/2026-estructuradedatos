/* 
CARACTERÍSTICAS:
- Combina propiedades de pilas (LIFO) y colas (FIFO).
- Permite inserción y eliminación en ambos extremos (frente y final).
- Puede implementarse con arreglos circulares o listas doblemente enlazadas.

3 EJEMPLOS DE APLICACIONES:
1. Implementación del historial de navegación en un navegador web.
2. Funcionalidad de Deshacer/Rehacer (Undo/Redo) en editores de texto.
3. Algoritmos de planificación de tareas "Work-Stealing" en multiprocesamiento.
*/
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