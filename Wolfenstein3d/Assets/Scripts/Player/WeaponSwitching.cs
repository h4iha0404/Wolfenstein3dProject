using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class WeaponSwitching : MonoBehaviour
{
    InputAction switching;
    public int selectedWeapon = 0;
    public TextMeshProUGUI ammoInfoText;
    public GameObject WP1;
    public GameObject WP2;
    public GameObject WP3;

    void Start()
    {
        
        switching = new InputAction("Scroll", binding: "<Mouse>/scroll");
        switching.AddBinding("<Gamepad>/Dpad");
        switching.Enable();

        SelectWeapon();

        if (selectedWeapon == 0) {
            WP1.SetActive(true);
            WP2.SetActive(false);
            WP3.SetActive(false);
        }
        if (selectedWeapon == 1) {
            WP1.SetActive(false);
            WP2.SetActive(true);
            WP3.SetActive(false);
        }
        if (selectedWeapon == 2) {
            WP1.SetActive(false);
            WP2.SetActive(false);
            WP3.SetActive(true);
        }
    }

    void Update()
    {
        Gun gun = FindObjectOfType<Gun>();
        ammoInfoText.text = gun.currentAmmo + " / " + gun.magazineAmmo;
        
        float scrollValue = switching.ReadValue<Vector2>().y;

        int previousSelected = selectedWeapon;
        if(scrollValue > 0) {
            selectedWeapon++;
            if (selectedWeapon == transform.childCount)
                selectedWeapon = 0;
            if (selectedWeapon == 0) {
                WP1.SetActive(true);
                WP2.SetActive(false);
                WP3.SetActive(false);
            }
            if (selectedWeapon == 1) {
                WP1.SetActive(false);
                WP2.SetActive(true);
                WP3.SetActive(false);
            }
            if (selectedWeapon == 2) {
                WP1.SetActive(false);
                WP2.SetActive(false);
                WP3.SetActive(true);
            }
        } else if (scrollValue < 0) {
            selectedWeapon--;
            if (selectedWeapon == -1)
                selectedWeapon = transform.childCount-1;
            if (selectedWeapon == 0) {
                WP1.SetActive(true);
                WP2.SetActive(false);
                WP3.SetActive(false);
            }
            if (selectedWeapon == 1) {
                WP1.SetActive(false);
                WP2.SetActive(true);
                WP3.SetActive(false);
            }
            if (selectedWeapon == 2) {
                WP1.SetActive(false);
                WP2.SetActive(false);
                WP3.SetActive(true);
            }
        }
        if(previousSelected != selectedWeapon)
            SelectWeapon();

    }

    private void SelectWeapon()
    {
        foreach (Transform weapon in transform)
        {
            weapon.gameObject.SetActive(false);
        }
        transform.GetChild(selectedWeapon).gameObject.SetActive(true);
    }
}
