using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//IMPORTANT 
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        keepScore.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WhenClicked()
    {
        SceneManager.LoadScene("MainGame");
    }
}
