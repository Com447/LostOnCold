using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool gameIsPause = false;
    public GameObject pauseMenuUi;
    public GameObject pauseMenuMenu;
    public GameObject pauseMenuResume;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            
            
            if (gameIsPause)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
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
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
        pauseMenuMenu.SetActive(false);
        pauseMenuResume.SetActive(false);
    }

    void Pause()
    {
        pauseMenuUi.SetActive(enabled);
        Time.timeScale = 0f;
        gameIsPause = true;
        pauseMenuResume.SetActive(enabled);
        pauseMenuMenu.SetActive(enabled);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
