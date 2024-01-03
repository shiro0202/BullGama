using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public GameObject ptn1;
    public GameObject ptn2;
    public GameObject idle;
    HeartBossOne HeartOne;
    HeartBossTwo HeartTwo;

    public float delayTime = 7f;
    public int BossPtn;



    private void Start()
    {
        idle.SetActive(true);
        ptn1.SetActive(false);
        ptn2.SetActive(false);
        HeartOne = ptn1.GetComponent<HeartBossOne>();
        HeartTwo = ptn2.GetComponent<HeartBossTwo>();
    }

    public void UpdateH()
    {
        idle.SetActive(true);

        Invoke("RanPtn2", delayTime);
    }

    void RanPtn2()
    {
        BossPtn = Random.Range(1, 3);
        if (BossPtn == 1)
        {
            idle.SetActive(false);
            ptn1.SetActive(true);
            HeartOne.ptn_one();
        }
        else if (BossPtn == 2)
        {
            idle.SetActive(false);
            ptn2.SetActive(true);
            HeartTwo.ptn_two();
        }
    }
}
