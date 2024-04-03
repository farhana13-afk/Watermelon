using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    int speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 20; 
    }

    // Update is called once per frame
    void Update()
    {
        if( transform.rotation.eulerAngles.x >= 310 && transform.rotation.eulerAngles.x > 2)
        {
            if(Input.GetKey(KeyCode.W))
            {
                transform.Rotate(Vector3.left * Time.deltaTime * speed);
            }
        }

        if( transform.rotation.eulerAngles.x < 2 || transform.rotation.eulerAngles.x > 310 || transform.rotation.eulerAngles.x > 20 )
        {
            if(Input.GetKey(KeyCode.S))
            {
                transform.Rotate(Vector3.right * Time.deltaTime * speed);
            }
        }

        if( transform.rotation.eulerAngles.x > 2 && transform.rotation.eulerAngles.x < 3 ) 
        {
            transform.Rotate(Vector3.left * speed);
        }
    }
    
}
