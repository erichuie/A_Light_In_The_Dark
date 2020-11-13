using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{

    public Vector3 playerChange;
    public Camera cam;
    public GameObject wallToPreventLeft;

    public GameObject previousGameObj;
    public GameObject backgroundStarsNext;

    public GameObject purpleStarToDespawn= null;

    public GameObject purpleStarToSpawn;


    void OnTriggerEnter2D(Collider2D collision){
        // && Input.GetAxis("Horizontal")==1
        if(collision.CompareTag("Player")){
            //(float)13.35 with circle collider, was colliding twice
            cam.transform.position = new Vector3(cam.transform.position.x + (float)26.67, cam.transform.position.y, cam.transform.position.z);
            collision.transform.position += playerChange;
            wallToPreventLeft.SetActive(true);
            previousGameObj.SetActive(false);
            backgroundStarsNext.SetActive(true);
            purpleStarToDespawn.SetActive(false);
            purpleStarToSpawn.SetActive(true);
        }
        // else if(collision.CompareTag("Player") && Input.GetAxis("Horizontal")==-1){
        //     cam.transform.position = new Vector3(cam.transform.position.x - (float)13.35, cam.transform.position.y, cam.transform.position.z);
        //     collision.transform.position -= playerChange;
        // }


    }
}
