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
   
   public IEnumerator SetRigidbodyValue() //Ground'un düşme işlemi Coroutine fonksiyon ile yapıyoruz.(Zamanlayıcı)
   {
    yield return new WaitForSeconds(0.75f); //0.75 saniye sonra
    rb.isKinematic = false; //isKinematic'i false'a atadık
    rb.useGravity = true; //useGravity'i true'a atadık (Groundlarımızın düşmesi için)
    
   }
   
  }
 }

