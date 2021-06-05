using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float TopBound = 35.0f;
    private float lowerBound = -10.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        
    }
}
