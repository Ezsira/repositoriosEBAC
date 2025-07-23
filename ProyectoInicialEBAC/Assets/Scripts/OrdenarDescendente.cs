using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class OrdenarDescendente : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arreglo = { 5, 2, 9, 1, 7 };
        int[] ordenado = OrdenarDeMayorAMenor(arreglo);
        Debug.Log("Orden descendente: " + string.Join(", ", ordenado));
    }

    public int[] OrdenarDeMayorAMenor(int[] arreglo)
    {
        return arreglo.OrderByDescending(x => x).ToArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
