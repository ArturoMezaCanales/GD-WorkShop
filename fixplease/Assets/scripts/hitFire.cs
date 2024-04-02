using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hitFire : MonoBehaviour
{
    public keepScore myScore;
    public GameObject[] charactersSwitch;
    public AudioSource hitClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "closeFire")
        {
            keepScore.score += 10;
        }
    }
   //ADD FUNCTION HERE


    IEnumerator endGame()
    {

        charactersSwitch[0].gameObject.SetActive(false);
        charactersSwitch[1].gameObject.SetActive(true);

        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene("MainMenu");
        
    }
}
