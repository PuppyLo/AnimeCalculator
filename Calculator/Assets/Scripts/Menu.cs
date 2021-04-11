using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public  bool PauseMenu;
    public GameObject PauseMenuUI;

    public void Start()
    {
        Time.timeScale = 1f;
        PauseMenu = false;
    }

    public void MenuButton()
    {
        if (PauseMenu)

        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

   private void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        PauseMenu = false;
    }

    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu = true;
    }

    public void SelectMenu()
    {
        SceneManager.LoadScene("Scenes/SelectScene");
    }
    
}
