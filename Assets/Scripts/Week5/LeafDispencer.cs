using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDispencer : MonoBehaviour
{
    public GameObject leaf;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(leaf,transform.position,transform.rotation);
    }


    /*------- Challenge 1 ------- Beginner -------
     * 1. Move the check key if statement into a seperate function for checking keys
     * 2. Create a new function called SpawnLeaf
     * 3. Move the instantiate code to that function
     * 4. call the SpawnLeaf function from CheckInput function you created in step 1.
     */
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
        {
            Instantiate(leaf, transform.position, transform.rotation);
        }

        //Instantiate()
    }
}
