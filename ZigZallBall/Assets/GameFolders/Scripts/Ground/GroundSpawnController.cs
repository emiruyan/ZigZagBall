using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


namespace ZigZagBall.Ground
{
    public class GroundSpawnController : MonoBehaviour
    {

        public GameObject lastGroundObject; //Son ground objemizi verdik.
        
        [SerializeField] private GameObject groundPrefab; //Ground'umuzun prefabini verdik.
        
        private GameObject newGroundObject; //Spawn olacak yeni ground'ımızı verdik.
        
        private int groundDirection; //ground'ımızın yönünü verdik. 

        private void Start()
        {
            GenerateRandomNewGrounds();
        }


        public void GenerateRandomNewGrounds()
        {
            for (int i = 0; i < 75; i++) //Başlangıç değeri 0 olan bir bir artarak 75'e kadar gidecek olan bir döngü oluşturduk.
            {
                CreateNewGround();
            }
        }

        private void CreateNewGround() //Instantiate ile yeni groundlar üreteceğimiz fonksiyonumuz
        {
            groundDirection = Random.Range(0, 2); //Minimum ve Maksimum çoğalabileceği direction

            if (groundDirection == 0) //groundDirection eğer 0 ise
            {
                //                                           burada İnstantiate ettiğimiz ground x'in -1f ine yani sola çoğalacak.
                newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x -1f, lastGroundObject.transform.position.y ,lastGroundObject.transform.position.z), Quaternion.identity);
                lastGroundObject = newGroundObject; //Yeni üretilen her ground yeni referans alınacak ground olacak.
            }
            else
            {//                                        burada İnstantiate ettiğimiz ground z'in +1f ine yani ileriye doğru çoğalacak.
               newGroundObject = Instantiate(groundPrefab, new Vector3(lastGroundObject.transform.position.x ,lastGroundObject.transform.position.y,lastGroundObject.transform.position.z + 1f), Quaternion.identity);
               lastGroundObject = newGroundObject;
            }
                
        }
    }
}


