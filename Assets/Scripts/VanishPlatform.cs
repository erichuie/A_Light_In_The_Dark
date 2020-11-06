using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag=="Player"){
            StartCoroutine("Disappear");
        }
    }

    IEnumerator Disappear() {
         yield return new WaitForSeconds((float)1);
         gameObject.SetActive(false);
    } 
}
