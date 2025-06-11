using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesParte2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Parte1();
        Parte2();
        Parte3();
    }

    void Parte1()
    {
        string valor1 = "1500";
        string valor2 = "2300";

        int numero1, numero2;

        if (int.TryParse(valor1, out numero1) && int.TryParse(valor2, out numero2))
        {
            int suma = numero1 + numero2;
            Debug.Log("Parte 1 - Suma: " + suma);
        }
        else
        {
            Debug.Log("Parte 1 - Error al convertir las cadenas a números.");
        }
    }

    
    void Parte2()
    {
        string oracion = "Hola Mundo";
        string resultado = "";

        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                resultado += oracion[i];
            }
        }

        Debug.Log("Parte 2 - Caracteres en índices pares: " + resultado);
    }

   
    void Parte3()
    {
        string oracion = "Hola Mundo";

        if (oracion.Length > 5)
        {
            string resultado = oracion.Substring(5);
            Debug.Log("Parte 3 - Oración sin los primeros 5 caracteres: " + resultado);
        }
        else
        {
            Debug.Log("Parte 3 - La oración es demasiado corta.");
        }
    }


}



