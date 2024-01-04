using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiverBossTree : MonoBehaviour
{
    public GameManager3 gameManager3;
    public float LBSpeed;
    public GameObject bulletPrefab;
    public Transform LBbulletSpawn;
    public float LBbulletSpeed = 20f;
    public float LBfireRate = 0.5f;
    public Bullet1 bullet1;

    public void lastptn_tree()
    {
        transform.position = new Vector2(5.42f, 0.72f);
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
    }
}
