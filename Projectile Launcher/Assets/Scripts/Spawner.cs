using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public GameObject watermelon;
   GameObject water; 

    float launchVelocity;

    // Start is called before the first frame update
    void Start()
    {
        launchVelocity = 15f; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            water = Instantiate(watermelon, transform.position, transform.rotation);
            //water.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * launchVelocity, ForceMode.Impulse);
            water.GetComponent<Rigidbody>().AddRelativeForce(Vector3.right * launchVelocity, ForceMode.Impulse);
        }
    }
}
