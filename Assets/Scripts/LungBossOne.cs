using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungBossOne : MonoBehaviour
{
    public GameObject targetPosition;
    
    public void Ptn_one()
    {
        float RDNum = Random.Range(3.3f, -4.1f);
        //transform.position = new Vector2(13.4f, RDNum);
        //transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition.transform.position, 1f);
        gameObject.SetActive(false);
    }

}
