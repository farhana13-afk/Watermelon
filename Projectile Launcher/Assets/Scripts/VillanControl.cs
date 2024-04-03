using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillanControl : MonoBehaviour
{
    public Canvas canva;
    private ScoreManager score_script;

    bool directionRL; 
    bool directionFB;
    float speed; 

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hi");
        Destroy(collision.gameObject);
        score_script.score += 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        score_script = canva.GetComponent<ScoreManager>();
        directionRL = false; 
        directionFB = true; 
        speed = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void FixedUpdate()
    {
        if(directionRL)
        {
            if( gameObject.transform.position.x  < 4.0 )
            {
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.right*speed) );
            }
            else
            {
                directionRL = false; 
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.left*speed) );
            }
        }
        else 
        {
            if( gameObject.transform.position.x  > -4.0)
            {
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.left*speed) );
            }
            else
            {
                directionRL = true; 
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.right*speed) );
            }
        }

        /*if(directionFB)
        {
            if( gameObject.transform.position.z < 9 )
            {
                transform.position += Vector3.forward * speed ;
            }
            else
            {
                directionRL = false; 
                transform.position += Vector3.back * speed;
            }
        }
         else 
        {
            if( gameObject.transform.position.z > -3.5)
            {
                transform.position += Vector3.back * speed;
            }
            else
            {
                directionRL = true; 
                transform.position += Vector3.forward * speed;
            }
        }*/


    }

}
