using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpM : MonoBehaviour
{
    [SerializeField] private GameObject hpbar1;
    [SerializeField] private GameObject hpbar2;
    [SerializeField] private GameObject hpbar3;
    [SerializeField] private int hp=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (hp > 3)
        {
            hp = 3;
        }



        if (hp <= 0)
        {
            hpbar1.SetActive(false);
            hpbar2.SetActive(false);
            hpbar3.SetActive(false);
        }
         if (hp >= 1)
        {
            hpbar1.SetActive(true);
            hpbar2.SetActive(false);
            hpbar3.SetActive(false);
        }
        if(hp >= 2)
        {
            hpbar2.SetActive(true);
            hpbar3.SetActive(false);
        }
        if(hp >= 3)
        {
            hpbar3.SetActive(true);
        }
    }
}
