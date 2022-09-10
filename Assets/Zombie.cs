using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public Vector2 velocity;
    public CharacterController characterController;
    public BoxCollider2D boxCollider2D;
    public int health;
    public float speed = 7;
    public Vector3 dir;
    public float time = 0;
    public float moveRate = 0.5f;
    public Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        dir = new Vector3(-1.0f, 0.0f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        move();
        //moves on continuous cycle
        time += Time.deltaTime;
        if (time >= moveRate)
        {
            time = 0;
        }
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void move()
    {
        float maxSpeed = 20.0f;
        float acc = 10f;
        float decel = 10f;

        

        transform.Translate(dir * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Hit");
        //Handles when zombie collides with projectile
        Projectile projectile = collision.gameObject.GetComponent<Projectile>();
        if (projectile != null && projectile.gameObject.CompareTag("Projectile") )
        {
            Debug.Log("hit by projectile: " + projectile.name);
            health -= projectile.damage;
        }

        if(health <= 0)
        {
            if (this.gameObject != null)
            {
                Destroy(this.gameObject);
            }
        }

    }
}
