using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuaseMenu : MonoBehaviour
{
    public static bool GameIsPuased = false;

    public GameObject puaseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPuased)
            {
                Resume();
            }
            else
            {
                Puase();
            }
        }
    }

    public void Resume()
    {
        puaseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPuased = false;
    }

    void Puase()
    {
        puaseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPuased = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
