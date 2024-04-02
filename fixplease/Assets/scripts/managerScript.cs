using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerScript : MonoBehaviour
{
    public Transform[] parentArray;
    public float distance = .5f;
    public bool did = false;
    private float addtoPosition = 0;
    // Start is called before the first frame update
    void Awake()
    {
        int thisLadder = -1;
        for (int i = 0; i < parentArray.Length; i++)
        {
            int j = 0;
            int ladderBelow = thisLadder;
            did = false;
           
            addtoPosition = 0;
            while (parentArray[i].childCount != 0)
            {
                int newHome = Random.Range(0, (parentArray[i].childCount));
                Transform newChild = parentArray[i].GetChild(newHome);
                newChild.parent = null;
                newChild.position = new Vector3(newChild.position.x + addtoPosition, newChild.position.y, newChild.position.z);

               

                if (j == ladderBelow)
                {
                    did = true;
                    newChild.position = new Vector3(newChild.position.x -distance, newChild.position.y, newChild.position.z);
                    addtoPosition -= distance;
                }
                if (newChild.tag == "ladderPrefab")
                {
                    thisLadder = j;
                    if (did)
                    {
                        thisLadder++;
                    }
                }
                j++;
                addtoPosition -= distance;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
