using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ZigZagBall.Ground
{
    public class GroundPositionController : MonoBehaviour
    {
        private GroundSpawnController groundSpawnController; //GroundSpawnController classımıza eriştik

        private Rigidbody rb; //Rigidbody'i çağırdık

        [SerializeField] private float endYValue; 

        private int groundDirection; //Ground'ımızın yönü groundDirection adında int tipinde değişken oluşturduk

        private void Start()
        {
            groundSpawnController = FindObjectOfType<GroundSpawnController>();
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            CheckGroundVerticalPosition();
        }

        private void CheckGroundVerticalPosition() //Düşen Ground'larımızı kontrol ettiğimiz fonksiyon
        {
            if (transform.position.y <= endYValue) //-10 ve aşağısında olursa;
            {
                SetRigidbodyValues();
                SetGroundNewPosition();
            }
        }

        private void SetGroundNewPosition() //Düşen groundlarımıza yeni pozisyonlar ekliyoruz.
        {
            groundDirection = Random.Range(0, 2);

            if (groundDirection == 0) //groundDirection sıfırsa (sola gidiyorsa)
            { 
                //lastGroundObject(Son düşen objemizden) referans alarak düşen grounları tekrardan Random bir şekilde ekliyoruz.
                transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x - 1f, //Yeni bir pozisyon atıyoruz.(Sola)
                    groundSpawnController.lastGroundObject.transform.position.y,
                    groundSpawnController.lastGroundObject.transform.position.z);
            }
            else
            {
                transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x, 
                    groundSpawnController.lastGroundObject.transform.position.y,
                    groundSpawnController.lastGroundObject.transform.position.z +1f); //Yeni bir pozisyon atıyoruz. (İleri)
            }

            groundSpawnController.lastGroundObject = gameObject; //Bağlı olduğu objenin kendisi (Düşen obje tekrardan sıraya girecek)
        }

        private void SetRigidbodyValues()//FallController'da isKinematic ve useGravity yapılarını değiştirmiştik burada tekrar değiştiriyoruz
        {
            rb.isKinematic = true;  
            rb.useGravity = false;
        }
    }

}

