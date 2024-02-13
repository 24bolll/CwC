using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject player;
    private Vector3 offset = new Vector3(51, 6, 20);
    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
