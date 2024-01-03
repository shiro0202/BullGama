using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LungBossOne : MonoBehaviour
{
    public GameManager gameManager;
    GameObject idle;
    public LungBoss_idle LungIdle;


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
        //Vector2 newPos = targetPoint.transform.position - transform.position;
        //float rotZ = Mathf.Atan2(newPos.y, newPos.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, rotZ);
        //LungIdle = idle.GetComponent<LungBoss_idle>();
    }

    public void Ptn_one()
    {
        Vector3 direction = targetPoint.position - transform.position;
        //transform.Translate(direction.normalized * moveSpeed * Time.deltaTime*-1);
        transform.DOMoveX(-16.2f, 5).OnComplete(()=>
        {
            gameManager.UpdateL();
            RDNum = Random.Range(3.3f, -4.1f);
            transform.position = new Vector2(13.4f, RDNum);
            //Vector2 newPos = targetPoint.transform.position - transform.position;
            //float rotZ = Mathf.Atan2(newPos.y, newPos.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.Euler(0, 0, rotZ);
            gameObject.SetActive(false);

        });
        //transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition.transform.position, 1f);
    }
    

}
