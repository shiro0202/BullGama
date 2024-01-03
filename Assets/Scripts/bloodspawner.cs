using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodspawner : MonoBehaviour
{

    [SerializeField] private GameObject blood;
    [SerializeField] private float spTime=0.7f;
    private float spTimesave;
    // Start is called before the first frame update
    void Start()
    {
        spTimesave = spTime;
    }

    // Update is called once per frame
    void Update()
    {
        spTime -= Time.deltaTime;
        //Debug.Log(spTime);

        if( spTime < 0)
        {
            Vector2 randompositin = new Vector2(10,Random.Range(-3.4f, 3.4f));
            Instantiate(blood, randompositin, Quaternion.identity);
            spTime = spTimesave;
        }
            
    }
}
