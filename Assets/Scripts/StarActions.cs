using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarActions : MonoBehaviour
{

     public GameObject wall;
     void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Player")
           {
               gameObject.SetActive(false);
               wall.SetActive(false);
           }
    }
}
