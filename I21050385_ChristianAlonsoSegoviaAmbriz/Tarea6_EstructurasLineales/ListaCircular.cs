/* 
CARACTERÍSTICAS:
- El último nodo de la lista enlaza nuevamente al primer nodo (cabeza).
- No tiene nodos con apuntadores nulos al final.
- Puede recorrerse infinitamente en bucle.

3 EJEMPLOS DE APLICACIONES:
1. Juegos de mesa multijugador (pasar el turno al siguiente jugador en círculo).
2. Componentes de interfaz de usuario como Carruseles de imágenes.
3. Asignación de recursos de red entre múltiples terminales.
*/
public class NodoSimple {
    public int Valor;
    public NodoSimple Siguiente;
    public NodoSimple(int v) { Valor = v; }
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