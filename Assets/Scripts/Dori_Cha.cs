using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Dori_Cha : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    Material material;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.material.DOFade(0, 0);

        
       
       
    }

    public void ddd()
    {
        spriteRenderer.material.DOFade(1, 0.5f);

        StartCoroutine("fadeD");

    }

    IEnumerator fadeD()
    {
        yield return new WaitForSeconds(0.8f);

        spriteRenderer.material.DOFade(0, 0.5f);
    }

    
}
