using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    
    private float botomLimit = -2f;
    private float leftLimit = -45.0f;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("transform.x: " + transform.position.x);

        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
            
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < botomLimit)
        {
            Destroy(gameObject);
        }

    }
}
