﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string mainMenuScene;
    public GameObject pauseMenu;
    public bool isPaused;

    public GameObject optionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
                isPaused = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void Resume()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ActivateOptions()
    {
        optionsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void ApplyChanges()
    {
        ReturnToPauseScreen();
    }

    public void CancelChanges()
    {
        ReturnToPauseScreen();
    }

    public void ReturnToPauseScreen()
    {
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
