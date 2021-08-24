using UnityEngine;
 using System.Collections;
 
 public class DestroyClick : MonoBehaviour {
     
     public AudioClip Powerup14;
    private AudioSource audioSource;
     

void Start() {
     
        audioSource = gameObject.GetComponent<AudioSource>();
}

 


     void OnMouseDown() {
         
          Destroy(gameObject);
          audioSource.clip = Powerup14;
            Debug.Log("skrrt");
            audioSource.Play();
             
            
        
     }

 }