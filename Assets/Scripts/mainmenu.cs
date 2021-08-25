using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    //public int playerLifes;

    public GameObject SettingsMenu;
    public void StartGame() //This line makes the level start
    {
        LoadRandomScene(); // this lookes for the level then puts it into the scene
        //PlayerPrefs.GetInt("playerLifes", playerLifes);
    }

    public void LoadRandomScene()
    {
        int index = Random.Range(1, 5);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");
        //PlayerPrefs.SetInt("playerLifes", playerLifes);
    }

    public void TestButton(string buttonName)
    {
        Debug.Log("TEST BUTTON " + buttonName);
    }


    public void QuitGame() // this just prints in the inspector QUIT 
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

