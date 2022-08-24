using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using ZigZagBall.Uis;

namespace ZigZagBall.Ball
{
    public class BallInputController : MonoBehaviour
    {
       [HideInInspector] public Vector3 _ballDirection; //Vector3 türünde bir değişken oluşturduk.
       public bool  isGameOver;
       public int ballFalling;
       public GameOverScreen gameOverScreen;
      
       
        private void Start()
        {
            _ballDirection = Vector3.left; //_ballDirection'un başlangıç yönü Left olacak. 
        }
 
        private void Update()
        {
            HandleBallInputs();
            GameOver();
        }

      

        private void HandleBallInputs()//Ball'ın Inputlarını buradan alacağız.
        {
            if (Input.GetMouseButtonDown(0)) //Ekrana her dokunduğumuzda 
            {
                ChangeBallDirection();
            }
        }
 
        private void ChangeBallDirection()//Ball'ın yönünü burada değiştiriyoruz.
        {
            if (_ballDirection.x == -1) //Ball default olarak lefte gidiyor. Eğer lefte gidiyor ise;
            {
                _ballDirection = Vector3.forward; //GetMouseButtonDown(0) çağırdığımızda yönünü forward olarak değiştir.
            }
            else
            {
                _ballDirection = Vector3.left;//Tekrar GetMouseButtonDown(0) çağırdığımızda yönünü tekrar left'e çekmiş oluyoruz.
            }
        }

        
        
        private void GameOver()    
        {
            if (transform.position.y <= -5 && !isGameOver)
            {
                gameOverScreen.Setup(ballFalling);
                isGameOver = true;
                
            }
        }
    }
}


