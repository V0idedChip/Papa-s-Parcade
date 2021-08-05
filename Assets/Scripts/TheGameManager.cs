using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheGameManager : MonoBehaviour
{
    public static TheGameManager instance = null;
    
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy (gameObject);
    }
    
    public void Win()
    {
        LoadRandomScene();
    }

    public void LoadRandomScene()
    {
        int index = Random.Range(1, 5);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");
    }
}
