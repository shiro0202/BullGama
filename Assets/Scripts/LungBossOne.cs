using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungBossOne : MonoBehaviour
{
    public GameObject targetPosition;
    public Transform targetPoint;
    public float moveSpeed = 5f;

    public void Ptn_one()
    {
        float RDNum = Random.Range(3.3f, -4.1f);
        Vector3 direction = targetPoint.position - transform.position;
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);

        transform.position = new Vector2(13.4f, RDNum);
        //transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition.transform.position, 1f);
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.1f)
        {
            gameObject.SetActive(false);
        }    
    }

}
