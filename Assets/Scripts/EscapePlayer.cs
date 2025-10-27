using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
// testing now
public class EscapePlayer : MonoBehaviour
{
    /* ^^^^^ -------- Intermediate --- Challenge 4 --- Intermediate -------- ^^^^^ 
    Write relevant code to make the game object that this script is attached to move away from the player
    when they are within 3 units of distance. 
*/
    Vector3 playerPosition;
    GameObject player;
    float escapeSpeed = 0.007f;
    public Vector3 escaping;
    // Start is called before the first frame update
    void Start()
    {
        //Finds the player gameobject and copies it in our player variable
        player = GameObject.Find("Player");// Leave this and don't change! 
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerPosition(); // Leave this and do not change!
        MoveOppositePlayer();
        //Your code goes after this line!

    }
    void UpdatePlayerPosition() {
        playerPosition = player.transform.position;
    }
    void MoveOppositePlayer() {
        if (GetDistanceToPlayer() <= 3) {
            escaping = (transform.position - playerPosition);
            if (escaping.magnitude != 0)
            {
                escaping.Normalize();
            }

            transform.position += escaping * escapeSpeed;
        //your logic on how to move this game object away from the player using the speed variable.
        //direction vector should be calculated by using playerPosition and transform.position 
        }
    }

    float GetDistanceToPlayer() {
        float dis = Vector3.Distance(playerPosition, transform.position);
        //Calculate the distance between two vectors using playerPosition and transform.position.
        return dis;
    } 

}
