using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDeVariables : MonoBehaviour
{
    private int contadorEntero = 0;
    private float contadorFloat = 1.0f;
    private int contador = 0;
    public string colorSeleccionado = "rojo";
    string nombreCompleto = "Rodrigo Ruiz Gastelum";
    // Start is called before the first frame update
    void Start()
    {
        float numeroA = 7.8f;
        float numeroB = 3.2f;

        float resultadoFloat = numeroA + numeroB;
        int resultadoEntero = (int)resultadoFloat;
        Debug.Log("Resultado flotante: " + resultadoFloat);
        Debug.Log("Resultado entero (cast): " + resultadoEntero);

        float numeroDecimal = 3.14f;
        string numeroFormateado = numeroDecimal.ToString("F4");
        Debug.Log("Número con 4 decimales: " + numeroFormateado);

        string nombre = nombreCompleto.Substring(0, 7);       // "Rodrigo"
        string apellidoPaterno = nombreCompleto.Substring(8, 4); // "Ruiz"
        string apellidoMaterno = nombreCompleto.Substring(13);   // "Gastelum"

        Debug.Log("Nombre: " + nombre);
        Debug.Log("Apellido Paterno: " + apellidoPaterno);
        Debug.Log("Apellido Materno: " + apellidoMaterno);

       
        string[] partes = nombreCompleto.Split(' ');

        Debug.Log("Partes con Split:");
        foreach (string parte in partes)
        {
            Debug.Log(parte);
        }
    }

    // Update is called once per frame
    void Update()
    {
        contadorEntero++;
        Debug.Log("Entero(Update):" + contadorEntero);

        switch (colorSeleccionado.ToLower()) 
        {
            case "rojo":
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case "verde":
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case "azul":
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "amarillo":
                GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case "blanco":
                GetComponent<Renderer>().material.color = Color.white;
                break;
            default:
                GetComponent<Renderer>().material.color = Color.gray;
                break;
        }
    }
     void FixedUpdate()
    {
        contadorFloat *= 1.01f;
        Debug.Log("Float (FixedUpdate):" + contadorFloat.ToString("F2"));

        contador++;
        if (contador % 2 == 0)
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        Debug.Log("Contador: " + contador + " -> " + (contador % 2 == 0 ? "Par" : "Impar"));
    }
}
