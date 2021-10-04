using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float timeToWait = 3.5f;
    int activeSceneIndex;
    void Start()
    {
        activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (activeSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    private IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadStartScreen();
      
    }

    private void LoadStartScreen()
    {
        SceneManager.LoadScene("Start Screen");
    }
}
