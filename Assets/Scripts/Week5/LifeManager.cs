using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    float myAge = 0f;
    float maxAge = 5;
    // Start is called before the first frame update

    /*------- Challenge 2 ------- Intermediate -------
     * 1. Line 12 shows how you can use Random.Range(minimum value, maximum value);
     * 2. Change this code so each object will have a different maximum age between 3-7 seconds.
     * 3. Move the check age code into a new function
     */
    // Update is called once per frame

    void Start()
    {
        maxAge = Random.Range(3f, 7f);
    }

    void Update()
    {
        myAge += Time.deltaTime;
        checkAge();
    }

    void checkAge()
    {
        if (myAge >= maxAge)
        {
            Destroy(gameObject);
        }
    }
}
