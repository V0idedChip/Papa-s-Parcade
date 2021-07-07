using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   

    public static bool isGamePaused = false;

    public GameObject pauseMenu; //puts this into the unity editor to be able to map the ui onto it 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // biends the key to the menu 
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;    //this looks to see if the 
        isGamePaused = false;

    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;  // stops the scean
        isGamePaused = true;
    }

  
    public void QuitGame() // this just prints in the inspector QUIT 
    {
        Debug.Log("QUIT!");
        SceneManager.LoadScene("MainMenuScene"); ;
    }
}




