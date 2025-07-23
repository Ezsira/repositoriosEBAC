using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarAleatorios : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> numeros = GenerarListaAleatoria(10, 1, 100);
        Debug.Log("Números aleatorios: " + string.Join(", ", numeros));
    }

    public List<int> GenerarListaAleatoria(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> lista = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            int numero = Random.Range(rangoInferior, rangoSuperior + 1); 
            lista.Add(numero);
        }
        return lista;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
