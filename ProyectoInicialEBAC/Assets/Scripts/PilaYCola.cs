using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilaYCola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Stack<string> pila = new Stack<string>();
        pila.Push("Elemento A");
        pila.Push("Elemento B");
        pila.Push("Elemento C");

        ProcesarPilaYCola(pila);
    }

    public void ProcesarPilaYCola(Stack<string> pila)
    {
        Debug.Log("Contenido de la pila:");

        Queue<string> cola = new Queue<string>();

        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            Debug.Log("- Pila: " + elemento);
            cola.Enqueue(pila.Pop());
        }

        Debug.Log("Contenido de la cola:");
        while (cola.Count > 0)
        {
            string elemento = cola.Peek();
            Debug.Log("- Cola: " + elemento);
            cola.Dequeue();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
