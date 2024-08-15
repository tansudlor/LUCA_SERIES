using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool gameIsPause = false;

    public GameObject pauseMenuUI;

    public shooting shooting;
    // Update is called once per frame
    void Update()
    {
        if (Playermovement.alreadyDead == true) { }
        
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (gameIsPause)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
        shooting.enabled = true;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true;
        shooting.enabled = false;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("ShootingMenu");
        Resume();
        Playermovement.alreadyDead = false;

    }

    public void LoadGame()
    {
        SceneManager.LoadScene("StartShooting");
        Resume();
        Playermovement.alreadyDead = false;

    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
