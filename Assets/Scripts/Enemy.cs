using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer;
    float startTime = 3;
    float direction = 1;
    Rigidbody2D enemyRb ;
    // Start is called before the first frame update
    void Start()
    {
        timer = startTime;
        enemyRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer < 0)
        {
            direction = -direction;
            timer = startTime;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 position = enemyRb.position;

        position.x = position.x + Time.deltaTime * 3 * direction;

        enemyRb.MovePosition(position);
    
    }

    
    

    
}


