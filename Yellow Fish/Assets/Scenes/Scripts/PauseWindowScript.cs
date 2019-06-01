using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseWindowScript : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject PauseWindowUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseWindowUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        PauseWindowUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
