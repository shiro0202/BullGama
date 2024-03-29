using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMV : MonoBehaviour
{
    public float speed = 0.5f;

    public bool Move;

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move = true;
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;

        transform.position = curPos + nextPos;
    }
}
