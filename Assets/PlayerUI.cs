using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] public GameObject clear;
    [SerializeField] int SceneNumber = 1;
    Uresa urusa;
    // Start is called before the first frame update
    void Start()
    {
        clear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadnextScene()
    {
        if (SceneNumber == 1)
        {

            
            SceneNumber++;

        }

        if (SceneNumber == 2)
        {
            
            SceneNumber++;
        }

        if (SceneNumber == 3)
        {
            
            SceneNumber++;
        }

        if (SceneNumber == 4)
        {
            
            SceneNumber++;
        }
        if (SceneNumber == 5)
        {


            urusa = FindAnyObjectByType<Uresa>();


            urusa.GanTrue();
        }
    }
}
