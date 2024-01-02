using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    private MeshRenderer render;

    public float speed;

    [SerializeField] GameObject player;

    private float offset;

    

    private void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
            offset += Time.deltaTime * speed;
            render.material.mainTextureOffset = new Vector2(offset, 0);
        if (Input.GetKey(KeyCode.D))
        {
            speed = 0.5f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            speed = 0.5f;
        }
        else
        {
            speed = 0.2f;
        }
    }
}
