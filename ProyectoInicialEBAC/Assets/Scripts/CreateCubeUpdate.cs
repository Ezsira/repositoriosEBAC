using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubeUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = Random.insideUnitSphere * 5;
        }
    }
}
