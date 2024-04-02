using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour
{

    private Animator theAnimator;
    public GameObject HotDog;
    // Start is called before the first frame update
    void Start()
    {
        theAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gameOver")
        {
            SceneManager.LoadScene("MainMenu");
        }


        if (other.gameObject.tag == "HotDog")
        {
            
            gameObject.GetComponent<hitFire>().enabled = false;
            gameObject.GetComponent<MovementV2>().enabled = false;
            gameObject.GetComponent<Animator>().SetBool("eating", true);
            transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
            keepScore.score += 100;
            StartCoroutine("StartNewGame");

        }


    }


    IEnumerator StartNewGame()
    {
        yield return new WaitForSeconds(1);
        HotDog.SetActive(false);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MainGame");

    }
}
