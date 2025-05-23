using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubeAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void Awake()
    {
      GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = Vector3.zero;
    }
}
