using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject theSoldier;

    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Hit)) {
            hitTag = Hit.transform.tag;
        }
        if (hitTag == "Player") {
            theSoldier.GetComponent<Animator>().Play("Shoot_SingleShot_AR");
            lookingAtPlayer = true;
        }
        else {
            theSoldier.GetComponent<Animator>().Play("Idle_Guard_AR");
            lookingAtPlayer = false;
        }
    }
}
