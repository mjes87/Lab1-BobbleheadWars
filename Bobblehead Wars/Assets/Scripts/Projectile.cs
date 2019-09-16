using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Destroys projectiles when they are no longer visible on screen
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    // Destroys projectiles when they come into contact with a collider
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
