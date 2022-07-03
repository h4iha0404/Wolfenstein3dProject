using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breaking : MonoBehaviour
{
    public int HPfractured = 100;
    public GameObject Allpoint;
    [Header("Whole Create")]
    public MeshRenderer wholeCrate;
    public BoxCollider boxCollider;
    [Header("Fractured Create")]
    public GameObject fracturedCrate;
    [Header("Audio")]
    public AudioSource crashAudioClip;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BreakingTheThing() {
        wholeCrate.enabled = false;
        boxCollider.enabled = false;
        fracturedCrate.SetActive(true);
        crashAudioClip.Play();
    }

    public void TakeDamage(int damageAmount)
    {
        HPfractured -= damageAmount;
        if(HPfractured <= 0)
        {
            BreakingTheThing();
            Allpoint.SetActive(false);
        }
    }
}
