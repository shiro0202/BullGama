using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LiverBossTwo : MonoBehaviour
{
    public GameManager3 gameManager3;
    public GameObject LBFill;

    public void lastptn_two()
    {
        LBFill.transform.DOMoveY(-2.7f, 3)
        /*Fill.transform.DOMoveY(-7.63f,1)*/.OnComplete(() =>
        {
            LBFill.SetActive(false);
            gameManager3.UpdateF();
            gameObject.SetActive(false);
        });
    }
}
