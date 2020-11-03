using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera mainCam;

    public GameObject player;
    public GameObject triggerToScene2;
    public GameObject triggerToScene1;

    void OnTriggerEnter2D(Collider2D collision) {
         if (collision.tag == "enterToScene2") {
            triggerToScene1.SetActive(false);
            mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y + 16, mainCam.transform.position.z);
            triggerToScene2.SetActive(false);
            StartCoroutine("CoroutineTest1");

         }
         else if(collision.tag == "enterToScene1") {
            triggerToScene2.SetActive(false);
            mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y - 16, mainCam.transform.position.z);
            triggerToScene1.SetActive(false);
            StartCoroutine("CoroutineTest2");

         }
    }

    IEnumerator CoroutineTest1() {
             yield return new WaitForSeconds((float)0.5);
            triggerToScene1.SetActive(true);
            //  mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y + 15, mainCam.transform.position.z);
         } 
    IEnumerator CoroutineTest2() {
            yield return new WaitForSeconds((float)0.5);
        triggerToScene2.SetActive(true);
        //  mainCam.transform.position = new Vector3(mainCam.transform.position.x, mainCam.transform.position.y + 15, mainCam.transform.position.z);
        } 
}
