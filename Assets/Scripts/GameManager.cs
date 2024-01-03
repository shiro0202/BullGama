using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Ptn1;
    public GameObject Ptn2;
    public GameObject Idle;
    LungBossOne lungOne;
    LungBossTwo lungTwo;

    public float delayTime = 7f;

    private void Start()
    {
        Idle.SetActive(true);
        Ptn1.SetActive(false);
        Ptn2.SetActive(false);
        lungOne = Ptn1.GetComponent<LungBossOne>();
        lungTwo = Ptn2.GetComponent<LungBossTwo>();
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
            Idle.SetActive(false);
            Ptn1.SetActive(true);
            lungOne.Ptn_one();
        }
        else if (BossPtn == 2)
        {
            Idle.SetActive(false);
            Ptn2.SetActive(true);
            lungTwo.Ptn_two();
        }
    }
}
