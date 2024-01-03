using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collestScript : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 3)
        {
            transform.Translate(Vector2.left * 3 * Time.deltaTime);
        }


    }


 
}
