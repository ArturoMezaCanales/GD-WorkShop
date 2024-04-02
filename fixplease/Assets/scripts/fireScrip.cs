using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireScrip : MonoBehaviour
{
    public float TIMER = 5.0f;
    public float timer = 2.0f;
    public GameObject fireObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 ConvertThis = transform.right;

            Instantiate(fireObject, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1), new Quaternion(ConvertThis.x, ConvertThis.y, ConvertThis.z, 0f));
            Instantiate(fireObject, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1), new Quaternion(ConvertThis.x, ConvertThis.y + 180, ConvertThis.z, 0f));

            //instantiate facing back and forward at the same time
            timer = TIMER;
        }
        
    }
}
