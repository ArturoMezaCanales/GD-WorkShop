using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class keepScore : MonoBehaviour
{
    public static float score = 0.0f;
    public TextMeshProUGUI myScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myScore.text = "Score: " + score;
    }
}
