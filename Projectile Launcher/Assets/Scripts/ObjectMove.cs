using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    // Start is called before the first frame update

    float speed; 
    bool directionRL;
    Rigidbody rb; 
    void Start()
    {
        speed = 0.1f; 
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
            if( gameObject.transform.position.x  < 7.00 )
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
            if( gameObject.transform.position.x  > -6.75)
            {
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.left*speed));
            }
            else
            {
                directionRL = true; 
                gameObject.GetComponent<Rigidbody>().MovePosition( (transform.position + Vector3.right*speed));
            }
        }
        

    }
}
