using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backobject : MonoBehaviour
{

    [SerializeReference] int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*speed * Time.deltaTime);


        if (transform.position.x == -7)
        {
            Destroy(gameObject);
        }
    }
}
