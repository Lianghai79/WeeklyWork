using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MySecondPlayerController : MonoBehaviour
{
    /* ^^^^^ -------- Beginner --- Challenge 2 --- Beginner -------- ^^^^^ 
     *  Change this code to move the second player using the keys up, down, right and left
     */
    Vector3 yourMovement = new Vector3(0, 0, 0);
    public float yourSpeed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
    }

    

    // Update is called once per frame
    /*
     
     */
    void Update()
    {
        yourMovement = new Vector3(0,0,0);

        checkMoreInputs();
        
        if (yourMovement.magnitude != 0)
        {
            print("Value before normalisation: " + yourMovement);
            yourMovement.Normalize();
            print("Value after normalisation: " + yourMovement);
        }
        transform.position = transform.position + yourMovement *yourSpeed;
    }

    void checkMoreInputs()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            yourMovement += new Vector3(0f, yourSpeed, 0f);
            //transform.position
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            yourMovement += new Vector3(yourSpeed, 0f, 0f);
            //transform.position
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            yourMovement += new Vector3(0f, -yourSpeed, 0f);
            //transform.position
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            yourMovement += new Vector3(-yourSpeed, 0f, 0f);
            //transform.position
        }
    }
}
