using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss1Hp : MonoBehaviour
{
    [SerializeField] private float bossHp = 30f;
    [SerializeField] private Image hpbar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hpbar.fillAmount = bossHp / 30;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lazer"))
        {
            bossHp -= 5;
            if(bossHp == 0)
            {
                Destroy(gameObject);
            }
        }
    }
    
    
}