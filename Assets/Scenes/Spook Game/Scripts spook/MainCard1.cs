using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard1 : MonoBehaviour
{

    [SerializeField] private SceneController1 controller;
    [SerializeField] private GameObject Card_Back1;
    
    public void OnMouseDown()
    {
        if (Card_Back1.activeSelf && controller.canReveal)
        {
            Card_Back1.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image; //This gets the sprite renderer component and changes the property of it's sprite!
    }

    public void Unreveal()
    {
        Card_Back1.SetActive(true);
    }


}