//Ignore the first three lines for now and don't change them!
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//We are going to engage with the code that is just inside the class. From line 7 onwards.
public class PlayerManager : MonoBehaviour
{ //curly brackets are used to tell the compiler where things start and end. They should always have a matching closing curly bracket.
    public float myHealth = 100.0f;
    public int myStrength = 1000;



    // Start is called before the first frame update
    // The start function is where you initialise values and settings for different objects.
    void Start()
    {
        myHealth = 100.0f;
        myStrength = 1000;

    }

    // Update is called once per frame
    /*
     * Challenge 4 ------ Intermediate --------
    //Expand on the lines below to add more keys.
    //Write a function to check inputs and do the translate. Call the checkInput function from update function below. 
    */
    void Update()
    {
        CheckInput();

    }
    // Use these four functions and test your code with the buttons in the scene.
    // Remember your project should be in play mode when testing the buttons and your code. 

    //1. Maximum value for Health should be 100 - Done
    //2. Minimum value for Health should be 0 - Done

    /* TODO:
     * Challenge 1  | Beginner |  
     * ----- Please add the following conditions to all strength functions. 
     * ----- remember to also add the health check we implemented above to decrease health function too
     * 
     * Maximum value for Strength should be 1000 - Done
     * Minimum value for Strength should be 0 - Done
    */



    //When health is above 70, increase health by half the amount - Done
    //When health is below 50, increase health by double the amount amount - Done


    /*
     * TO DO: -------------  Challenge 2 --------Intermediate--------
     * 
     * If any of the 4 buttons are clicked, update health and strength values based on the following conditions:
     * 1. When health is below 30, 
     *      - decrease strength by double amount - Done
     *      - increase health by the amount - Done
     * 2. When health is above 80 and strength is above 800
     *      - increase strength by by half the amount - Done
     *      - increase health by double the amount - Done
     * 3. Otherwise, increase and decrease health by the amount - Done
     * 
     * 
    */


    /*TODO: ------------------Challenge 3 --------Hard--------
     * 
     *  - Write a function to check and control the value of strength between 0-1000. - Done
     *  - Write a function to check player health and prints the following messages - Done
     *      - when health is between 1-20 print "be careful, you are about to die!"
     *      - when health is 0, print "You are dead!"
     *      - When health is above 90, print "What are you scared of?"
     */
 
    public void IncreaseHealth(float amount)
    {
        if (myHealth > 80.0f && myStrength > 800)
        {
            myStrength += (int)(amount / 2);
            myHealth += (amount * 2);
        }

        else if (myHealth <= 30.0f)
        {
            myStrength -= (int)(amount * 2);
            myHealth += (amount * 2);
        }
            
        else
        {
            myHealth += amount;
        }

        //Controlling the maximum and minimum value of player health
        CheckHealth();
        CheckStrength();
        CheckLife();

        Debug.Log(myHealth + " ");

        //Write your code here. 
    }

    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 1, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-1, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(1, 0, 0);
        }
    }

    void CheckLife()
    {
        if (myHealth <= 20 && myHealth >= 1)
        {
            Debug.Log("be careful, you are about to die!");
        }
        if (myHealth == 0)
        {
            Debug.Log("You are dead! Not big surprise!");
        }
        if (myHealth > 90)
        {
            Debug.Log("What are you scared of?");
        }
    }

    void CheckHealth()
    {
        if (myHealth > 100.0f)
        {
            myHealth = 100.0f;
        }
        if (myHealth < 0f)
        {
            myHealth = 0f;
        }
    }

    void CheckStrength()
    {
        if (myStrength > 1000)
        { 
            myStrength = 1000; 
        }
        if (myStrength < 0)
        {
            myStrength = 0;
        }

    }


    public void ReduceHealth(float amount)
    {
        if (myHealth > 80.0f && myStrength > 800)
        {
            myStrength += (int)(amount / 2);
            myHealth += (amount * 2);
        }

        else if (myHealth <= 30.0f)
        {
            myStrength -= (int)(amount * 2);
            myHealth += (amount * 2);
        }

        else
        {
            myHealth -= amount; 
        }
        
        CheckHealth();
        CheckStrength();
        Debug.Log(myHealth + " ");
        CheckLife();
    }
    public void IncreaseStrength(int amount)
    {
        if (myHealth > 80.0f && myStrength > 800)
        {
            myStrength += (int)(amount / 2);
            myHealth += (amount * 2);
        }

        else if (myHealth <= 30.0f)
        {
            myStrength -= (int)(amount * 2);
            myHealth += (amount * 2);
        }

        else
        {
            myHealth += amount;
        }

        CheckHealth();
        CheckStrength();
        Debug.Log(myStrength + " ");
        CheckLife();

    }
    public void ReduceStrength(int amount)
    {
        if (myHealth > 80.0f && myStrength > 800)
        {
            myStrength += (int)(amount / 2);
            myHealth += (amount * 2);
        }

        else if (myHealth <= 30.0f)
        {
            myStrength -= (int)(amount * 2);
            myHealth += (amount * 2);
        }

        else
        {
            myHealth -= amount;
        }

        CheckHealth();
        CheckStrength();
        Debug.Log(myStrength + " ");
        CheckLife();
    }


}
