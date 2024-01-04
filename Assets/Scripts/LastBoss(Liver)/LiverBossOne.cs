using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiverBossOne : MonoBehaviour
{
    public GameObject GameManager3;

    GameManager3 gameManager3;
    public float Speed;
    public GameObject bulletPrefab;
    public Transform LBbulletSpawn;
    public float LBbulletSpeed = 20f;
    public float LBfireRate = 0.5f;
    private float nextFire;
    GameObject LBidle;


    private void Start()
    {
        transform.position = new Vector2(0, 0);
        gameManager3 = GameManager3.GetComponent<GameManager3>();
        //LungIdle = idle.GetComponent<LungBoss_idle>();
    }

    void Update()
    {

    }
    public void lastptn_one()
    {
        nextFire = Time.time + LBfireRate;
        LBFire();

        gameManager3.UpdateF();
        gameObject.SetActive(false);
    }
    void LBFire()
    {
        // ÃÑ¾Ë ÇÁ¸®ÆÕ »ý¼º
        for (int i = 0; i < 5; ++i)
        {
            GameObject bullet = Instantiate(bulletPrefab, LBbulletSpawn.position, LBbulletSpawn.rotation);
        }

        // ÃÑ¾Ë ¹ß»ç
        //bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * bulletSpeed ;

        //    // 2ÃÊ µÚ¿¡ ÆÄ±«
    }
}
