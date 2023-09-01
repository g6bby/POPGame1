using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleAnim : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public GameObject bubble;

    private void Start()
    {
        animator.gameObject.GetComponent<Animator>().enabled = false;
    }

   private void OnCollisionEnter(Collision collision)
    {
        animator.gameObject.GetComponent<Animator>().enabled = true;
        gameObject.SetActive(false);

    }

}
