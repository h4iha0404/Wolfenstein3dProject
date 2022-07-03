using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int level;
    private string levelScene;

    private void OnTriggerEnter(Collider other) {
        
        
        if(level < 10)
            levelScene = "Level_0" + level.ToString();
        if(level >= 10)
            levelScene = "Level_" + level.ToString();


        if (other.gameObject.tag == "Player" ) {
            SceneManager.LoadScene(levelScene);
        }
    }
}
