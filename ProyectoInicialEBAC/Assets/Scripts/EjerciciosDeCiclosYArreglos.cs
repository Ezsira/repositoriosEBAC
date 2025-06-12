using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDeCiclosYArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            arr1[i] = Random.Range(1, 11);
            arr2[i] = Random.Range(1, 11);
            arr3[i] = arr1[i] + arr2[i];
        }

        Debug.Log("Arreglo Resultado de Suma");
        for (int i = 0; i < arr3.Length; i++)
        {

            Debug.Log($"arr3[{i}] = {arr3[i]} (arr1[{i}]={arr1[i]} + arr2[{i}]={arr2[i]})");
        }

        string[] palabras = new string[] { "Hola", "mundo", "esto", "es", "una", "oración." };
        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + "";
        }

        Debug.Log("Oración concatenada:");
        Debug.Log(oracion.Trim());

        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

        int[] vector = new int[] { 2, 3 };
        int[] resultado = new int[3];
        for (int j = 0; j < 3; j++)
        {
            resultado[j] = 0;
            for (int i = 0; i < 2; i++)
            {
                resultado[j] += matriz[i, j] * vector[i];
            }
        }

        Debug.Log("Resultado de matriz * vector");
        for (int i = 0; i < resultado.Length; i++)
        {
            Debug.Log($"resultado[{i}] = {resultado[i]}");
        }
    }
       


        // Update is called once per frame
        void Update()
    {
        
    }
}
