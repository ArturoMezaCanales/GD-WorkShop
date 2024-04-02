using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnAfterCS : MonoBehaviour
{
    public fireScrip thisFire;
    public GameObject textObj;

    // Start is called before the first frame update
    void Start()
    {
        thisFire = gameObject.GetComponent<fireScrip>();
        thisFire.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(textObj.activeSelf)
        {
            thisFire.enabled = true;
        }
    }
}
