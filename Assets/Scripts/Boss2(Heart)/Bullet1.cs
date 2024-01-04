using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bullet1 : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    public Transform targetPoint;
    Rigidbody2D rigid;
    int ran;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        targetPoint = FindObjectOfType<PlayerMV>().transform;
        Vector2 newPos = targetPoint.transform.position - transform.position;
        float rotZ = Mathf.Atan2(newPos.y, newPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

    }

    void FixedUpdate()
    {
        ran = Random.Range(1, 5);
        Up();
    }
    void Up()
    {
        rigid.velocity = transform.right * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lazer"))
        {
            Destroy(gameObject);
        }
    }

}
