using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using ZigZagBall.Ball;

namespace ZigZagBall.Uis
{
    public class GameOverScreen : MonoBehaviour
    { 
        public TextMeshProUGUI _pointsText;
        public void Setup(int score)
        {
            gameObject.SetActive(true); 
            _pointsText.text = score.ToString() + "POINTS";
        }

        public void PlayAgainButton()
        {
            SceneManager.LoadScene(0);
        }
        


    }
}

