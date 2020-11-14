using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRoomRespawnStars : MonoBehaviour
{

    private float respawnTimer = 0;
    public float delayTime;
    

    // void Update(){
    //    // print(respawnTimer);
    //     respawnTimer += Time.deltaTime;
    //     if(respawnTimer > delayTime){
    //         gameObject.SetActive(true);
    //     }
    // }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            gameObject.SetActive(false);
            //gameObject.SetActive(true);
           //respawnTimer = 0;
            // StartCoroutine("RespawnStar");
        }
    }

    // IEnumerator RespawnStar(){
    //     print("respawning");
    //     yield return new WaitForSeconds(3);
    //     gameObject.SetActive(true);
    // }
}
