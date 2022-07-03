using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OKButton : MonoBehaviour
{
    public void okButton () {
        SceneManager.LoadScene("MenuScene");
    }
}
