using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uresa : MonoBehaviour
{

    PlayerMV player;
    public bool Gan = false;


    private void Awake()
    {
        player = FindAnyObjectByType<PlayerMV>();
    }
    private void Update()
    {


        if (Gan == true)
        {
            if (transform.position.x >= -2)
            {
                transform.Translate(Vector2.left * 4 * Time.deltaTime);
            }
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.Uruusa();
            gameObject.SetActive(false);
        }
    }

    public void GanTrue()
    {
        Gan = true;
        Debug.Log("간때문이야.");
    }
}
