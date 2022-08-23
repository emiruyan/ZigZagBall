 using System;
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 namespace ZigZagBall.Ground
 {
  public class GroundFallController : MonoBehaviour
  {
   private Rigidbody rb; //Rigidbody'e eriştik 
   
   private void Start()
   {
    rb = GetComponent<Rigidbody>(); //Rigidbody'nin componentini aldık
   }
   
   public IEnumerator SetRigidbodyValue() 
   {
    yield return new WaitForSeconds(0.75f);
    rb.isKinematic = false;
    rb.useGravity = true;
    
   }
   
  }
 }

