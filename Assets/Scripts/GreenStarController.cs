using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenStarController : MonoBehaviour
{

    public GameObject[] greenStars;
    private bool spawnFinish = true;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(spawnFinish == true){
            for(int i=0; i< greenStars.Length; i++){
                if (greenStars[i].active == false){
                    spawnFinish = false;
                    StartCoroutine("RespawnStar", greenStars[i]);
                }
            }
        }
    }

    IEnumerator RespawnStar(GameObject star){
        yield return new WaitForSeconds(4);
        star.SetActive(true);
        spawnFinish = true;
    }
}
