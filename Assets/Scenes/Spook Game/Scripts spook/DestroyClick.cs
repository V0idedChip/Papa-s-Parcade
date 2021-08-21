using UnityEngine;
 using System.Collections;
 
 public class DestroyClick : MonoBehaviour {
     void OnMouseDown() {
         Destroy(gameObject);
         void OnDestroy() {
             TheGameManager.instance.Win();
         }
     }

 }