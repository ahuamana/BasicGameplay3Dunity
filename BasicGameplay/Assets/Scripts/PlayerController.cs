using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    public GameObject projectilePrefab;

    void Update()
    {
         horizontalInput=Input.GetAxis("Horizontal");
         transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Run 
        ////Condicion
        if (transform.position.x < -xRange)
        {
            //siempre quedarse en este bloque
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            //siempre quedarse en este bloque
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }
   
}
