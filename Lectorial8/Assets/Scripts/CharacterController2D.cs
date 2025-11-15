using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    #region movement variables
    float xMovement = 0;//Whether the player is pressing keys related to moving left or right.
    float jumpValue = 0; // Whether player pressed space or not. 
    Vector2 targetVelocity = new Vector2(0, 0);//This is where we are going to store the new velocity vector.
    #endregion

    
    //Private variables
    [Range(0, .3f)] [SerializeField] private float smoothTime = .1f;  // How much to smooth out the velocity changes. This will add a range value into the editor. So we can change it at runtime. 
    private Vector2 velocity = Vector2.zero;
    bool isRunning = false;
    bool isAttacking = false;
    bool isJumping = false;
    bool isMoving = false;
    int movementSpeed = 10; // When running or walking, this will be changed to the values of walkingSpeed or runningspeed defined as public var below. 


    //Components
    Rigidbody2D myRigidBody;
    Animator myAnimator;
    SpriteRenderer myRenderer;//This is the sprite renderer for our players. We want to use its flip option. You can test this in Unity editor. 



    //Public vars
    public bool isGrounded = true; //To check if the player is colliding with the ground
    public int walkingSpeed = 10;   // Default walking speed. 
    public int runningSpeed = 20; // Default running speed. 

    public int jumpVelocity = 20;

    public GameObject bulletPrefab;


    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myRenderer = GetComponent<SpriteRenderer>();
    }
    //This function checks whether user pressed left or right keys!
    void CheckInputs() {
        CheckMoving();
        CheckJump();
        CheckRunning();
        CheckAttack();
        Flip();
        SetTargetVelocity();
        CheckAnimation();
    }
    void CheckMoving() {
        xMovement = Input.GetAxis("Horizontal");//Remember, we can look at the list of axis from ProjectSetting -> Input in Unity.      
        isMoving = (xMovement != 0); // This line means, if xMovement is not equal 0, then the value of the xMovement!=0 will be true, otherwise false.
    }
    void CheckJump() {
        jumpValue = 0;
        if (isGrounded)
        {
            jumpValue = Input.GetAxis("Jump");
            if (jumpValue > 0)
            {
                isGrounded = false;
                isJumping = true;
            }
        }
    }

    void Flip() {
        if (xMovement > 0)
            myRenderer.flipX = false;
        else if (xMovement < 0)
            myRenderer.flipX = true;
    }


    //This function will update the animation for the player
    void CheckAnimation() {
        int moveSpeed = (int)Mathf.Abs(targetVelocity.x);//(int) this is called implicit conversion. the value of target velocity.x is float, so we need to convert it to int, before passing to our animator 
        myAnimator.SetInteger("MovementSpeed", moveSpeed);//Instead of passing 0 or 1, I just decided to pass the final value of target velocity.x
        //which will be 0 or movementspeed depending on user inputs. 
        //I also pass the abstract value (only positive) so we can decide on animation in the animator based on this value easier. 
        myAnimator.SetBool("isRunning", isRunning);
        myAnimator.SetBool("isAttacking", isAttacking);
        myAnimator.SetBool("isJumping", isJumping);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckRunning() {
        bool isShiftPressed = (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift));//if user pressed left or right shift for running fast. I put it in a bool here to avoid next line if statement getting too long!
        if (isShiftPressed) //if moving and shift is pressed!
        {
            print("running" + Time.deltaTime);
            isRunning = true;
            movementSpeed = runningSpeed;
        }
        else
        {
            isRunning = false;
            movementSpeed = walkingSpeed;
        }
    }

void CheckAttack() {
        if (Input.GetKey(KeyCode.F))
        {
            isAttacking = true;
        }
        else
        {
            isAttacking = false;
        }
    }
    private void FixedUpdate()
    {
        CheckInputs();
        

    }
    void SetTargetVelocity() {
        targetVelocity.Set(xMovement * movementSpeed, myRigidBody.velocity.y + jumpValue * jumpVelocity);
        myRigidBody.velocity = Vector2.SmoothDamp(myRigidBody.velocity, targetVelocity, ref velocity, smoothTime);
    }
    private void OnCollisionEnter2D(Collision2D theOther)
    {
        
        if (theOther.transform.tag == "ground")
        {
            isGrounded = true;
            isJumping = false;
        }

    }

}
