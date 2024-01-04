using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public static PlayerHp instance;

    [SerializeField] public GameObject Over;
    [SerializeField] public GameObject Boss;
    [SerializeField] public GameObject End;
   // public GameSceneManager sceneManager;
    public End ed; 
    //public HpM Hp;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else 
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    private void OnEnable()
    {
       /* Over = GameObject.Find("GameOver");
        Over.SetActive(false);*/
        ed = End?.GetComponent<End>();
    }
    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            HpM.instance.hp -= 1;
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            HpM.instance.hp -= 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Blood"))
        {
            HpM.instance.hp -= 1;
        }
    }

    private void Update()
    {
        if(HpM.instance.hp <= 0)
        {
            UIManager.instance.ShowOverText();
            GameSceneManager.instance.end();
            //ed.end();
            //Destroy(gameObject);
        }
    }
}
