using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
   private bool top;
    
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "purpleStar"){
            gameObject.GetComponent<Rigidbody2D>().gravityScale *= -1;
            if(top == false){
                transform.eulerAngles = new Vector3(0,0,180f);

            }
            else{
                transform.eulerAngles = Vector3.zero;
            }
            top = !top;
        }
    }
}
