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


    void OnTriggerEnter2D(Collider2D collision){
        // && Input.GetAxis("Horizontal")==1
        if(collision.CompareTag("Player")){
            cam.transform.position = new Vector3(cam.transform.position.x + (float)13.35, cam.transform.position.y, cam.transform.position.z);
            collision.transform.position += playerChange;
            wallToPreventLeft.SetActive(true);
            previousGameObj.SetActive(false);
            backgroundStarsNext.SetActive(true);
        }
        // else if(collision.CompareTag("Player") && Input.GetAxis("Horizontal")==-1){
        //     cam.transform.position = new Vector3(cam.transform.position.x - (float)13.35, cam.transform.position.y, cam.transform.position.z);
        //     collision.transform.position -= playerChange;
        // }


    }
}
