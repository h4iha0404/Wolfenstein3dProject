using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HandgunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource ammoPickSound;
    public GameObject pickupDisplay;

    private void OnTriggerEnter(Collider other) {
        fakeAmmoClip.SetActive(true);
        fakeAmmoClip.SetActive(false);
        ammoPickSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        GlobalAmmo.handgunAmmo += 30;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "+30 Ammo";
        pickupDisplay.SetActive(true);
        
    }
}
