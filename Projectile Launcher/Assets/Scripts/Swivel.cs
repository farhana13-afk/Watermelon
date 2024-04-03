using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swivel : MonoBehaviour
{
    int speed; 
    // Start is called before the first frame update
    void Start()
    {
        speed = 30; 
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.eulerAngles.y < 70 || transform.rotation.eulerAngles.y > 290)
        {
            if(Input.GetKey(KeyCode.D ))
            {
                transform.Rotate(Vector3.up * Time.deltaTime*speed);
            }
        }

        if(transform.rotation.eulerAngles.y < 71 && transform.rotation.eulerAngles.y > 69)
        {
            transform.Rotate(Vector3.down*Time.deltaTime*speed); 
        }
        

        if(transform.rotation.eulerAngles.y > 290 || ( transform.rotation.eulerAngles.y > 0 && transform.rotation.eulerAngles.y < 1 ) || transform.rotation.eulerAngles.y <70) 
        {
            if(Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down * Time.deltaTime*speed);
            }
        }

        if(transform.rotation.eulerAngles.y <290 && transform.rotation.eulerAngles.y > 289 )
        {
            transform.Rotate(Vector3.up*Time.deltaTime*speed); 
        }
    }
}
