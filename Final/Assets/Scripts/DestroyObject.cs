using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyobject : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float lowerBound = -25;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
