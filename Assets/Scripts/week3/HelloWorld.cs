using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Your comment here

/*
Developed by: Hadi Mehrpouya
Date Modified: 22/09/2023

This is an age calculator!
 */

public class HelloWorld : MonoBehaviour 
{

    
    //Write a code that prints the age difference between two living things!
    int myAge = 88 ;
    int oldestTreeAge = 4855;



    // Start is called before the first frame update

    void Start()//Start function only runs once. 
    {
        int ageDifference = oldestTreeAge - myAge ;


        Debug.Log("The age difference is: " + ageDifference);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
