using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunPickup : MonoBehaviour
{
    public AudioSource handgunPickupSound;
    public GameObject realHandgun;
    public GameObject fakeHandgun;
    public GameObject pickupDisplay;
    
    private void OnTriggerEnter(Collider other) {
        realHandgun.gameObject.SetActive(true);
        fakeHandgun.gameObject.SetActive(false);
        handgunPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickupDisplay.SetActive(false);
        pickupDisplay.GetComponent<Text>().text = "Handgun";
        pickupDisplay.SetActive(true);
    }

}
