using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementV2 : MonoBehaviour
{
    public float speed = 2.5f;
    public bool onLadder = false;
    private bool onTopLadder = false;
    private Rigidbody myRG;


    public float vertical = 0;
    public float horizontal = 0;

    public groundCheck GC;

   

    // Start is called before the first frame update
    void Start()
    {
        myRG = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        //myRG.constraints = RigidbodyConstraints.FreezeRotation | ~RigidbodyConstraints.FreezePositionX;
        
        if (onLadder)
        {
            myRG.useGravity = false;


            myRG.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;

            //myRG.constraints = RigidbodyConstraints.FreezeAll;
            transform.rotation = Quaternion.AngleAxis(0, Vector3.up); //model facing away from camera

            if (GC.onGround && onLadder && vertical < 0) //prevents from cliping into ground
            {
                vertical = 0;
            }
            if (onTopLadder && vertical > 0) //pervents from going over ladder
            {
               
                vertical = 0;
            }

            gameObject.transform.position += new Vector3(0, vertical, 0) * speed * Time.deltaTime;
        }

         else if (horizontal < 0)  //face left
         {
         transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
          
         }
         else if (horizontal > 0) //face right
         {
         transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
         
         }



        if (!GC.onGround && !onLadder) // if in the air
        {
            myRG.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezeRotation;

            myRG.useGravity = true;
            horizontal /= 1.3f;
            vertical /= 1.3f;
           
            //myRG.AddForce(transform.up * -2); //harder gravity
        }
        else if (GC.onGround && !onLadder && Input.GetKeyDown("space")) //jump
        {

            //myRG.constraints = ~RigidbodyConstraints.FreezePositionY; //remove freeze in position y
            myRG.AddForce(0, 175, 0, ForceMode.Acceleration); //adds acceleration
        }


        //MOVE HERE
        gameObject.transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ladder" && Input.GetKey("w"))
        {
            onLadder = true;    
        }

        if (other.gameObject.tag == "topLadder")
        {
            onTopLadder = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ladder")
        {
            onLadder = false;
        }

        if (other.gameObject.tag == "topLadder")
        {
            onTopLadder = false;
        }
    }
    
}
