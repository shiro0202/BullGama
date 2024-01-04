using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMV : MonoBehaviour
{
    Score score;
    Dori_Cha DC;
    public float speed = 0.5f;

    public bool Move;

    public bool UresaPower = false;

    private void Awake()
    {
        score = FindAnyObjectByType<Score>();
        DC = FindAnyObjectByType<Dori_Cha>();
    }
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move = true;
        Vector3 curPos = transform.position;
        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;

        transform.position = curPos + nextPos;
    }


    public void Uruusa()
    {
        score.GetScore(200);

        DC.ddd();
        Debug.Log("간겅강 최고오");
        UresaPower = true;
    }

}
