using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZigZagBall.Ball
{
    public class BallMovementController : MonoBehaviour
    {
        [SerializeField] private BallDataTransmiter _ballDataTransmiter; //BallDataTransmiter'ımızı çaırdık

        [SerializeField] private float _ballMoveSpeed;

        private void Update()
        {
            SetBallMovement();
        }
        
        private void SetBallMovement()//Ball'a hareket katıyoruz.
        {
            transform.position += _ballDataTransmiter.GetBallDirection() * _ballMoveSpeed * Time.deltaTime;
            //     BallDataTransmiter içerisindeki GetBallDirection ile Ball Move Speed ve Time'ı çarpıyoruz.

        }
    }

}

