using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarRepetidos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> lista = new List<string> { "rojo", "azul", "rojo", "verde", "azul" };
        HashSet<string> sinRepetidos = QuitarRepetidos(lista);
        Debug.Log("Sin repetidos: " + string.Join(", ", sinRepetidos));
    }

    public HashSet<T> QuitarRepetidos<T>(List<T> lista)
    {
        return new HashSet<T>(lista);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
