using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZigZagBall.Ground
{
    public class GroundCollisionController : MonoBehaviour
    {
        [SerializeField] private GroundDataTransmiter groundDataTransmiter; 
        
        private void OnCollisionExit(Collision other) //Ball Ground'dan ayrıldığında devreye girecek olan fonksiyon
        {
            if (other.gameObject.CompareTag("Ball")) //Objeye(Ground'a) çarpan objenin Tag'ı "Ball" ise;
            {
                groundDataTransmiter.SetGroundRigidbodyValues();//groundDataTransmiter içerisindeki SetGroundRigidbodyValues() fonksiyonunu çağır.
            }
        }
    }

}

