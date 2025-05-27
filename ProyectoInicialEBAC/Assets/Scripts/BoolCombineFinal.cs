using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolCombineFinal : MonoBehaviour
{
    public GameObject andObject;
    public GameObject orObject;  
    public bool finalState;

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
        if (andObject && orObject)
        {
            bool andState = andObject.GetComponent<BoolCombineAND>().combinedState;
            bool orState = orObject.GetComponent<BoolCombineOR>().combinedState;
            finalState = andState || orState; 
            GetComponent<MeshRenderer>().material.color = finalState ? Color.white : Color.black;
            Debug.Log($"AND: {andState}, OR: {orState}, FINAL: {finalState}");
        }
    }
}
