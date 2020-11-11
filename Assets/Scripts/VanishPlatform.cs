using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishPlatform : MonoBehaviour
{    
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
