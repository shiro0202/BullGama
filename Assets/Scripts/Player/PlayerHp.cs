using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    [SerializeField] public GameObject Over;

    public HpM Hp;

    private void Start()
    {
        Over.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            Hp.hp -= 1;
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Hp.hp -= 1;
        }
    }

    private void Update()
    {
        if(Hp.hp == 0)
        {
            Over.SetActive(true);
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
