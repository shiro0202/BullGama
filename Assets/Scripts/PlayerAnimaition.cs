using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAnimaition : MonoBehaviour
{
    Animator ani;
    [SerializeField] private GameObject Lazer;
    // Start is called before the first frame update
    void Start()
    {
        Lazer.SetActive(false);
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Lazer.SetActive(true);
            ani.SetBool("attack", true);
            Debug.Log("Å¬¸¯");
        }


        if (Input.GetMouseButtonUp(0))
        {
            Lazer.SetActive(false);
            ani.SetBool("attack", false);
        }
       
    }
}
