using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZigZagBall.Ball;

namespace ZigZagBall.Camera
{
    public class CameraFollowController : MonoBehaviour //Kameramızın Ball'ı takip etme işlemi bu classta gerçekleşecek.
    {
        [SerializeField] private Transform _ballTransform; //Ball Transformunu aldık

        [SerializeField] [Range(0,3)] private float  _lerpValue;
        
        private Vector3 _offset; //Camera ve Ball arasındaki mesafeyi tutacak olan değişken.

        private Vector3 _newPosition;

        private void Start()
        {
            _offset = transform.position - _ballTransform.position; //Camera ve Ball arasındaki mesafeyi çıkardık ve offset değişkenine atadık.
        }

        private void LateUpdate()
        {
            SetCameraSmoothFollow();
        }

        private void SetCameraSmoothFollow()
        {
            _newPosition = Vector3.Lerp(transform.position, _ballTransform.position + _offset, _lerpValue * Time.deltaTime);
            //Camera Ball'ı takip etsin ancak arasındaki mesafeyi(_offSet) korusun istiyoruz.
            transform.position = _newPosition;
        }
    }

}

