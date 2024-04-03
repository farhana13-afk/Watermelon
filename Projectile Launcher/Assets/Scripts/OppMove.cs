using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppMove : MonoBehaviour
{
    
    float speed; 
    bool directionRL;

    // Start is called before the first frame update
    void Start()
    {
        
        speed = 0.2f; 
        directionRL = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        if(directionRL)
        {
            if( gameObject.transform.position.x  < 4.5 )
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
            if( gameObject.transform.position.x  > -4.50)
            {
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.left*speed) );
            }
            else
            {
                directionRL = true; 
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.right*speed) );
            }
        }


    }
}
