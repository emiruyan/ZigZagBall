using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZigZagBall.Ball
{
    public class BallDataTransmiter : MonoBehaviour //Bu class'ın görevi diğer classların verilerini birbirine taşımak olacak.
    {

        [SerializeField] private BallInputController _ballInputController;//BallInputController'ı çağırdık.

        public Vector3 GetBallDirection()
        {
            return _ballInputController._ballDirection; //BallInputController içerisindeki _ballDirection'u döndük.
        }
    }

}

