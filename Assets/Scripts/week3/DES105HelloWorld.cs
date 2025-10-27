using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//IMMA MAKE THIS PEAK!!!

/*
Developed by: Morgan Horrocks THE PEAK MASTER
Date Modified: 22/09/2025

This is an age calculator!
 */

public class DES105HelloWorld : MonoBehaviour
{
    int myAge = 17;
    int xboxAge = 23;

    void Start()//start function only runs at the beninging
    {
        int ageDifference = xboxAge - myAge;
        Debug.Log("The age difference is " + ageDifference);
    }

    void Update()//update function runs every goddamn frame
    {
        
    }
}
