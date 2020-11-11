using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimation : MonoBehaviour
{

    public int timeDelay;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("DelayAnimation");
    }

    IEnumerator DelayAnimation(){
        yield return new WaitForSeconds(timeDelay);
        animator.GetComponent<Animator>().enabled = true;
        animator.Play("backgroundStar3");
    }
}
