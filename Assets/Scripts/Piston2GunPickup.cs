using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piston2GunPickup : MonoBehaviour
{
    public AudioSource handgunPickupSound;
    public GameObject realPiston2Handgun;
    public GameObject fakePiston2Handgun;
    
    private void OnTriggerEnter(Collider other) {
        realPiston2Handgun.gameObject.SetActive(true);
        fakePiston2Handgun.gameObject.SetActive(false);
        handgunPickupSound.Play();
    }

}
