using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungBoss_idle : MonoBehaviour
{
    float rotSpeed = 200f;

    public void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
    }
}
