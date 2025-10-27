using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherVariables : MonoBehaviour
{
    float niceFloat = 6.9f;
    bool isThisTrue = true;
    
    void Start()
    {
        Debug.Log(niceFloat + " nice");

        if (isThisTrue == true)
        {
            Debug.Log("Yes, this is true.");
        }
    }

    
    void Update()
    {
        
    }
}
