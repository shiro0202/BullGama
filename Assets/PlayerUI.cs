using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] public GameObject clear;
    // Start is called before the first frame update
    void Start()
    {
        clear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
