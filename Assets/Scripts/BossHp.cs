using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss1Hp : MonoBehaviour
{
    [SerializeField] public float bossHp = 30f;
    [SerializeField] private Image hpbar;
    [SerializeField] public GameObject Clear;
    [SerializeField] public GameObject Player;
    [SerializeField] public GameObject End;
   // [SerializeField] public GameSceneManager ui;


    public End ed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
       /* Clear = GameObject.Find("GameClear");
        Clear?.SetActive(false);*/
        ed = End.GetComponent<End>();
    }

    // Update is called once per frame
    void Update()
    {
        hpbar.fillAmount = bossHp / 30;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lazer"))
        {
            bossHp -= 1;
            hpbar.fillAmount = bossHp / 30;
        }
            if(bossHp == 0)
            {
                UIManager.instance.ShowClearText();
                Destroy(Player);
                GameSceneManager.instance.LoadnextScene();
                //ed.end();
                Destroy(gameObject);
            }
    }
}
    
    
