using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Ptn1;
    public GameObject Ptn2;
    LungBossOne lungOne;
    LungBossTwo lungTwo;

    public float delayTime = 7f;

    private void Start()
    {
        int BossPtn = Random.Range(1, 2);
        Ptn1.SetActive(false);
        Ptn2.SetActive(false);
        Ptn1 = GameObject.Find("lung boss");
        Ptn2 = GameObject.Find("lung boss_ptn2");
    }

    private void Update()
    {
        Invoke("RanPtn", delayTime);
    }

    void RanPtn()
    {
        int BossPtn = Random.Range(1, 2);
        if (BossPtn == 1)
        {
            Ptn1.SetActive(true);
            lungOne.Ptn_one();
        }
        else if (BossPtn == 2)
        {
            Ptn2.SetActive(true);
            lungTwo.Ptn_two();
        }
    }
}
