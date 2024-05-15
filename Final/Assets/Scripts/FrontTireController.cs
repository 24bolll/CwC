using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontTireController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
     private float speed = 20;
    private float turnspeed = 45;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

        // Rotates the wheel forward based on vertical input
        transform.Rotate(Vector3.left * Time.deltaTime * speed * forwardInput);
        // Rotates the wheel side to side based on horizontal input
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);
    }
}
