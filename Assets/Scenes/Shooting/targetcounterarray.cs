using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class targetcounterarray : MonoBehaviour
{
    public AIM aim;
   

void Start()
{
aim = GetComponent<AIM>();
}
          public void OnDestroy() 
          {
              aim.Score();


          
          }
               
           
           
               
              
}