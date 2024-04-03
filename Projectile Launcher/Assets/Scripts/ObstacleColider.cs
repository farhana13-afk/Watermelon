using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleColider : MonoBehaviour
{
    
    public Canvas canva; 
    private ScoreManager score_script;

    // Start is called before the first frame update

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        score_script.score -= 1; 
    }
    void Start()
    {
        score_script = canva.GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (score_script.score >= 15)
        {
            Destroy(gameObject);
        }
    }
}
