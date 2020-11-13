using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRoomRespawnStars : MonoBehaviour
{

    private float respawnTimer = 0;
    public float delayTime = 1000;


    void Update(){
        print(respawnTimer);
        respawnTimer += 1;
        if(gameObject.active == false && respawnTimer > delayTime){
            Instantiate(gameObject, transform.position,
        transform.rotation);
            gameObject.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            gameObject.SetActive(false);
            respawnTimer = 0;
        }
    }
}
