using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void Retry() //This line makes the level start
    {
        SceneManager.LoadScene("Main Menu Scene"); // this lookes for the level then puts it into the scene

    }






    public void QuitGame() // this just prints in the inspector QUIT 
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
