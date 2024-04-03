using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villan : MonoBehaviour
{

    public Canvas canva;
    private ScoreManager score_script;
    public GameObject villan; 

    // Start is called before the first frame update
    void Start()
    {
        score_script = canva.GetComponent<ScoreManager>();
        villan.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(score_script.score >= 15)
        {
            villan.SetActive(true);
            score_script.villanIsActive = true; 
        }

         if(score_script.score >= 40)
        {
            villan.SetActive(false);
            score_script.gameEnd = true;
            score_script.villanIsActive = false;
        }
    }
}
