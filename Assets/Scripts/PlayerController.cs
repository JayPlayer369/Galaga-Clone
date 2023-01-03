using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Store the left and Right arrow Keys Or A and D Keys
    float horizontalkey;

    public float speed;

    public GameObject projectilePrefab;

    Rigidbody2D rigidbody2d;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       // Detecting The Left/Right arrow keys or A/D keys being pressed
       // this variable stores -1 for left , 0 for no keys and +1 for Right
        horizontalkey = Input.GetAxis("Horizontal");

        Vector2 playerPosition = transform.position;


        playerPosition.x = playerPosition.x + speed * horizontalkey * Time.deltaTime;
        transform.position = playerPosition;


        if(Input.GetKeyDown (KeyCode.C))
        {
            Launch();
        }
    }

    

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        PlayerProjectile projectile = projectileObject.GetComponent<PlayerProjectile>();
        projectile.Launch(new Vector2(0,1), 500);
    }
       
}
