using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    public GameObject SettingsMenu;
    public void StartGame() //This line makes the level start
    {
        SceneManager.LoadScene("Level1"); // this lookes for the level then puts it into the scene

    }

   




    public void QuitGame() // this just prints in the inspector QUIT 
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

