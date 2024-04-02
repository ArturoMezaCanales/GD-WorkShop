using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{
    
    private Animator theAnimator;
    private MovementV2 moveS;
    public groundCheck GC;
    // Start is called before the first frame update
    void Start()
    {
        moveS = gameObject.GetComponent<MovementV2>();
        theAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveS.onLadder)
        {
            theAnimator.SetBool("onLadder", true);
        }
        else
        {
            theAnimator.SetBool("onLadder", false);
        }

        if (GC.onGround)
        {
            theAnimator.SetBool("inAir", false);
        }
        else if (!moveS.onLadder)
        {
            theAnimator.SetBool("inAir", true);
        }


        if (Mathf.Abs(moveS.horizontal) > 0)
        {
            theAnimator.SetBool("moving", true);
        }
        else if (Mathf.Abs(moveS.horizontal) == 0)
        {
            theAnimator.SetBool("moving", false);
        }

        if (Mathf.Abs(moveS.vertical) > 0 && moveS.onLadder)
        {
            theAnimator.SetBool("movingLadder", true);
        }
        else if (Mathf.Abs(moveS.vertical) == 0 && moveS.onLadder)
        {
            theAnimator.SetBool("movingLadder", false);
        }
    }
    
}

   


