using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spriteshit : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite(Sprite newSprite)
    { 
        spriteRenderer.sprite = newSprite;
    }
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeSprite(newSprite);
        }
    }
}
