using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public AudioSource gunFire;
    public bool isFiring = false;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            if (isFiring == false) {
                StartCoroutine(FiringHandgun());
            }

        }
    }

    IEnumerator FiringHandgun() {
        isFiring = true;
        //theGun.GetComponent<Animator>().Play("HandgunFire");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.45f);
        //theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
