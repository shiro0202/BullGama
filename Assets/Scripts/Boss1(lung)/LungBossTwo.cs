using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungBossTwo : MonoBehaviour
{
    public GameObject GameManager;

    float rotSpeed = 100f;
    public float Speed;
    GameManager gameManager;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 20f;
    public float fireRate = 0.5f;
    private float nextFire;
    GameObject idle;
    public LungBoss_idle LungIdle;


    private void Start()
    {
        transform.position = new Vector2(0, 0);
        gameManager = GameManager.GetComponent<GameManager>();
        //LungIdle = idle.GetComponent<LungBoss_idle>();
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotSpeed * Time.deltaTime));
    }
    public void Ptn_two()
    {
        nextFire = Time.time + fireRate;
        Fire();
        
        gameManager.UpdateL();
        LungIdle.Update();
        gameObject.SetActive(false);
    }
    void Fire()
    {
        // �Ѿ� ������ ����
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        // �Ѿ� �߻�
        //bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * bulletSpeed ;

    //    // 2�� �ڿ� �ı�
        Destroy(bullet, 2.0f);
    }
}
