using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    [SerializeField]Transform spawnPoint;
    public GameObject[] objArr;

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.CompareTag("Player")){
            collision.transform.position = spawnPoint.position;
            for (int i=0; i<objArr.Length; i++){
                objArr[i].SetActive(false);
                objArr[i].SetActive(true);
                // if (!objArr[i].active){
                //     objArr[i].SetActive(true);
                // }
            }
        }
    }
}
