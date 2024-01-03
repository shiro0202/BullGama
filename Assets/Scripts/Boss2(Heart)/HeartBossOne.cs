using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeartBossOne : MonoBehaviour
{
    public GameManager1 gameManager1;
    public GameObject Fill;

    public void ptn_one()
    {
        Fill.transform.DOMoveY(-2.7f,3).OnComplete(() =>
        {
            gameManager1.UpdateH();
            gameObject.SetActive(false);
        });
    }
}
