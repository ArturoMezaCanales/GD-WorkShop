using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomFire : MonoBehaviour
{
    private int topRange = 0;
    private int fireWindow = 0;
    //like this because they are off at start
                                  
    
    private void Awake()
    {
        int CC = transform.childCount;
        topRange = CC; 
        fireWindow = Random.Range(0, topRange);
        for(int i =0; i<CC; i++)
        {
            if(i != fireWindow)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
            
        }

    }
   

    // Update is called once per frame
  
}
