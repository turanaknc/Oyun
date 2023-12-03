using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PMenu : MonoBehaviour
{
    public static bool gameýsPaused = false;

    public GameObject pauseMenu;

    public GameObject optionsMenu;

    public GameObject panel;

    public AudioSource theme;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameýsPaused)
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
        pauseMenu.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        gameýsPaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
        gameýsPaused = true;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Menu");
    } 
    public void ShowOptions()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(true);
        gameýsPaused=true;
    }
    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }
    public void SetFullScreen(bool isFull)
    {
        Screen.fullScreen= isFull;
    }
    public void SetMusic(bool isMusic)
    {
        theme.mute=isMusic;
    }
}
