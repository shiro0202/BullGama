using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    public GameObject Lastptn1;
    public GameObject Lastptn2;
    public GameObject Lastptn3;
    public GameObject Lastidle;
    public GameObject Lastfill;
    LiverBossOne LiverOne;
    LiverBossTwo LiverTwo;
    LiverBossTree LiverTree;


    public float delayTime = 5f;
    public int LastBossPtn;



    private void Start()
    {
        Lastidle.SetActive(true);
        Lastptn1.SetActive(false);
        Lastptn2.SetActive(false);
        Lastptn3.SetActive(false);
        LiverOne = Lastptn1.GetComponent<LiverBossOne>();
        LiverTwo = Lastptn2.GetComponent<LiverBossTwo>();
        LiverTree = Lastptn3.GetComponent<LiverBossTree>();
        UpdateF();
    }

    public void UpdateF()
    {
        Lastidle.SetActive(true);
        Lastfill.SetActive(true);
        Lastfill.transform.position = new Vector2(0, -7.63f);

        Invoke("RanPtn2", delayTime);
    }

    void RanPtn2()
    {
        LastBossPtn = Random.Range(1, 4);
        if (LastBossPtn == 1)
        {
            Lastidle.SetActive(false);
            Lastptn1.SetActive(true);
            LiverOne.lastptn_one();
        }
        else if (LastBossPtn == 2)
        {
            Lastidle.SetActive(false);
            Lastptn2.SetActive(true);
            LiverTwo.lastptn_two();
        }
        else if (LastBossPtn == 3)
        {
            Lastidle.SetActive(false);
            Lastptn3.SetActive(true);
            LiverTree.lastptn_tree();
        }
    }
}
