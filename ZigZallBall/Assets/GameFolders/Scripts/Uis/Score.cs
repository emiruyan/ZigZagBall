using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace  ZigZagBall.Uis
{
    public class Score : MonoBehaviour
    {

        public static int score; //Static ve int tipinde bir score değişkeni oluşturduk.
        public TextMeshProUGUI scoreText;

        private void Start()
        {
            score = 0; //Score default olarak sıfırdan başlıyor.
        }

        private void Update()
        {
            scoreText.text = score.ToString(); //scoreText'imizin içindeki Component olan text'i score değişkenimize atadık. Ve ToString'e çevirdik.
        }
    }

}

