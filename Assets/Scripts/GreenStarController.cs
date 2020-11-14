using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenStarController : MonoBehaviour
{

    public GameObject[] greenStars;
    // Update is called once per frame
    void FixedUpdate()
    {
        for(int i=0; i< greenStars.Length; i++){
            if (greenStars[i].active == false){
                StartCoroutine("RespawnStar", greenStars[i]);
            }
        }
    }

    IEnumerator RespawnStar(GameObject star){
        yield return new WaitForSeconds(6);
        star.SetActive(true);
    }
}
