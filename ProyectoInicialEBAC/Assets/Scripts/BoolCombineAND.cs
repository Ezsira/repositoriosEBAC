using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolCombineAND : MonoBehaviour
{
    public GameObject other1; 
    public GameObject other2; 
    public bool combinedState;
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
        if (other1 && other2)
        {
            bool s1 = other1.GetComponent<BoolToggleFixed>().state;
            bool s2 = other2.GetComponent<BoolToggleFixed2>().state;
            combinedState = s1 && s2;
            GetComponent<MeshRenderer>().material.color = combinedState ? Color.white : Color.black;
        }
    }
}
