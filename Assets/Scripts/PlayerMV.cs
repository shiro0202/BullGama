using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMV : MonoBehaviour
{
    public float MaxSpd;

    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if(rigid.velocity.x > MaxSpd)
        {
            rigid.velocity = new Vector2(MaxSpd, rigid.velocity.y);
        }
        else if(rigid.velocity.x < MaxSpd * (-1))
        {
            rigid.velocity = new Vector2(MaxSpd * (-1), rigid.velocity.y);
        }
    }
}
