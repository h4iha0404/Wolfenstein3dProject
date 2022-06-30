using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public void PlayButton() {
        SceneManager.LoadScene("Level_01");
    }
    public void LogBookButton() {
        SceneManager.LoadScene("LogBookScene");
    }
    public void ExitButton() {
        Application.Quit();
    }
}
