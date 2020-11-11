using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameVictory : MonoBehaviour
{

    public GameObject victoryScreen;
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            gameObject.SetActive(false);
            victoryScreen.SetActive(true);
            other.GetComponent<EnergyMechanic>().enabled =false;
        }
    }
}
