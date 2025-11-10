using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*------- Challenge 4 ------  Intermediate ------
     * 1. Use Random.Range and create a random vector3 for a leaf direction of movement
     * 2. Create a float value for the speed of each leaf. 
     * 3. Set the speed for each leaf to a random value between 0f and 0.1f
     * 4. Use transform.position, the direction vector and speed to move the leaf
*/
public class LeafController : MonoBehaviour
{
    float leafSpeed = 0f;
    Vector3 leafDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        leafDirection = new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), 0f);
        leafDirection.Normalize();
        leafSpeed = Random.Range(0f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += leafDirection * leafSpeed;
    }
}
