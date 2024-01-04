using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private GameObject clear;
    [SerializeField] private GameObject over;
    Uresa urusa;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        clear.SetActive(false);
        over.SetActive(false);
    }

    public void ShowClearText()
    {
        clear.SetActive(true);
        over.SetActive(false);
        clear.SetActive(false);
    }

    public void ShowOverText()
    {
        clear.SetActive(false);
        over.SetActive(true);
        over.SetActive(false);
    }
}
