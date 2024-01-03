using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 20f;
    Rigidbody2D rigid;
    int ran;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        ran = Random.Range(1, 5);
        if(ran == 1)
        {
            Up();
        }
        else if (ran == 2)
        {
            Left();
        }
        else if (ran == 3)
        {
            Right();
        }
        else if (ran == 4)
        {
            Down();
        }
    }
    void Up()
    {
        rigid.velocity = transform.up * bulletSpeed;
    }
    void Left()
    {
        rigid.velocity = Vector2.left * bulletSpeed;
    }
    void Right()
    {
        rigid.velocity = transform.right * bulletSpeed;
    }
    void Down()
    {
        rigid.velocity = Vector2.down * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Lazer"))
        {
            Destroy(gameObject);
        }
    }
    
}
