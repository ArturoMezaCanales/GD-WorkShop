using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{

    public GameObject[] objects;
    public Animator[] startAnim;
    public MovementV2 myMove;
    public AudioSource[] audioS;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("myCS");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator myCS()
    {
        for(int i = 0; i<3;i++)
        {
            yield return new WaitForSeconds(0.5f);
            objects[i].SetActive(true);
            audioS[0].enabled = true;
            yield return new WaitForSeconds(0.5f);
        }

        startAnim[0].enabled = true;
        objects[3].SetActive(true);
        yield return new WaitForSeconds(1f);

        startAnim[1].enabled = true;
        myMove.enabled = true;
        audioS[1].enabled = true;


        yield return null;
    }
}
