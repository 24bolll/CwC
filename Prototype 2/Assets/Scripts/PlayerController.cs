using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float horizontalInput;
    public float xRange = 10;
    public float speed = 10.0f;
    public GameObject projectileprefab;
    // Update is called once per frame
    void Update()
    {
        // Keep the player in bounds 
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.space))
        {
            // launch a projectile from the player
            Instantiate(projectileprefab, transform.position, projectileprefab.transform.rotation);
        }
    }
}
