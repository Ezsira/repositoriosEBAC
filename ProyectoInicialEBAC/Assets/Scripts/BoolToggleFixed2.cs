using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolToggleFixed2 : MonoBehaviour
{
    public bool state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        state = !state;
        GetComponent<MeshRenderer>().material.color = state ? Color.white : Color.black;
    }
}
