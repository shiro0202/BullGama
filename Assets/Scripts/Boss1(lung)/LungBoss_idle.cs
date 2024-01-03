using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungBoss_idle : MonoBehaviour
{
    float rotSpeed = 100f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
    }
}
