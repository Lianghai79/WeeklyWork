using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
/* ^^^^^ -------- HARD --- Challenge 3 --- HARD -------- ^^^^^ 
 There is one public variable in this class myTarget.
 - You can update the values of the target vector from inside Unity or change it here in the code. 
   select the follower game object and update its my target from the inspector window
- Define a variable for speed of type float. 
- Write the code inside the MoveToTarget function to move the follower game object to "my target" using the speed variable 
*/

public class MoveFromAToB : MonoBehaviour
{
    public Vector3 playerPos;
    public Vector3 myTarget;
    public Vector3 direction;
    public GameObject Player;
    public float distance;
    public float followSpeed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = Player.transform.position;
        MoveToTarget();
        
        
    }
    void MoveToTarget() 
    {
        myTarget = playerPos;
        direction += (myTarget - transform.position);

        distance = Vector3.Distance(myTarget, transform.position);
        
        if (direction.magnitude != 0)
        {
            direction.Normalize();
        }

        if (distance >= 1)
        {
            transform.position += direction * followSpeed;
        }
    }

}
