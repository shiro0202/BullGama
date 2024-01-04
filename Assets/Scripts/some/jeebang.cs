using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeebang : MonoBehaviour
{
    jeesp jSp;
    Score score;
    [SerializeField] private int jebScore = 100;
    // Start is called before the first frame update
    void Start()
    {
        jSp = FindAnyObjectByType<jeesp>();
        score = FindAnyObjectByType<Score>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lazer"))
        {
            score.GetScore(jebScore);

            jSp.DeleteJee();
            gameObject.SetActive(false);
        }
    }
}
