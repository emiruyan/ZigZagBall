using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZigZagBall.Ground
{
    public class GroundDataTransmiter : MonoBehaviour //Ground scriptlerimizin birbiri ile haberleşmesini bu class üzerinden yapacağız.
    {
        [SerializeField] private GroundFallController groundFallController;//GroundFallController classımıza eriştik.

        public void SetGroundRigidbodyValues()
        {
            StartCoroutine(groundFallController.SetRigidbodyValue());//Coroutine ile groundFallController içerisindeki SetRigidbodyValue() fonksiyonunu çağırdık.
        }
    }

}

