using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public float speed;

    private Transform target;
    [SerializeField]Transform playerSpawnPoint;

    [SerializeField]Transform purpleStarSpawnPoint;
    public GameObject[] objArr;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("EnemyFollow");
    }

    IEnumerator EnemyFollow() {
         yield return new WaitForSeconds((float)1);
         transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    } 

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.transform.CompareTag("Player")){
            collision.transform.position = playerSpawnPoint.position;
            gameObject.GetComponent<Transform>().position = purpleStarSpawnPoint.position;
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
