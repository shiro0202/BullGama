using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungBossOne : MonoBehaviour
{
    //public GameObject targetPosition;
    public Transform targetPoint;
    public float moveSpeed = 5f;
    float RDNum;

    private void Awake()
    {
        targetPoint = GameObject.FindWithTag("Target").transform;
    }

    private void Start()
    {
        RDNum = Random.Range(3.3f, -4.1f);
        transform.position = new Vector2(13.4f, RDNum);
    }

    public void Ptn_one()
    {
        Vector3 direction = targetPoint.position - transform.position;
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
        //transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition.transform.position, 1f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Target"))
        {
            gameObject.SetActive(false);
        }
    }

}
