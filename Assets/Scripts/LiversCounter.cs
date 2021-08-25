using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiversCounter : MonoBehaviour
{

    //public int lives;
    public int livesCounter;
    public Text texts;

    private TheGameManager gm;
    
     //Start is called before the first frame update
    void Start()
    {
        livesCounter = PlayerPrefs.GetInt("playerLifes");

        gm = GetComponent<TheGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        texts.text = "x " + livesCounter;
        if (livesCounter < 1)
        {
            gm.GameOver();
        }
    }

    public void takeLife()
    {
        livesCounter--;
    }
}
