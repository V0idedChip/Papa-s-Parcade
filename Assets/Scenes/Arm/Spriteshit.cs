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

    public AudioClip Powerup14;
    private AudioSource audioSource;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        audioSource = gameObject.GetComponent<AudioSource>();

    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            ChangeSprite(newSprite);

            audioSource.clip = Powerup14;
            Debug.Log("skrrt");
            audioSource.Play();
        }
    }
}
