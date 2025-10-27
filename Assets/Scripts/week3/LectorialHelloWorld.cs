using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Developed by HAdi
This script does blag blagh

Followed Brackey's tutorial ....
modiofied it ...
 
 
 */



public class LectorialHelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    // change hello world to write hello + name
    // write an applicaiton to calculate age difference between two variables. 


    void Start()
    {

        Debug.Log( "Hello world");
        print("hello world!");
        int health=10;
        float Accuratehealth = 3.1f;
        string welcomeMessage = "Hello";
        string userName = "Hadi";


        print(welcomeMessage +": " + userName +  " your health is:" + health);

        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
