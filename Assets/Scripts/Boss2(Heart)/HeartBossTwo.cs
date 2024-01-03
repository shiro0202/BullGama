using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBossTwo : MonoBehaviour
{
    public GameManager1 gameManager1;

    public void ptn_two()
    {
        gameManager1.UpdateH();
        gameObject.SetActive(false);
    }
}
