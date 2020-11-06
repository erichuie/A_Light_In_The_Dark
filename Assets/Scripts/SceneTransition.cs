using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{

    public string sceneLoading;
    public Vector2 playerPos;
    public VectorVal playerStore;
    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player") && !collision.isTrigger){
            playerStore.initialVal = playerPos;
            SceneManager.LoadScene(sceneLoading);
        }

    }
}
