using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteMapManager : MonoBehaviour
{
    public GameObject[] enemies;
    public bool isCompleted = false;
    public GameObject nextLevel;
    void Start()
    {
        nextLevel.GetComponent<NextLevel>().enabled = false;
    }

    
    void Update()
    {
        foreach (GameObject e in enemies)
        {
            if (e.GetComponent<Enemy>().isDied == true)
                isCompleted = true;
            else
                isCompleted = false;
        }

        if (isCompleted == true)
            nextLevel.GetComponent<NextLevel>().enabled = true;
    }
}
