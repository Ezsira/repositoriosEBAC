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
            Debug.Log("Ejercicio 1 - Suma: " + suma);
        }
        else
        {
            Debug.Log("Ejercicio 1 - Error al convertir las cadenas a números.");
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

        Debug.Log("Ejercicio 2 - Caracteres en índices pares: " + resultado);
    }

   
    void Parte3()
    {
        string oracion = "Esta es una oración de ejemplo";

        if (oracion.Length > 5)
        {
            string resultado = oracion.Substring(5);
            Debug.Log("Ejercicio 3 - Oración sin los primeros 5 caracteres: " + resultado);
        }
        else
        {
            Debug.Log("Ejercicio 3 - La oración es demasiado corta.");
        }
    }


}



