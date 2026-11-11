/* 
CARACTERÍSTICAS:
- Cada nodo tiene dos enlaces: uno al elemento anterior y otro al siguiente.
- Permite el recorrido bidireccional (hacia adelante y hacia atrás).
- Consume más memoria por nodo que una lista simple debido al puntero extra.

3 EJEMPLOS DE APLICACIONES:
1. Reproductores de música (botón de canción anterior y siguiente).
2. Caché de navegadores para ir hacia adelante o atrás.
3. Representación de barajas de cartas en juegos digitales.
*/
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