using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jeesp : MonoBehaviour
{
    GameSceneManager gameSceneManager;
    [SerializeField] private GameObject jeespPrefab1;
    [SerializeField] private GameObject jeespPrefab2;
    public int a = 4;

    int Dj = 0;

    float at1;
    float at2;
    // Start is called before the first frame update
    void Start()
    {
       // gameSceneManager = FindAnyObjectByType<GameSceneManager>();
        jeespPrefab1.SetActive(false); jeespPrefab2.SetActive(false);
        at1 = Random.Range(5f, 10f);
        at2 = Random.Range(5f, 10f);

        StartCoroutine("Spqwn");
    }

    public void DeleteJee()
    {
        Dj++;
        if (Dj >= a)
        {
            StartCoroutine("NS");
        }
    }

    // Update is called once per frame


    IEnumerator Spqwn()
    {
        yield return new WaitForSeconds(at1);
        jeespPrefab1.SetActive(true);
        yield return new WaitForSeconds(at2);
        jeespPrefab2.SetActive(true);

    }

    IEnumerator NS()
    {
        yield return new WaitForSeconds(5f);
        GameSceneManager.instance.LoadnextScene();
    }
}