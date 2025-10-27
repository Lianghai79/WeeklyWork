using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerLeaf : MonoBehaviour
{
     /* Challenge 5
      * 1. Make a vector3 and call it myTarget
      * 2. set MyTarget in the start function to player position. 
      * 3. Creat a speed variable of type float and give it a value e.g. 0.01f;
      * 3. write a function that moves the leaf towards the player using target and speed variables you just made. 

      */
    public GameObject thePlayer;
    MyFirstPlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = GameObject.Find("Player");
        print(thePlayer.transform.position);
        playerController = thePlayer.GetComponent<MyFirstPlayerController>();//leave this as is
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }
    void CheckDistance() {
        // if distance is less than 0.1f 
        playerController.GameOver();
    }
}
