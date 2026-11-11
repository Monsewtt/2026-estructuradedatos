/* 
CARACTERÍSTICAS:
- Estructura de tamaño fijo basada en arreglos.
- Conecta la última posición con la primera, formando un anillo.
- Principio FIFO (First In, First Out). Evita el desperdicio de memoria de las colas simples.

3 EJEMPLOS DE APLICACIONES:
1. Planificación de procesos en sistemas operativos (Round Robin).
2. Buffers de transmisión (streaming de audio/video).
3. Gestión de turnos y semáforos en sistemas de tráfico.
*/
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