using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

   public GameMaster gm;

   void start()
   {
      gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
   }
   
   
   
   void OnTriggerEnter(Collider plyr)
   {
      if (plyr.gameObject.tag == "Player")
      {
         gm.lastCheckPointPos = transform.position;
         Debug.Log("Checkpoint");
      }
   }
   
   
   
}
