using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4LearningVectors : MonoBehaviour
{
    Vector3 myPosition;
    Vector3 myTargetDestination = new Vector3(0,10,0);

    void Start()
    {
        myPosition = transform.position;
        myTargetDestination = Vector3.zero;
        print("the object position is: " + myPosition);
    }
     
    void Update()
    {
        
    }
}
