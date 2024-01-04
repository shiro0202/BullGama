using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] public int Scoren = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = ("score " + Scoren);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    scoreText.text = ("score "+Scoren);
    //}

    public void GetScore(int s)
    {
        Scoren += s;
        scoreText.text = ("score " + Scoren);
    }
}
