using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score;
    public TextMeshProUGUI title; 
    public TextMeshProUGUI herComesVily; 

    public GameObject panel; 

    public bool gameEnd;
    public bool villanIsActive; 

    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
        gameEnd = false; 
        villanIsActive = false;
    }

    // Update is called once per frame
    void Update()
    {
       title.text = "POINTS: " + score; 

       

       if(villanIsActive)
       {
          herComesVily.text = "VILLAN HAS ARRIVED";
       }
       else
       {
        herComesVily.text = "";
       }

       if(gameEnd)
       {
            panel.SetActive(true);
       }
       else
       {
            panel.SetActive(false);
       }
    }

    public void Quit()
    {
       // Application.Quit();
       UnityEditor.EditorApplication.isPlaying = false; 
    }

}
