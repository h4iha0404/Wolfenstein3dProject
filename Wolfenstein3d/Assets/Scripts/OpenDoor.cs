using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject[] enemies;
    public bool isOpened =false;
    public Animator animator;

    void Start()
    {
        animator.SetBool("isOpened", false);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject e in enemies)
        {
            if (e.GetComponent<Enemy>().isDied == true)
                isOpened = true;
            else
                isOpened = false;
        }

        if (isOpened == true) {
            animator.SetBool("isOpened", true);
        }
    }
}
