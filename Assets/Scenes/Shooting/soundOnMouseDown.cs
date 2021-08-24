

using UnityEngine;
using UnityEngine.AI;
using System.Collections;


public class soundOnMouseDown : MonoBehaviour
{

   
    public AudioClip Powerup14;
    private AudioSource audioSource;
    
      void Start()
    {

        
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnMouseDown() 
    {
        
        
             audioSource.clip = Powerup14;

            audioSource.Play();
        
    
    }
}