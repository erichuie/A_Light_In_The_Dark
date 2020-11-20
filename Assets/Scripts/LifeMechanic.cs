using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeMechanic : MonoBehaviour
{

    public Text uiLifeCount;

    public GameObject gameOverScreen;
    public Sprite[] spriteArr;

    SpriteRenderer sp;

    private int lifeCount;
    
    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        lifeCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "killzone" || other.tag == "purpleStar")
           {
                if (lifeCount == 3){
                    sp.sprite = spriteArr[0];
                    lifeCount--;
                    uiLifeCount.text = "x3";
                }
                else if (lifeCount == 2){
                    sp.sprite = spriteArr[1];
                    lifeCount--;
                    uiLifeCount.text = "x2";
                }
                else if (lifeCount == 1){
                    sp.sprite = spriteArr[2];
                    lifeCount--;
                    uiLifeCount.text = "x1";
                }
                else if (lifeCount == 0){
                    sp.sprite = spriteArr[3];
                    lifeCount--;
                    uiLifeCount.text = "x0";
                }
                else if (lifeCount == -1){
                    gameOverScreen.SetActive(true);
                    gameObject.SetActive(false);
                }
           }
    }
}
