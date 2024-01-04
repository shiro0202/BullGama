using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBossTwo : MonoBehaviour
{
    public GameManager2 gameManager1;
    public float Speed;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 20f;
    public float fireRate = 0.5f;
    public Bullet1 bullet1;

    public void ptn_two()
    {
        transform.position = new Vector2(0.3f, 2.7f);
        Fire();
        gameManager1.UpdateH();
        gameObject.SetActive(false);
    }
        void Fire()
        {
            // ÃÑ¾Ë ÇÁ¸®ÆÕ »ý¼º
            for (int i = 0; i < 5; ++i)
            {
                GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            }
        }
}
