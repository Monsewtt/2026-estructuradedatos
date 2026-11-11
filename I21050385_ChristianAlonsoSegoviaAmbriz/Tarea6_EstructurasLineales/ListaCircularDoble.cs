/* 
CARACTERÍSTICAS:
- Recorrido bidireccional y sin fin.
- El apuntador 'siguiente' del último nodo apunta al primero.
- El apuntador 'anterior' del primer nodo apunta al último.

3 EJEMPLOS DE APLICACIONES:
1. Listas de reproducción avanzadas (reproducción en bucle y navegación en ambas direcciones).
2. Implementación de estructuras de datos complejas como los Montículos de Fibonacci (Fibonacci Heaps).
3. Gestión de múltiples escritorios virtuales en un sistema operativo (cambiar entre el primero y el último).
*/
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