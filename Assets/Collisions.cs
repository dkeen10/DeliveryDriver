using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    // collision argument gives information about the other object being collided with
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.name);
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Triggered with " + other.gameObject.name);
    }
}
