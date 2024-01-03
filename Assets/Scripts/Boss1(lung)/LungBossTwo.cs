using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungBossTwo : MonoBehaviour
{
    float rotSpeed = 100f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
    }
    public void Ptn_two()
    {
        transform.position = new Vector2(0, 0);

        gameObject.SetActive(false);
    }
}
