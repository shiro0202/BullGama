using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HeartBossOne : MonoBehaviour
{
    public GameManager2 gameManager1;
    public GameObject Fill;

    public void ptn_one()
    {
        Fill.transform.DOMoveY(-2.7f, 3)
        /*Fill.transform.DOMoveY(-7.63f,1)*/.OnComplete(() =>
        {
            Fill.SetActive(false);
            gameManager1.UpdateH();
            gameObject.SetActive(false);
        });
    }
}
