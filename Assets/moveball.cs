using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour

{
    int ballForce = -15; //force variable
    int ballPosition = 5; //position variable
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { //if space bar is pressed once
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.AddForce(new Vector3(0.0f, 0.0f, ballForce)); //z is forward
        }

        if (Input.GetKeyDown(KeyCode.W)) { //every time the W key is pressed, add 5 to force
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.AddForce(new Vector3(0.0f, 0.0f, ballForce + 5));
        }
      
        if (Input.GetKeyDown(KeyCode.S)) { //every time the S key is pressed, subtract 5 to force
            Rigidbody rb = GetComponent<Rigidbody> ();
            rb.AddForce(new Vector3(0.0f, 0.0f, ballForce - 5));
        }

        if (Input.GetKey(KeyCode.A)) { //if a is pressed
            //float throttle = Input.GetAxis("Horizontal"); //the object is going to be moved on the horizontal axis
            transform.Translate(throttle * ballPosition * Time.deltaTime, 0.0f, 0.0f); //and this is how the object will be moved on the horizontal axis
                                            //ballPosition = 5
        }

        if (Input.GetKey(KeyCode.D)) {
            //float throttle = Input.GetAxis("Horizontal");
            transform.Translate(throttle * -ballPosition * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
