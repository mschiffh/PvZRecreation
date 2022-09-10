using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    public int speed;
    public GameObject projectile;
    public BoxCollider2D boxCollider2D;
    public Rigidbody2D Rigidbody2D;

    public Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        damage = 2;
        speed = 70;
        dir = new Vector3(1.0f, 0.0f, 0.0f);
        this.gameObject.tag = "Projectile";
    }

    // Update is called once per frame
    void Update()
    {
        //Move the projectile across the screen
        transform.Translate(dir * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (this.gameObject != null)
        {
            Destroy(this.gameObject);
        }
    }





}
