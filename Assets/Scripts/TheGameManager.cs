using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheGameManager : MonoBehaviour
{
   void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            destroy(gameObject);
    }
    


    public void LoadRandomScene()
    {
        int index = Random.Range(1, 3);
        SceneManager.LoadScene(index);
        Debug.Log("Scene Loaded");
    }
}
