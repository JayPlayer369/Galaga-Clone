using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    Rigidbody2D bulletRb;
    // Start is called before the first frame update
    void Awake()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
     
    {
                if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
    public void Launch (Vector2 direction, float force)
    {
        bulletRb.AddForce(direction * force);
    }

     void OnCollisionEnter2D(Collision2D other)
     {
        Destroy (gameObject);
        Destroy (other.gameObject);
     }
}
    
    
   