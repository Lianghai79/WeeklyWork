using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week8PlayerPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    /*------- Week 7: ------  ------  Challenge 1 ------  ------  Intermediate ------
     * 1. Complete this example by creating 2 prefabs: HealthPickup and ScorePickup
     * 2. Add relavant tagas and layers to them i.e. pickups layer & healthPickup tag.
     * 3. Define a variable to store player health script (we implemented a script called LectorialPlayerHealth. 
     * 4. When the player is colliding with a health pickup call the addhealth in the LectorialPlayerHealth script to increase player health.
     * 5. Create a new script PlayerScore and add it to player game object. 
     * 6. In the PlayerScore script write a public function AddScore 
     * 7. When player is colliding score pickup objects, call the AddScore function to increase player's score. 
    */
    private void OnCollisionEnter2D(Collision2D theOtherObject)
    {
        if (theOtherObject.gameObject.layer == 3) {// 3 means we are colliding with layer3: pickups
            if(theOtherObject.gameObject.tag == "healthPickup") {
                print("add to player health");
                Destroy(theOtherObject.gameObject);
            }
            if (theOtherObject.gameObject.tag.Contains("scorePickup"))
            {
                print("add to player score");
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("finished colliding with: " + collision.gameObject.name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
